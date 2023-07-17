using System;
using System.Collections.Generic;
using Bakery.Models;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("------------------------------");
        Console.WriteLine("Welcome to Pierre's Bakery!");
        Console.WriteLine("Bread: Buy 2, get 1 free. A single loaf costs $5.");
        Console.WriteLine("Pastry: Buy 3, get 1 free. A single pastry costs $2.");
        Console.WriteLine("------------------------------");

        Console.Write("Enter the number of loaves of Bread: ");
        int Quantity;
        int.TryParse(Console.ReadLine(), out Quantity);
        int Price = 5;

        Console.Write("Enter the number of Pastries: ");
        int pastryQuantity;
        int.TryParse(Console.ReadLine(), out pastryQuantity);
        int PastryPrice = 2;

        Console.WriteLine("---------------------------------------------------");
        Console.WriteLine("Your Order:");
        Bread addBread = new Bread(Quantity, Price);
        Pastry addPastry = new Pastry(pastryQuantity, PastryPrice);
        Console.WriteLine(addBread.Quantity + " " + addBread.Loaf() + " of bread and " + addPastry.PastryQuantity + " " + addPastry.Pastries());
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine("Your Total for today is:");
        Console.WriteLine("-  $" + (addBread.BreadPrice() + addPastry.PastryTotal()) + ".00  -");
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine("Would you like to add another order? Enter 'Y' for yes or 'N' for no.");
        string? yesOrNo = Console.ReadLine()?.ToLower();
        if (!string.IsNullOrEmpty(yesOrNo) && yesOrNo == "y")
        {
            Main();
        }
        else
        {
            Console.WriteLine("Thank you! Have a nice day :)");
        }
    }
}
