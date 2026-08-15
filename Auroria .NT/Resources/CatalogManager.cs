using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;

namespace Auroria.NT.Resources
{
    public class CatalogManager
    {
        public List<Item> GetShirts()
        {
            string json = File.ReadAllText(@"Data\Catalog\AvatarItems.json");

            Catalog catalog = JsonConvert.DeserializeObject<Catalog>(json);

            if (catalog == null || catalog.Items == null)
            {
                MessageBox.Show("Error loading items from the catalog. Please check the JSON file for errors.", "Catalog Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<Item>();
            }

            return catalog.Items;
        }
    }
}
