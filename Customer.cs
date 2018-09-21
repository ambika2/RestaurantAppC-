using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp
{
    class Customer:IEnumerable
    {
        public string CustName { get; set; }
        private List<Order> myOrders;

        public Customer(string name)
        {
            this.CustName = name;
            myOrders = new List<Order>();
        }
        public void Add(Order o)
        {
            this.myOrders.Add(o);
        }

        public IEnumerator GetEnumerator()
        {
            foreach(Order o in myOrders)
                yield return o;
        }
        


        public int TotalAmount()
        {
            
            int amount = 0;
            foreach (Order o in myOrders)
            {
               
                Console.WriteLine("{0} {1} {2}", o.Name, o.Price, o.Quantity);
                
                amount+= o.Price * o.Quantity;
            }
            return amount;
        }

        
    }
}
