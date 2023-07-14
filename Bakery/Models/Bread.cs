using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bakery.Models
{
    public class Bread
    {
        public int Quantity { get; set; }
        public int Price { get; set; }

        public Bread(int qty, int price) 
        {
            Quantity = qty;
            Price = price;
        }
    }
}