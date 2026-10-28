using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

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
            BodyColorLoad(bodycolorListView, HeadColorBox, "Headcolor");
            BodyColorLoad(bodycolorListView, LeftArmColorBox, "LeftArmcolor");
            BodyColorLoad(bodycolorListView, TorsoColorBox, "Torsocolor");
            BodyColorLoad(bodycolorListView, RightArmColorBox, "RightArmcolor");
            BodyColorLoad(bodycolorListView, RightLegColorBox, "RightLegcolor");
            BodyColorLoad(bodycolorListView, LeftLegColorBox, "LeftLegcolor");
        }
        private void bodycolorListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BodyColorButton(ListView colorsview, PictureBox colorslot, string value)
        {
            if (colorsview.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a color.", "Auroria", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            colorslot.BackColor = colorsview.SelectedItems[0].BackColor;
            colorslot.Tag = colorsview.SelectedItems[0].Tag;

            string json = File.ReadAllText(InfoFile);
            JObject obj = JObject.Parse(json);

            obj[value] = colorslot.Tag.ToString();
            File.WriteAllText(InfoFile, obj.ToString());
        }

        private void BodyColorLoad(ListView colorsview, PictureBox colorslot, string value)
        {
            string json = File.ReadAllText(InfoFile);
            JObject obj = JObject.Parse(json);

            string ColorTag = (string)obj[value];

            foreach (ListViewItem item in colorsview.Items)
            {
                if (item.Tag.ToString() == ColorTag)
                {
                    colorslot.BackColor = item.BackColor;
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
