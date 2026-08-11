using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Auroria.NT
{
    public partial class AurNTBase : Form
    {
        public AurNTBase()
        {
            InitializeComponent();
        }

        private void AddFolder(TreeNode parentNode, string folderPath)
        {
            foreach (string folder in Directory.GetDirectories(folderPath))
            {
                TreeNode folderNode =
                    parentNode.Nodes.Add(Path.GetFileName(folder));

                AddFolder(folderNode, folder);
            }

            foreach (string file in Directory.GetFiles(folderPath, "*.rbxl"))
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
                "Hello, Welcome to Auroria .NT Core!",
                "Auroria .NT",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information
            );

            MessageBox.Show(
                "Note that this is a work in progress edition of Auroria, things may not work as expected!",
                "Auroria .NT",
                MessageBoxButtons.OK, MessageBoxIcon.Information
            );

            string mapsFolder = "Maps";
            string ChckMapDirectory = @"Maps";

            if (!Directory.Exists(ChckMapDirectory))
            {
                MessageBox.Show("Either the Maps folder doesn't exist or Auroria cannot find it!", "Auroria .NT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (string folder in Directory.GetDirectories(mapsFolder))
            {
                TreeNode folderNode =
                    MapsTree.Nodes.Add(Path.GetFileName(folder));

                AddFolder(folderNode, folder);
            }
        }

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
    }
}
