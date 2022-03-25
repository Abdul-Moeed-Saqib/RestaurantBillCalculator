using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantBillCalculator
{
    public class Item
    {
        public string Name { get; set; }

        public string Category { get; set; }

        public int Quantity { get; set; } = 1;

        public decimal Price { get; set; }
    }
}
