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
  }
}