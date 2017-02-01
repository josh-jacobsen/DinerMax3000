using DinerMax3000.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinerMax3000Console
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Menu> menusFromDatabase = Menu.GetAllMenus();

            Order hungryGuestOrder = new Order();

            foreach (Menu currentMenu in menusFromDatabase)
            {
                foreach (MenuItem currentItem in currentMenu.items)
                {
                    hungryGuestOrder.items.Add(currentItem);
                }
            }


            Console.WriteLine("The total is: " + hungryGuestOrder.OrderTotal);
        }
    }
}
