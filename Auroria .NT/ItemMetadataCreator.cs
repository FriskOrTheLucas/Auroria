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
                string CreatedNewDirectory = $"Data\\Catalog\\{SelectedDirectory}";
                JObject obj = new JObject
                {
                    { "Name", "" },
                    { "Desc", "" },
                    { "AssetID", "" }
                };

                obj["Name"] = NameBox.Text;
                obj["Desc"] = DescriptionBox.Text;
                obj["AssetID"] = IDBox.Text;

                File.WriteAllText(Path.Combine(CreatedNewDirectory, IDBox.Text + ".json"), obj.ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Failed to create asset metadata: {ex}", "Auroria", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
