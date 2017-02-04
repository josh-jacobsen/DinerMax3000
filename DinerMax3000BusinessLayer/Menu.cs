﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DinerMax3000.Business.dsDinerMax3000TableAdapters;

namespace DinerMax3000.Business
{
    public class Menu
    {
        public List<MenuItem> items; // = new List<MenuItem>();

        public Menu()
        {
            items = new List<MenuItem>();
        }

        private int _databaseId;

        public void AddNewMenuItem(string Title, string Description, double Price)
        {
            MenuItemTableAdapter taMenuItem = new MenuItemTableAdapter();
            taMenuItem.InsertNewMenuItem(Title, Description, Price, _databaseId);
         
        }

        public static List<Menu> GetAllMenus()
        {
            MenuTableAdapter taMenu = new MenuTableAdapter();
            MenuItemTableAdapter taMenuItem = new MenuItemTableAdapter();
            var dtMenu = taMenu.GetData();

            List<Menu> allMenus = new List<Menu>();
            foreach (dsDinerMax3000.MenuRow menuRow in dtMenu.Rows)
            {
                Menu currentMenu = new Menu();
                currentMenu.Name = menuRow.Name;
                currentMenu._databaseId = menuRow.Id;
                allMenus.Add(currentMenu);

                var dtMenuItems = taMenuItem.GetMeunuItemsByMenuId(menuRow.Id);
                foreach (dsDinerMax3000.MenuItemRow menuItemRow in dtMenuItems.Rows)
                {
                    currentMenu.AddMenuItem(menuItemRow.Name, menuItemRow.Description, menuItemRow.Price);
                }
            }
            return allMenus;
        }

        public void AddMenuItem(string Title, string Description, double Price )
        {
            MenuItem item = new MenuItem();
            item.Title = Title;
            item.Description = Description;
            item.Price = Price;
            items.Add(item); 

        }

        public string Name;
    }
}
