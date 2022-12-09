namespace Bakery
{
  public class Bread
  {
    public int Price { get; set; } = 5;

    public int (int quantity)
    {
      int finalCost = 0;
      if (quantity == 1) {
        finalCost += Price;
      }
      return finalCost;
    }
  }
}