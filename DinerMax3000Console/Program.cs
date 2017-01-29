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

            FoodMenu summerMenu = new FoodMenu();
            summerMenu.Name = "Summer nenu";
            summerMenu.AddMenuItem("Salmon", "Fresh Norwegian Salmon", 25.50);
            summerMenu.AddMenuItem("Beans", "The magical fruit", 5.50);
            summerMenu.AddMenuItem("Tofu", "Vegaterian meat", 15.50);

            try
            {
                summerMenu.AddMenuItem("Expired Item", "Moudly cheese and bread", -100.00);

            }
            catch (Exception thrownException)
            {
                Console.WriteLine(thrownException.Message);
            }

            summerMenu.HospitalDirections = "Turn left at the falafel stand";

            DrinksMenu outsideDrinks = new DrinksMenu();
            outsideDrinks.Disclaimer = "Please don't use glass on the grass";
            outsideDrinks.AddMenuItem("Cuba Libre", "Rum and Coke", 5.0);
             
            Order hungryGuestOrder = new Order();

            for (int i = 0; i < summerMenu.items.Count; i++)
            {
                MenuItem currentItem = summerMenu.items[i];
                hungryGuestOrder.items.Add(currentItem);

            }

            foreach (MenuItem item in summerMenu.items)
            {
                Console.WriteLine(item.Title);
            }


            Console.WriteLine("this is more about leaning the commit message syntax");

            Console.WriteLine("$Title: {0} -- Description: {1}", outsideDrinks.items[0].Title, outsideDrinks.items[0].Description);
            Console.WriteLine(outsideDrinks.Disclaimer);
            Console.WriteLine(summerMenu.HospitalDirections);

            Console.WriteLine("Order total value is: {0:C}", hungryGuestOrder.OrderTotal);



        }
    }
}
