using DinerMax3000.Business;
using DinerMax3000Console;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diner.Tests
{
    [TestClass]
    public class MenuTests
    {

        [TestMethod]

        public void GetsMenusFromDB()
        {
            List<Menu> menusFromDatabase = Menu.GetAllMenus();




        }

        [TestMethod]
        public void CreatesMenuItem()
        {
            MenuItem salmon = new MenuItem();
            salmon.Title = "Salmon";
            salmon.Description = "Fresh Norwegian Salmon";
            salmon.Price = 25.50;

            Assert.AreEqual(25.50, salmon.Price);
            Assert.AreEqual("Salmon", salmon.Title);
        }

        [TestMethod]
        public void AddsMenuItemToMenu()
        {
            MenuItem cupcake = new MenuItem();
            Menu summerMenu = new Menu();
            summerMenu.Name = "Summer menu";

            summerMenu.items.Add(cupcake);

            Assert.IsTrue(summerMenu.items.Contains(cupcake));
        }

        [TestMethod]
        public void DefineMenuName()
        {
            Menu winterMenu = new Menu();
            winterMenu.Name = "Winter menu";

            Assert.AreEqual("Winter menu", winterMenu.Name);

        }
        [TestMethod]
        public void AddMenuItem()
        {
            Menu summerMenu = new Menu();
            summerMenu.AddMenuItem("Raisens", "Dried fruit", 2.0);


            Assert.AreEqual("Raisens", summerMenu.items[0].Title);

        }
        [TestMethod]
        public void CreatesFoodMenu()
        {
            FoodMenu foodMenu = new FoodMenu();
            foodMenu.AddMenuItem("Fries", "Potatoe chips", 5.0);
            Assert.AreEqual("Fries", foodMenu.items[0].Title);
        }

        [TestMethod]
        public void CreateOrder()
        {
            Order customerOrder = new Order();
            MenuItem orderItem = new MenuItem();
            orderItem.Title = "Everything";
            customerOrder.items.Add(orderItem);
            Assert.AreEqual("Everything", customerOrder.items[0].Title);

        }

    }
}
