﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinerMax3000Console
{
    public class Order
    {

        public Order()
        {
            items = new List<MenuItem>();
        }
        public List<MenuItem> items; // = new List<MenuItem>();
    }
}
