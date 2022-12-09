using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    // Test methods go here
    [TestMethod]
    public void TotalCost_ShouldReturnTotalCostOfOneLoafOfBread_PriceForOneLoaf()
    {
      Bread testBread = new Bread();
      Assert.AreEqual(5, testBread.TotalCost(1));
    }

    [TestMethod]
    public void TotalCost_ShouldReturnTotalCostOfTwoLoafsOfBread_PriceForTwoLoafs()
    {
      Bread testBread = new Bread();
      Assert.AreEqual(10, testBread.TotalCost(2));
    }

    [TestMethod]
    public void TotalCost_ShouldReturnTotalCostOfTenLoafsOfBread_PriceTenLoafs()
    {
      Bread testBread = new Bread();
      Assert.AreEqual(35, testBread.TotalCost(10));
    }
  }
}