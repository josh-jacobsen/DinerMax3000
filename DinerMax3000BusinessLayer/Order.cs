using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinerMax3000.Business
{
    public class Order
    {

        public Order()
        {
            items = new List<MenuItem>();
        }

        public List<MenuItem> items; // = new List<MenuItem>();

        public double OrderTotal
        {
            get
            {
                double calculatedTotal = 0;
                foreach (MenuItem item in items)
                {
                    calculatedTotal = calculatedTotal + item.Price;
                }
                return calculatedTotal;
            }
        }
    }
}
