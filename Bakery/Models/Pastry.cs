namespace Bakery.Models
{
  public class Pastry
  {
    public static int Price { get; set; } = 2;

    public static int TotalCost(int quantity)
    {
      int finalCost = 0;
      if (quantity < 3)
      {
        finalCost = Price * quantity;
      } else if (quantity >= 3)
      {
        for(int i = 1; i <= quantity; i ++)
        if(i % 3 == 0) 
        {
          finalCost += 1;
        } else 
        {
          finalCost += 2;
        }
      }
      return finalCost;
    }
  }
}