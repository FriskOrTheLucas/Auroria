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
                string SelectedDirectory = ItemType.SelectedItem.ToString();
                string WriteDirectlyDirectory = $"Data\\Catalog\\{SelectedDirectory}";
                string CreateNewAssetDirectory = "CreatedAssets";

                JObject obj = new JObject
                {
                    { "Name", "" },
                    { "Desc", "" },
                    { "AssetID", "" }
                };

                obj["Name"] = NameBox.Text;
                obj["Desc"] = DescriptionBox.Text;
                obj["AssetID"] = IDBox.Text;

                if (CreateNewAsset.Checked)
                {
                    File.WriteAllText(Path.Combine(CreateNewAssetDirectory, IDBox.Text + ".json"), obj.ToString());
                }
                else
                {
                    File.WriteAllText(Path.Combine(WriteDirectlyDirectory, IDBox.Text + ".json"), obj.ToString());
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
