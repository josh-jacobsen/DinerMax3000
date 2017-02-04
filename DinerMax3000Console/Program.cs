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
            //menusFromDatabase[0].AddNewMenuItem("Smorgas", "Something the Norges like", 7.50);
            //menusFromDatabase = Menu.GetAllMenus();

            for (int i = 0; i < menusFromDatabase.Count; i++)
            {
                Menu currentMenu = menusFromDatabase[i];
                Console.WriteLine("Start of menu: {0}", currentMenu.Name);

                foreach (MenuItem currentItem in currentMenu.items)
                {
                    Console.WriteLine(currentItem.Title);
                }
                Console.WriteLine("End of menu:{0} ", currentMenu.Name);
                //Console.WriteLine(currentMenu.items[i].Title);
            }

            Order hungryGuestOrder = new Order();

            foreach (Menu currentMenu in menusFromDatabase)
            {
                foreach (MenuItem currentItem in currentMenu.items)
                {
                    hungryGuestOrder.items.Add(currentItem);
                }
            }


            Console.WriteLine("The total for hungryGuestOrder is: {0:C}", hungryGuestOrder.OrderTotal);
        }
    }
}
