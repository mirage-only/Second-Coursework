using System;
using System.Collections.Generic;
using System.Linq;

namespace Сourse_work_result;

public class Order
{
    public int numberOfOrder { get; set; }
    public List<ServerMenuItem> selectedDishes { get; set; }

    public int totalCost;

    public static int GetCost(List<ServerMenuItem> dishes)
    {
        return dishes.Sum(position => position.Price);
    }
}