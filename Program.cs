using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp
{
    class Program
    {
        static void Main(string[] args)
        {
            TheMenu ourmenu = new TheMenu();

            foreach(IMenuItem item in ourmenu)
            {
                Console.WriteLine("{0}  {1}", item.Name, item.Price);
            }

            Console.WriteLine("Enter name of customer: ");
            string name = Convert.ToString(Console.ReadLine());
            Customer Cus1 = new Customer(name);
            Console.WriteLine("Enter number of Order: ");
            int count = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Enter ur Order: ");
                string itemName = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter the quantity: ");
                int itemQuantity = Convert.ToInt32(Console.ReadLine());
                Cus1.Add(new Order(itemName, itemQuantity));
            }

            Console.WriteLine("Amount to be paid: {0} by {1}",Cus1.TotalAmount(),Cus1.CustName);
        }
    }
}
