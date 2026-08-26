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
using System.Net;

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

        public AurNTBase()
        {   // Gonna be adding a loading screen soon. Which means we may need a bit of a delay here? I will explain
            // if needed. -Lucas

            // future lucas here: this is dumb
            InitializeComponent();
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
            MessageBox.Show(
                "Hello, Welcome to Auroria .NT! Note that Auroria is a work in progress passion project, and some things may not work as expected!",
                "Auroria .NT",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information
            );

            string mapsFolder = "Maps";
            string ChckMapDirectory = @"Maps";
            string ClientsDirectory = "Clients";

            BackgroundBox.Image = Properties.Resources.BannerLong;

            LoadPlayerInfo();
            LoadCatalogListView(@"Data/Catalog/charshirts", ShirtsListView, ShrtsImgList);
            LoadCatalogListView(@"Data/Catalog/charhats", HatsListView, HatsImgList);
            LoadCatalogListView(@"Data/Catalog/charpants", PantsListView, PntsImgList);

            //populate the maps tree view with the map stuff.
            if (!Directory.Exists(ChckMapDirectory))
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
                    button.Image = listview.LargeImageList.Images[selectedItem.ImageKey];
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
            string InfoFilePath = "PlayerSettings.json";

            if (!File.Exists(InfoFilePath))
            {
                MessageBox.Show("PlayerSettings.json file not found! Auroria will generate one for you.", "Auroria .NT", MessageBoxButtons.OK, MessageBoxIcon.Error);

                JObject objnw = new JObject
                {
                    { "PlayerName", "Username" },
                    { "UserID", "123456789" }
                };

                File.WriteAllText("PlayerSettings.json", objnw.ToString());
            }

            string json = File.ReadAllText(InfoFilePath);
            JObject obj = JObject.Parse(json);

            string PlyrName = (string)obj["PlayerName"];
            string id = (string)obj["UserID"];

            PlayerNameBox.Text = PlyrName;
            PlayerIDBox.Text = id;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            string InfoFilePath = "PlayerSettings.json";

            if (!File.Exists(InfoFilePath))
            {
                MessageBox.Show("PlayerSettings.json file not found! Auroria will generate one for you.", "Auroria .NT", MessageBoxButtons.OK, MessageBoxIcon.Error); // error but not error because im goated

                JObject objnw = new JObject
                {
                    { "PlayerName", "" },
                    { "UserID", "" }
                };

                File.WriteAllText("PlayerSettings.json", objnw.ToString());
            }

            string json = File.ReadAllText(InfoFilePath);
            JObject obj = JObject.Parse(json);

            obj["PlayerName"] = PlayerNameBox.Text;
            obj["UserID"] = PlayerIDBox.Text;

            // add W.D Gaster easter egg here later.

            File.WriteAllText(InfoFilePath, obj.ToString());
            MessageBox.Show("Player information saved successfully!", "Auroria .NT", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void JoinBtn_click(object sender, EventArgs e) // im gonna have to redo. ALL. OF. THIS. AND CODE THE ENTIRE WEBSERVER.
        {
            if (ClientList.SelectedItem == null)
            {
                MessageBox.Show("Please select a client to join!", "Auroria .NT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                string curClient = ClientList.SelectedItem.ToString();
                string originalDirectory = Directory.GetCurrentDirectory();

                if (curClient == "2007S")
                {
                    Directory.SetCurrentDirectory("Clients\\2007S\\Player");
                    Process.Start("Roblox.exe", "-script \"" + Directory.GetCurrentDirectory() + "\\..\\Scripts\\joingame.lua");
                    Directory.SetCurrentDirectory(originalDirectory);
                }
                else
                {
                    MessageBox.Show("Either the client EXE doesn't exist, or the client hasnt been added yet!", "Auroria .NT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void HostBtn_Click(object sender, EventArgs e) // whys it hardcoded i need to make it SOFT or else ill cry -Lucas
        {
            if (ClientList.SelectedItem == null)
            {
                MessageBox.Show("Please select a client to host!", "Auroria .NT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                string curClient = ClientList.SelectedItem.ToString();
                string originalDirectory = Directory.GetCurrentDirectory();

                if (MapsTree.SelectedNode == null || MapsTree.SelectedNode.Tag == null)
                {
                    MessageBox.Show("Please select a map to host!", "Auroria .NT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string mapPath = MapsTree.SelectedNode.Tag.ToString();

                if (curClient == "2007S")
                {
                    Directory.SetCurrentDirectory("Clients\\2007S\\Player");
                    Process.Start("Roblox.exe", "-script \"" + Directory.GetCurrentDirectory() + "\\..\\Scripts\\gameserver.lua\" \"" + mapPath + "\"");
                    Directory.SetCurrentDirectory(originalDirectory);
                }
                else
                {
                    MessageBox.Show("Either the client EXE doesn't exist, or the client hasnt been added yet!", "Auroria .NT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
                return;
            }

            string clientSelectedlst = ClientList.SelectedItem.ToString();

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
                ClientInfoBox.Text = "Error, ClientInfo.Json doesn't exist! Which is needed in order for Auroria to launch the client properly, and to display client info! This can be caused by the client not being added [NF], or the Client folder itself being missing!"; // or maybe you forgot to add ClientInfo.json. ez fix!
            }
            else
            {
                string json = File.ReadAllText(clientJsonDir);
                JObject obj = JObject.Parse(json);

                string clientds = (string)obj["ClientDesc"];
                ClientInfoBox.Text = clientds;
            }

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

        private void CookieWzrd_Click(object sender, EventArgs e)
        {
            CookieWizard cookieWizardForm = new CookieWizard();
            cookieWizardForm.Show(); // i coulda just made it a box you type into but i like WIZAAAAAARRRRDDSS
        }

        private void ShrtSlot1_Click(object sender, EventArgs e)
        {
            UpdateBtn(ShirtsListView, ShrtSlot1);
        }
    }
}
