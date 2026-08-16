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

// Jay Jay if youre reading this then here is the checklist.

//TODO LIST: 
// 1.- Add all needed tabs to the launcher [not done]
// 2.- Add a loading screen [havent even started, oof]
// 3.- Tidy up the UI and MAYBE optimize the code? [idk why i should optimize it i just feel like its not organized]

// 4.- Figure out how to do a Json to catalog. [DONE-Atleast the UI part!!]

// 5.- Add live banner. Basically it grabs the text from https://sites.google.com/view/auroriainfopnl/home?authuser=1 and
// converts it to the Banner text. [havent even started]

// thats just all the stuff we need to do for now, if you have any questions about anything then just ask me on discord. -Lucas
// Oh and if you struggle on something thats aye okay just let me do it dont worry about it :D
namespace Auroria.NT
{
    public partial class AurNTBase : Form
    {
        public AurNTBase()
        {   // Gonna be adding a loading screen soon. Which means we may need a bit of a delay here? I will explain
            // if needed. -Lucas
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

            foreach (string file in Directory.GetFiles(folderPath, "*.rbxl")) // Jay can you make it so that it can show .gz2 and .gz files too pls?
            {
                parentNode.Nodes.Add(Path.GetFileName(file));
            }
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

            string NrmlBanner = "Data\\Banners\\BannerLongNT.png";
            string mapsFolder = "Maps";
            string ChckMapDirectory = @"Maps";

            BackgroundBox.ImageLocation = NrmlBanner;

            LoadPlayerInfo();
            LoadCatalogListView(@"Data/Catalog/charshirts", ShirtsListView, ShrtsImgList);
            LoadCatalogListView(@"Data/Catalog/charhats", HatsListView, HatsImgList);

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

        public void LoadPlayerInfo()
        {
            string InfoFilePath = "PlayerSettings.json";

            if (!File.Exists(InfoFilePath))
            {
                MessageBox.Show("PlayerSettings.json file not found!", "Auroria .NT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
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
                MessageBox.Show("PlayerSettings.json file not found!", "Auroria .NT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string json = File.ReadAllText(InfoFilePath);
            JObject obj = JObject.Parse(json);

            obj["PlayerName"] = PlayerNameBox.Text;
            obj["UserID"] = PlayerIDBox.Text;

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

        // Idk why all of this useless stuff is here, it was auto generated by VS but im not gonna
        // remove it because itll cause errors. Besides if it aint broke dont fix it. -Lucas
        private void MapsLbl_Click(object sender, EventArgs e)
        {

        }

        private void MapsList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MapsTree_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void JoinBtn_click(object sender, EventArgs e)
        {
            
        }

        private void HostBtn_Click(object sender, EventArgs e)
        {

        }

        private void MOTDLabel(object sender, EventArgs e)
        {

        }

        private void ClientList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string errThumbnail = "Data\\ClientThmbnl\\ErrOrCstm\\ClientErCstm.png";

            if (ClientList.SelectedItem != null)
            {
                string selectedClient = ClientList.SelectedItem.ToString();
                // Perform actions based on the selected client

                if (selectedClient == "2007S") // <-- Future note to self since im a C# noob: DONT ADD A ; HERE -Lucas
                {
                    ClientPictureBox.ImageLocation = "Data\\ClientThmbnl\\2007S\\2007Img.png";
                    ClientInfoBox.Text = "A recreation of the February 2007 Client! [Note: Recreation may not be perfectly accurate!]";
                }

                else // Remove this when other clients have been officially added to the launcher. This is just a placeholder cuz im a chud..
                {
                    ClientPictureBox.ImageLocation = errThumbnail;
                    ClientInfoBox.Text = "Client is either custom or Non-Functional!";
                    MessageBox.Show("NF = Non Functional! This Client has NOT been added yet!", "Auroria .NT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
            cookieWizardForm.Show();
        }
    }
}
