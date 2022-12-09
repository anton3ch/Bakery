namespace Bakery
{
  public class Pastry
  {
    public int Price { get; set; } = 2;

    public int TotalCost(int quantity)
    {
      int finalCost = 0;
      if (quantity < 3)
      {
        finalCost = Price * quantity;
      }
      return finalCost;
    }
  }
}