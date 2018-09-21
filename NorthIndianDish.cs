using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp
{
    class NorthIndianDish:IMenuItem
    {
        public string Name { private set;  get; }
        public int Price { private set;  get; }
        public bool IsSpicy;

        public NorthIndianDish(string name,int price,bool spicy=false)
        {
            this.Name = name;
            this.Price = price;
            this.IsSpicy = spicy;
        }
    }
}
