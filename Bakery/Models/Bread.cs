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

    public int BreadPrice()
    {    
      int freeBread = 0;
      if (Quantity < 3)
      {
         return Price = Quantity * 5;
      }
          else
      {
        for (int i = 1; i <= Quantity; i++)
        {
        if (i % 3 == 0)
        {
          freeBread ++;
        }  
      }
       return Price = (Quantity - freeBread) * 5;
      } 
    }  
    
    public string Loaf()
    {
      if (Quantity > 1)
      {
        return "loaves";
      }
      else
      {
        return "loaf";
      }
    }
  } 
}  