namespace Bakery
{
  public class Bread
  {
    public int Price { get; set; } = 5;

    public int TotalCost(int quantity)
    {
      int finalCost = 0;
      if (quantity < 3) {
        finalCost += Price * quantity;
      }
      return finalCost;
    }
  }
}