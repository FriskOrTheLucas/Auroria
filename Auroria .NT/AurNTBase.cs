using Auroria.NT.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Security.Principal;

// Jay Jay if youre reading this then here is the checklist.

//TODO LIST: 
// 1.- Add all needed tabs to the launcher [done but most tabs r empty]
// 2.- Add a loading screen [havent even started, oof]
// 3.- Tidy up the UI and MAYBE optimize the code? [semi optimized?]

// 4.- Figure out how to do a Json to catalog. [DONE-Atleast the UI part!!]

// 5.- Add live banner. Basically it grabs the text from https://sites.google.com/view/auroriainfopnl/home?authuser=1 and
// converts it to the Banner text. [havent even started]

// 6.- Do make the entire webserver (NO.)

// thats just all the stuff we need to do for now, if you have any questions about anything then just ask me on discord. -Lucas
// Oh and if you struggle on something thats aye okay just let me do it dont worry about it :D

// note to lucas- NEVER TRY TO "organize" THE UI, EVER, AGAIN.
namespace Auroria.NT
{
    public partial class AurNTBase : Form
    {
        public string InfoFilePath = "PlayerSettings.json";
        public string SelectedClient = "";

        public AurNTBase()
        {   // Gonna be adding a loading screen soon. Which means we may need a bit of a delay here? I will explain
            // if needed. -Lucas
            // future lucas here: this is dumb

            InitializeComponent();

            if (CheckPorts.IsTcpPortInUse(80))
            {
                MessageBox.Show("Port 80 is being used by another program. Check taskmanager for things like httpd or webservers and close them.", "Auroria Webserver", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
                return;
            }

            if (CheckPorts.IsTcpPortInUse(443))
            {
                MessageBox.Show("Port 443 is being used by another program. Check taskmanager for things like httpd or webservers and close them.", "Auroria Webserver", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
                return;
            }

            hostsfile.RemoveHosts();
            hostsfile.WriteHosts();
            Apache.WriteHTTPDconf();
            Apache.Install(); // this sucks but im stupid so it shouldnt matter
            Apache.StartService();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                // do the thing
                Apache.StopService();
                hostsfile.RemoveHosts();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to run FormClosing event: {ex.Message}");
            }
        }


        private void AddFolder(TreeNode parentNode, string folderPath) // Populates the Map Tree view.
        {
            foreach (string folder in Directory.GetDirectories(folderPath))
            {
                TreeNode folderNode =
                    parentNode.Nodes.Add(Path.GetFileName(folder));

                AddFolder(folderNode, folder);
            }

            foreach (string file in Directory.GetFiles(folderPath, "*.rbxl"))
            {
                TreeNode node = parentNode.Nodes.Add(Path.GetFileName(file));
                node.Tag = Path.GetFullPath(file);
            }
        }

        private void AddClient(ListBox.ObjectCollection @object, string folderpath)
        {
            @object.Add(Path.GetFileName(folderpath));
        }

        private void PlayPage_Click(object sender, EventArgs e)
        {

        }

        private void AurNTBase_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hello, Welcome to Auroria! Note that Auroria is a work in progress passion project, and some things may not work as expected!", "Auroria", MessageBoxButtons.OK, MessageBoxIcon.Information);

            string errThumbnail = "Data\\ClientThmbnl\\ErrOrCstm\\ClientErCstm.png";
            ClientPictureBox.ImageLocation = errThumbnail;

            string mapsFolder = "Maps";
            string ClientsDirectory = "Clients";

            BackgroundBox.Image = Properties.Resources.BannerLong;

            LoadPlayerInfo();
            LoadCatalogListView(@"Data/Catalog/charshirts", ShirtsListView, ShrtsImgList);
            LoadCatalogListView(@"Data/Catalog/charhats", HatsListView, HatsImgList);
            LoadCatalogListView(@"Data/Catalog/charpants", PantsListView, PntsImgList);

            //populate the maps tree view with the map stuff.
            if (!Directory.Exists(mapsFolder))
            {
                MessageBox.Show("Either the Maps folder doesn't exist or Auroria cannot find it!", "Auroria .NT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // PRAY That it just doesn't exist. If Auroria can't find it, something has gone horribly wrong.
                // Thankfully thats a super low chance right?
            }

            foreach (string folder in Directory.GetDirectories(mapsFolder))
            {
                TreeNode folderNode =
                    MapsTree.Nodes.Add(Path.GetFileName(folder));

                AddFolder(folderNode, folder);
            }

            foreach (string folder in Directory.GetDirectories(ClientsDirectory))
            {
                AddClient(ClientList.Items, folder);
            }
        }


        public void LoadCatalogListView(string directoryPath, ListView listview, ImageList imglist)
        {
            foreach (var file in Directory.GetFiles(directoryPath))
            {
                if (file.EndsWith(".json"))
                {
                    string json = File.ReadAllText(file);
                    JObject obj = JObject.Parse(json);

                    string ShirtName = (string)obj["Name"];
                    string id = (string)obj["AssetID"];
                    string imgPath = Path.Combine(directoryPath, id + ".png");

                    if (File.Exists(imgPath))
                    {
                        imglist.Images.Add(imgPath, Image.FromFile(imgPath));

                        ListViewItem item = new ListViewItem(ShirtName);
                        item.ImageKey = imgPath;

                        listview.Items.Add(item);
                        item.Tag = id;
                    }
                }
            }
        }

        public void UpdateBtn(ListView listview, Button button)
        {
            if (listview.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listview.SelectedItems[0];

                if (!string.IsNullOrEmpty(selectedItem.ImageKey))
                {
                    Image img = listview.LargeImageList.Images[selectedItem.ImageKey];
                    button.Image = new Bitmap(img, button.ClientSize);
                }
            }

            else
            {
                button.Image = null;
            }
        }

        public void SelectedItemUpd(RichTextBox txtbox, ListView listview, string directoryPath)
        {
            if (listview.SelectedItems.Count == 0)
            {
                txtbox.Text = "No items selected!";
                return;
            }

            string selectedItem = listview.SelectedItems[0].Text;

            foreach (var file in Directory.GetFiles(directoryPath))
            {
                if (file.EndsWith(".json"))
                {
                    string json = File.ReadAllText(file);
                    JObject obj = JObject.Parse(json);


                    string itemName = (string)obj["Name"];
                    string Description = (string)obj["Desc"];

                    if (itemName == selectedItem)
                    {
                        txtbox.Text = Description;
                        return;
                    }
                }
            }
        }

        private void ShirtsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedItemUpd(ShrtInfoTxt, ShirtsListView, @"Data/Catalog/charshirts");
        }

        private void HatsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedItemUpd(HatsInfoTxt, HatsListView, @"Data/Catalog/charhats");
        }

        private void PantsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedItemUpd(PntsInfoTxt, PantsListView, @"Data/Catalog/charpants");
        }

        public void LoadPlayerInfo()
        {
            if (!File.Exists(InfoFilePath))
            {
                MessageBox.Show("PlayerSettings.json file not found! Auroria will generate one for you.", "Auroria .NT", MessageBoxButtons.OK, MessageBoxIcon.Error);

                JObject objnw = new JObject
                {
                    { "PlayerName", "Username" },
                    { "UserID", "123456789" },
                    { "AssetURL", "" },
                    { "HatSlot1", "" },
                    { "HatSlot2", "" },
                    { "HatSlot3", "" },
                    { "Head", "" },
                    { "Face", "" },
                    { "Shirt", "" },
                    { "TShirt", "" },
                    { "Pants", "" },
                    { "Package", "" }
                };

                File.WriteAllText("PlayerSettings.json", objnw.ToString());
            }

            string json = File.ReadAllText(InfoFilePath);
            JObject obj = JObject.Parse(json);

            string PlyrName = (string)obj["PlayerName"];
            string id = (string)obj["UserID"];
            string AsstUrl = (string)obj["AssetURL"];

            PlayerNameBox.Text = PlyrName;
            PlayerIDBox.Text = id;
            AssetURLBox.Text = AsstUrl;

            if (AssetURLBox.Text == "")
            {
                string RevertToDefault = "https://assetdelivery.roblox.com/v1/asset/";
                AssetURLBox.Text = RevertToDefault;
            }

            // note for future lucas: Dummy, make sure you change the HatSlotButton, the name of the slot in the json, and the actual charfolder! 
            LoadAvatarItm(HatsSlot1, "HatSlot1", "charhats");
            LoadAvatarItm(HatsSlot2, "HatSlot2", "charhats");
            LoadAvatarItm(HatsSlot3, "HatSlot3", "charhats");
            LoadAvatarItm(ShrtSlot1, "Shirt", "charshirts");
        }

        public void SaveLoadedItm(string itemname, string id)
        {
            if (!File.Exists(InfoFilePath))
            {
                // What??? HOW??? WHEN?? WHY????
                MessageBox.Show("PlayerSettings.json file not found! Try to reload Auroria as that should fix it.", "Auroria .NT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            string json = File.ReadAllText(InfoFilePath);
            JObject obj = JObject.Parse(json);

            obj[itemname] = id;

            File.WriteAllText(InfoFilePath, obj.ToString());
        }

        public void LoadAvatarItm(Button avtrbtn, string itemtyp, string charfolder)
        {
            if (!File.Exists(InfoFilePath))
            {
                // AGAIN??? HOW????
                MessageBox.Show("PlayerSettings.json file not found! Try to reload Auroria as that should fix it.", "Auroria .NT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            string json = File.ReadAllText(InfoFilePath);
            JObject obj = JObject.Parse(json);

            string ItemID = (string)obj[itemtyp];
            string ImagePath = Path.Combine("Data/Catalog/" + charfolder, ItemID + ".png");

            if (!File.Exists(ImagePath))
            {
                return;
            }

            Image img = Image.FromFile(ImagePath);
            avtrbtn.Image = new Bitmap(img, avtrbtn.ClientSize);
            img.Dispose();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (!File.Exists(InfoFilePath))
            {
                // it literally comes with the launcher?????
                MessageBox.Show("PlayerSettings.json file not found! Auroria will generate one for you.", "Auroria .NT", MessageBoxButtons.OK, MessageBoxIcon.Error); // error but not error because im goated

                JObject objnw = new JObject
                {
                    { "PlayerName", "Username" },
                    { "UserID", "123456789" },
                    { "AssetURL", "" },
                    { "HatSlot1", "" },
                    { "HatSlot2", "" },
                    { "HatSlot3", "" },
                    { "Head", "" },
                    { "Face", "" },
                    { "Shirt", "" },
                    { "TShirt", "" },
                    { "Pants", "" },
                    { "Package", "" }
                };

                File.WriteAllText("PlayerSettings.json", objnw.ToString());
            }

            string json = File.ReadAllText(InfoFilePath);
            JObject obj = JObject.Parse(json);

            obj["PlayerName"] = PlayerNameBox.Text;
            obj["UserID"] = PlayerIDBox.Text;

            if (PlayerNameBox.Text == "W.D Gaster")
            {
                // oh hell no
                MessageBox.Show("What have you done", "friskorthelucas", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

            File.WriteAllText(InfoFilePath, obj.ToString());
        }

        private void BodyColorBtn_Click(object sender, EventArgs e)
        {
            BodyColorsWindow bodclrwin = new BodyColorsWindow();
            bodclrwin.Show();
        }

        private void PlayerNameBox_TextChanged(object sender, EventArgs e)
        {
   
        }

        private void MapsTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // no.
        }

        private void SaveAsstUrl_Click(object sender, EventArgs e)
        {
            string json = File.ReadAllText(InfoFilePath);
            JObject obj = JObject.Parse(json);

            obj["AssetURL"] = AssetURLBox.Text;
            File.WriteAllText(InfoFilePath, obj.ToString());
        }

        private void PlayButtonC_Click(object sender, EventArgs e)
        {

        }

        private void PlayButtonC_Hover(object sender, EventArgs e)
        {
            PlayButtonC.Image = Properties.Resources.AurPlayButtonClicked;
        }

        private void PlayButtonC_Leave(object sender, EventArgs e)
        {
            PlayButtonC.Image = Properties.Resources.AurPlayButton;
        }

        private void HostButtonC_Click(object sender, EventArgs e)
        {

        }

        // Idk why all of this useless stuff is here, it was auto generated by VS but im not gonna
        // remove it because itll cause errors. Besides if it aint broke dont fix it. -Lucas
        private void MapsLbl_Click(object sender, EventArgs e)
        {

        }

        private void MapsList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void MOTDLabel(object sender, EventArgs e)
        {

        }

        private void ClientList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string errThumbnail = "Data\\ClientThmbnl\\ErrOrCstm\\ClientErCstm.png";

            if (ClientList.SelectedItem == null)
            {
                ClientPictureBox.ImageLocation = errThumbnail;
                return;
            }

            string clientSelectedlst = ClientList.SelectedItem.ToString();
            SelectedClient = clientSelectedlst;

            string clientThumbDir = "Data\\ClientThmbnl\\" + clientSelectedlst + "\\" + clientSelectedlst + ".png";
            string clientJsonDir = "Clients\\" + clientSelectedlst + "\\ClientInfo.json";

            if (!File.Exists(clientThumbDir))
            {
                ClientPictureBox.ImageLocation = errThumbnail; //the crap works
            }
            else
            {
                ClientPictureBox.ImageLocation = clientThumbDir;
            }

            if (!File.Exists(clientJsonDir))
            {
                ClientInfoBox.Text = "Error, ClientInfo.Json doesn't exist! Which is needed in order for Auroria to launch the client properly, and to display client info! This can be caused by the Client folder itself being missing!"; // or maybe you forgot to add ClientInfo.json. ez fix!
            }
            else
            {
                string json = File.ReadAllText(clientJsonDir);
                JObject obj = JObject.Parse(json);

                string clientds = (string)obj["ClientDesc"];
                ClientInfoBox.Text = clientds;
            }

        }

        private void ItemChanged(ListView listview, Button slot, string slotvar)
        {
            if (listview.SelectedItems.Count == 0)
            {
                UpdateBtn(listview, slot);
                SaveLoadedItm(slotvar, "");
                return;
            }

            ListViewItem selectedItem = listview.SelectedItems[0];
            string id = selectedItem.Tag.ToString();

            UpdateBtn(listview, slot);
            SaveLoadedItm(slotvar, id);
        }

        private void ClientInfoBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClientPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void DCButton_Click(object sender, EventArgs e)
        {
            // theres probably WAY better ways to do this but this is just how i did it because uh yeah
            string url = "https://discord.gg/vrwTt9A6zF";
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open Discord URL: " + ex.Message);
            }
        }

        private void HatsSlot1_Click(object sender, EventArgs e)
        {
            ItemChanged(HatsListView, HatsSlot1, "HatSlot1");
        }

        private void HatsSlot2_Click(object sender, EventArgs e)
        {
            ItemChanged(HatsListView, HatsSlot2, "HatSlot2");
        }

        private void HatsSlot3_Click(object sender, EventArgs e)
        {
            ItemChanged(HatsListView, HatsSlot3, "HatSlot3");
        }

        private void ShrtSlot1_Click(object sender, EventArgs e)
        {
            ItemChanged(ShirtsListView, ShrtSlot1, "Shirt");
        }

        private void HostingBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("It is highly recommended to use the default hosting option on 2015+ as studio hosting can be insecure. And on 2012 its recommended to use player hosting for security.", "Auroria", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void CookieIMPRT_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cookie Imported Successfully.", "Auroria", MessageBoxButtons.OK, MessageBoxIcon.None);

        }
    }
}
