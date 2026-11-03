using AuroriaResources;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Windows.Forms;

namespace Auroria.NT
{
    public partial class BodyColorsWindow : Form
    {
        public string InfoFile = "PlayerSettings.json";
        public BodyColorsWindow()
        {
            InitializeComponent();
        }

        public void BodyColorsWindow_load(object sender, EventArgs e)
        {
            GetAndAddBodyColrs(bodycolorListView, colorList);

            BodyColorLoad(HeadColorBox, PlayerSettings.HeadColor);
            BodyColorLoad(LeftArmColorBox, PlayerSettings.LeftArmcolor);
            BodyColorLoad(LeftLegColorBox, PlayerSettings.LeftLegcolor);
            BodyColorLoad(RightArmColorBox, PlayerSettings.RightArmcolor);
            BodyColorLoad(RightLegColorBox, PlayerSettings.RightLegcolor);
            BodyColorLoad(TorsoColorBox, PlayerSettings.TorsoColor);    
        }
        private void bodycolorListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GetAndAddBodyColrs(ListView colorsview, ImageList Colorlist)
        {
            string BodyColorInfo = File.ReadAllText("Data\\BodyColors.json");
            JObject obj = JObject.Parse(BodyColorInfo);

            foreach (var color in obj.Properties())
            {
                JObject value = (JObject)color.Value;
                ListViewItem Item = new ListViewItem((string)value["Name"]);
                Item.Tag = color.Name;
                Colorlist.Images.Add(color.Name, GenerateColorImage((string)value["Color"]));
                Item.ImageKey = color.Name;

                colorsview.Items.Add(Item);
            }
        }

        private Bitmap GenerateColorImage(string value)
        {
            string[] array = value.Split(',');
            int red = int.Parse(array[0]);
            int green = int.Parse(array[1]);
            int blue = int.Parse(array[2]);

            Bitmap bitmap = new Bitmap(32, 32);
            using (Graphics rgb = Graphics.FromImage(bitmap))
            {
                rgb.FillRectangle(new SolidBrush(Color.FromArgb(red, green, blue)), 0, 0, 32, 32);
            }
            return bitmap;
        }

        private void BodyColorButton(ListView colorsview, PictureBox colorslot, string value)
        {
            if (colorsview.SelectedItems.Count == 0)
            {
                return;
            }

            string BodyColorInfo = File.ReadAllText("Data\\BodyColors.json");
            JObject obj = JObject.Parse(BodyColorInfo);

            foreach (var color in obj.Properties())
            {
                if (color.Name == colorsview.SelectedItems[0].Tag.ToString())
                {
                    string rgb = (string)color.Value["Color"];
                    string[] array = rgb.Split(',');
                    int red = int.Parse(array[0]);
                    int green = int.Parse(array[1]);
                    int blue = int.Parse(array[2]);

                    colorslot.BackColor = Color.FromArgb(red, green, blue);
                }
            }

            JObject obj2 = JObject.Parse(File.ReadAllText(InfoFile));
            obj2[value] = colorsview.SelectedItems[0].Tag.ToString();
            File.WriteAllText(InfoFile, obj2.ToString());
        }

        private void BodyColorLoad(PictureBox colorslot, string value)
        {
            string BodyColorInfo = File.ReadAllText("Data\\BodyColors.json");
            JObject obj = JObject.Parse(BodyColorInfo);

            foreach (var color in obj.Properties())
            {
                if (color.Name == value)
                {
                    string rgb = (string)color.Value["Color"];
                    string[] array = rgb.Split(',');
                    int red = int.Parse(array[0]);
                    int green = int.Parse(array[1]);
                    int blue = int.Parse(array[2]);

                    colorslot.BackColor = Color.FromArgb(red, green, blue);
                }
            }
        }

        private void HeadColorBox_Click(object sender, EventArgs e)
        {
            BodyColorButton(bodycolorListView, HeadColorBox, "Headcolor");
        }

        private void LeftArmColorBox_Click(object sender, EventArgs e)
        {
            BodyColorButton(bodycolorListView, LeftArmColorBox, "LeftArmcolor");
        }

        private void TorsoColorBox_Click(object sender, EventArgs e)
        {
            BodyColorButton(bodycolorListView, TorsoColorBox, "Torsocolor");
        }

        private void RightArmColorBox_Click(object sender, EventArgs e)
        {
            BodyColorButton(bodycolorListView, RightArmColorBox, "RightArmcolor");
        }

        private void RightLegColorBox_Click(object sender, EventArgs e)
        {
            BodyColorButton(bodycolorListView, RightLegColorBox, "RightLegcolor");
        }

        private void LeftLegColorBox_Click(object sender, EventArgs e)
        {
            BodyColorButton(bodycolorListView, LeftLegColorBox, "LeftLegcolor");
        }
    }
}
