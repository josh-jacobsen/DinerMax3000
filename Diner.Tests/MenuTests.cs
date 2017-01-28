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

            summerMenu.items.Add(cupcake);

            Assert.IsTrue(summerMenu.items.Contains(cupcake));

        }

    }
}
