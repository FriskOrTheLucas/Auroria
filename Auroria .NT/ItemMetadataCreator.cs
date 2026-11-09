using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Windows.Forms;

namespace Auroria.NT
{
    public partial class ItemMetadataCreator : Form
    {
        public ItemMetadataCreator()
        {
            InitializeComponent();
        }

        private void ItemMetadataCreator_Load(object sender, EventArgs e)
        {

        }

        private void CreateMetadata_Click(object sender, EventArgs e)
        {
            try
            {
                string WriteDirectlyDirectory = $"Data\\Catalog\\{ItemType.SelectedItem.ToString()}";
                string CreateNewAssetDirectory = "CreatedAssets";

                JObject obj = new JObject
                {
                    { "Name", "" },
                    { "Desc", "" },
                    { "AssetID", "" }
                };

                string GeneratedDescription = "Description: " + DescriptionBox.Text + " Date Created: " + DateBox.Text + " Creator: " + CreatorBox.Text;

                obj["Name"] = NameBox.Text;
                obj["Desc"] = GeneratedDescription;
                obj["AssetID"] = IDBox.Text;

                if (CreateNewAsset.Checked)
                {
                    File.WriteAllText(Path.Combine(CreateNewAssetDirectory, IDBox.Text + ".info.json"), obj.ToString());
                }
                else
                {
                    if (ItemType.SelectedItem == null)
                    {
                        MessageBox.Show($"Please make sure to select where to save the asset!", "Auroria", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    File.WriteAllText(Path.Combine(WriteDirectlyDirectory, IDBox.Text + ".info.json"), obj.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to create asset metadata: {ex}", "Auroria", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
