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
      bool repeat = true;
      while(repeat)
      {
        Console.WriteLine("Would you like to place an order? (Yes/No):");
        string answer = Console.ReadLine();
        answer = answer.ToLower();

        if(answer == "yes") 
        {
          int breadQuantity;
          int pastryQuantity;
          bool breadLoop = true;
          bool pastryLoop = true;
          while(breadLoop)
          {
            Console.WriteLine("Do you wanna buy bread?(Y/N)");
            string breadBuy = Console.ReadLine();
            breadBuy = breadBuy.ToLower();
            if(breadBuy == "y")
            {
              Console.WriteLine("----------------------");
              Console.WriteLine("The special is Buy 2, get 1 free.");
              Console.WriteLine("How many would you like?");
              string breadQuantityStr = Console.ReadLine();
              breadQuantity = Int32.Parse(breadQuantityStr);
              breadLoop = false;
            } else if (breadBuy == "n")
            {
              breadLoop = false;
            } else if (breadBuy != "n")
            {
              Console.WriteLine("Wrong input. Please, enter 'y' for 'yes' or 'n' for 'no'!");
              breadLoop = true;
            }
          }

          Console.WriteLine("----------------------");
          Console.WriteLine("Do you wanna buy pastry?(Y/N)");
          string pastryBuy = Console.ReadLine();
          pastryBuy = pastryBuy.ToLower();

          if(pastryBuy == "y")
          {
            Console.WriteLine("----------------------");
            Console.WriteLine("The special is Buy 1 for $2 or 3 for $5.");
            Console.WriteLine("How many would you like?");
            string pastryQuantityStr = Console.ReadLine();
            pastryQuantity = Int32.Parse(pastryQuantityStr);
          }

        } else if (answer == "no") 
        {
          Console.WriteLine("Thank you for visiting! Come again soon!");
          repeat = false;
        } else {
          Console.WriteLine("Wrong input. Please, enter 'yes' or 'no'!");
        }
      }
    }
  }
}