using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinerMax3000Console
{
    public class Menu
    {
        public Menu()
        {
            items = new List<MenuItem>();
        }
        public string Name;
        public List<MenuItem> items;
    }
}
