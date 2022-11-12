using Newtonsoft.Json;
using Oops.InventoryManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops.InventoryDataManagement
{
    public class InventoryDetailsDataManagement
    {
        public void ReadJsonFile(string file)
        {
            var jsonData = File.ReadAllText(file);
            InventoryData inventories = JsonConvert.DeserializeObject<InventoryData>(jsonData);
            List<Inventory> riceList = inventories.Rice;
            Display(riceList);
            List<Inventory> wheatList = inventories.Rice;
            Display(wheatList);
            List<Inventory> pulsesList = inventories.Rice;
            Display(pulsesList);

        }
        public void Display(List<Inventory> inventories)
        {
            foreach (var data in inventories)
            {
                Console.WriteLine(data.Name + " " + data.Price + " " + data.Weight);
            }
        }
    }
}
