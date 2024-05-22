using System.Collections.Generic;

namespace Client
{
    public class ClientOrder
    {
        public int numberOfOrder { get; set; }
        
        private static List<ClientMenuItem> selectedDishes { get; set; }

        public int totalCost { get; set; }
    }
}