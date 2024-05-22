using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Сourse_work_result;

public abstract class JsonController
{
    public static List<ServerMenuItem> ReadMenuFromJson()
    {
        var json = File.ReadAllText(@"D:\University\Course Paper KSIS\work\Сorse work result\Server\Json\JsonDataOfMenu.json");
        
        var menu = JsonConvert.DeserializeObject<List<ServerMenuItem>>(json);

        return menu;
    }

    public static void SaveOrdersToJson(List<Order> orders)
    {
        var json = JsonConvert.SerializeObject(orders, Formatting.Indented);
        File.WriteAllText(@"D:\University\Course Paper KSIS\work\Сorse work result\Server\Json\JsonHistoryOfOrders.json", json);
    }

    public static List<Order> ReadOrdersFromJson()
    {
        var json = File.ReadAllText(@"D:\University\Course Paper KSIS\work\Сorse work result\Server\Json\JsonHistoryOfOrders.json");

        var orders = JsonConvert.DeserializeObject<List<Order>>(json);

        return orders;
    }
    
    public static void SaveMenuToJson(List<ServerMenuItem> menu)
    {
        
        var json = JsonConvert.SerializeObject(menu, Formatting.Indented);
        File.WriteAllText(@"D:\University\Course Paper KSIS\work\Сorse work result\Server\Json\JsonDataOfMenu.json", json);
    }
}