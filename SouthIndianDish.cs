using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp
{
    class SouthIndianDish:IMenuItem
    {
        public string Name { private set;  get; }
        public int Price { private set;  get; }
        public SouthIndianDish(string name, int price)
        {
            this.Name = name;
            this.Price = price;
           
        }
    }
}
