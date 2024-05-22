using System.Collections.Generic;
using Сourse_work_result;

namespace Сorse_work_result;

public class MenuCreator
{
    private static List<ServerMenuItem> AddMenu()
    {
        var menu = new List<ServerMenuItem>();   
        
        ServerMenuItem item = new ServerMenuItem
        {
            Name = "Эспрессо",
            Price = 13
        };

        menu.Add(item);
        
        item = new ServerMenuItem
        {
            Name = "Каппучино",
            Price = 21
        };
        menu.Add(item);
        
        item = new ServerMenuItem
        {
            Name = "Латте",
            Price = 34
        };
        menu.Add(item);
        
        item = new ServerMenuItem
        {
            Name = "Гляссе",
            Price = 11
        };
        menu.Add(item);

        return menu;
    }
    
    public void CreateMenu()
    {
        JsonController.SaveMenuToJson(AddMenu());
    }
}