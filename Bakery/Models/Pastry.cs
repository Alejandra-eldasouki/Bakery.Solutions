using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bakery.Models
{
  
  public class Pastry
  {
    public int PastryQuantity { get; set; }
    public int PastryPrice { get; set; }

    public Pastry(int pastryQuantity, int pastryPrice)
    {
      PastryQuantity = pastryQuantity;
      PastryPrice = pastryPrice;
    }

    public int PastryTotal()
    {    
      int thirdPastry = 0;
      if (PastryQuantity < 3)
      {
         return PastryPrice = PastryQuantity * 2;
      }
          else
      {
        for (int i = 1; i <= PastryQuantity; i++)
        {
        if (i % 3 == 0)
        {
          thirdPastry ++;
        }  
      }
       return PastryPrice = (PastryQuantity * 2) - thirdPastry;
      } 
    } 
     public string Pastries()
    {
      if (PastryQuantity > 1)
      {
        return "pastries";
      }
      else
      {
        return "pastry";
      }
    } 
  }
}