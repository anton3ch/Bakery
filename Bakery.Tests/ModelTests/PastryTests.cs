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
      Assert.AreEqual(2, Pastry.TotalCost(1));
    }

    [TestMethod]
    public void TotalCost_ShouldReturnTotalCostOfTwoPastries_PriceForTwoPastries()
    {
      Assert.AreEqual(4, Pastry.TotalCost(2));
    }

    [TestMethod]
    public void TotalCost_ShouldReturnTotalCostOfThreePastries_PriceForThreePastries()
    {
      Assert.AreEqual(5, Pastry.TotalCost(3));
    }

    [TestMethod]
    public void TotalCost_ShouldReturnTotalCostOfTenPastries_PriceForTenPastries()
    {
      Assert.AreEqual(17, Pastry.TotalCost(10));
    }
  }
}