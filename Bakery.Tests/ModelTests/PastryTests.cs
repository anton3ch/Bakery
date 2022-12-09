using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void TotalCost_ShouldReturnTotalCostOfOnePastry_PriceForOnePastry()
    {
      Pastry testPastry = new Pastry();
      Assert.AreEqual(2, testPastry.TotalCost(1));
    }

    [TestMethod]
    public void TotalCost_ShouldReturnTotalCostOfTwoPastries_PriceForTwoPastries()
    {
      Pastry testPastry = new Pastry();
      Assert.AreEqual(4, testPastry.TotalCost(2));
    }
  }
}