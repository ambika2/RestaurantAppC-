using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp
{
    class Order : TheMenu,IMenuItem
    {
        public string Name { get;  set; }

        public int Price { get; private set; }

        public int Quantity { get; set; }

        public Order(string oname, int oqauntity)
        {
            this.Name = oname;
            this.Price = ourMenu[oname.ToUpper()];
            this.Quantity = oqauntity;
        }
    }
}
