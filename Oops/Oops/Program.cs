using Oops.InventoryManagement;
using Oops.InventoryDataManagement;

namespace Oops
{
    public class Program
    {
        static string inventoryFilePath = @"D:\BridgeLabz\Oops\Oops\Oops\Inventory.json";
        static string inventoryDataFilePath = @"D:\BridgeLabz\Oops\Oops\Oops\InventoryDataManagement\InventoryData.json";
        static void Main(string[] args)
        {
            bool flag = true;
            int check = Convert.ToInt32(Console.ReadLine());
            while (flag)
            {
                switch (check)
                {
                    case 1:
                        InventoryDetailsManagement inventoryDetailsManagement = new InventoryDetailsManagement();
                        inventoryDetailsManagement.ReadJsonFile(inventoryFilePath);
                        break;
                    case 2:
                        InventoryDetailsDataManagement inventoryDataManagement = new InventoryDetailsDataManagement();
                        inventoryDataManagement.ReadJsonFile(inventoryDataFilePath);
                        break;
                }
                break;
            }
        }
    }
}