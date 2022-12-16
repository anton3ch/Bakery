using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void TotalCost_ShouldReturnTotalCostOfOneLoafOfBread_PriceForOneLoaf()
    {
      Assert.AreEqual(5, Bread.TotalCost(1));
    }

    [TestMethod]
    public void TotalCost_ShouldReturnTotalCostOfTwoLoafsOfBread_PriceForTwoLoafs()
    {
      Assert.AreEqual(10, Bread.TotalCost(2));
    }

    [TestMethod]
    public void TotalCost_ShouldReturnTotalCostOfTenLoafsOfBread_PriceTenLoafs()
    {
      Assert.AreEqual(35, Bread.TotalCost(10));
    }
  }
}