using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp
{
    class TheMenu:IEnumerable
    {
        private System.Collections.ArrayList Menu;
        protected Dictionary<string, int> ourMenu;
        public TheMenu(params IMenuItem[] items)
        {
            Menu = new System.Collections.ArrayList();
            IMenuItem item1 = new NorthIndianDish("Litti-Chokha".ToUpper(), 60, true);
            Menu.Add(item1);
            IMenuItem item2 = new SouthIndianDish("Biryani".ToUpper(), 160);
            Menu.Add(item2);
            IMenuItem item3 = new SouthIndianDish("Dosa".ToUpper(), 90);
            Menu.Add(item3);
            IMenuItem item4 = new NorthIndianDish("Roti-Curry".ToUpper(), 80, true);
            Menu.Add(item4);
            ourMenu = new Dictionary<string, int>()
            {
                {item1.Name,item1.Price },
                {item2.Name,item2.Price },
                {item3.Name,item1.Price },
                {item4.Name,item2.Price }
            };
        }
       
        public IEnumerator GetEnumerator()
        {
           foreach(IMenuItem item in Menu)
            {
                yield return item;
            }
        }
    }
}
