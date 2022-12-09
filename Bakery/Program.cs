using System;
using System.Collections.Generic;

namespace Bakery
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.WriteLine("----------------------");
      Console.WriteLine("Prices:");
      Console.WriteLine($"Bread loaf: ${Bread.Price}");
      Console.WriteLine($"Pastry: ${Pastry.Price}");
      Console.WriteLine("----------------------");
      Console.WriteLine("Today's specials:");
      Console.WriteLine("Bread: Buy 2, get 1 free.");
      Console.WriteLine("Pastry: Buy 1 for $2 or 3 for $5.");
      Console.WriteLine("----------------------");
      Console.WriteLine("Would you like to place an order? (Yes/No):");
      string answer = Console.ReadLine();
      answer = answer.ToLower();

      if(answer == "yes") 
      {
        Console.WriteLine("Do you wanna buy bread?");
        string breadBuy = Console.ReadLine();
        

        Console.WriteLine("Do you wanna buy pastry?");
        string pastryBuy = Console.ReadLine();
      } else if (answer == "no") 
      {
        Console.WriteLine("Thank you for visiting! Come again soon!");
      } else {
        Console.WriteLine("Wrong input. Please, enter 'yes' or 'no'!");
      }
    }
  }
}