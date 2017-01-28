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
            summerMenu.HospitalDirections = "Turn left at the falafel stand";


            DrinksMenu outsideDrinks = new DrinksMenu();
            outsideDrinks.Disclaimer = "Please don't use glass on the grass";
            outsideDrinks.AddMenuItem("Cuba Libre", "Rum and Coke", 5.0);

            MenuItem salmon = new MenuItem();
            
            salmon.Title = "Salmon";
            salmon.Description = "Fresh Norwegian Salmon";
            salmon.Price = 25.50;

             
            summerMenu.items.Add(salmon);

            Console.WriteLine("$Title: {0} -- Description: {1}", outsideDrinks.items[0].Title, outsideDrinks.items[0].Description);
            Console.WriteLine(outsideDrinks.Disclaimer);
            Console.WriteLine(summerMenu.HospitalDirections);

            Order hungryGuestOrder = new Order();

        }
    }
}
