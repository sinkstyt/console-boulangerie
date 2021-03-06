using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakerySales.Models;
using System;

namespace BakerySales.Tests
{
  [TestClass]
  public class BakerySalesTests : IDisposable
  {

    public void Dispose()
    {
      Bread.ClearAll();
      Pastry.ClearAll();
    }
  
    [TestMethod]
    public void BreadConstructor_InstantiatesBreadInstance_Bread()
    {
      // Arrange
      string newType = "rye";
      int countOfType = 2;

      // Act
      Bread newBread = new Bread(newType, countOfType);
      
      // Assert
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void PastryConstructor_InstantiatesPastryInstance_Pastry()
    {
      string newType = "bichon au citron";
      int countOfType = 1;
      int newPrice = 5;

      Pastry newPastry = new Pastry(newType, countOfType, newPrice);
      
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void GetPastryPrice_ReturnsPriceOfPastry_Int()
    {
      string newType = "Charlotte";
      int countOfType = 1;
      int newPrice = 5;
      Pastry newPastry = new Pastry(newType, countOfType, newPrice);

      int testPastryPrice = newPastry.Price;

      Assert.AreEqual(5, testPastryPrice);
    }

    [TestMethod]
    public void GetBreadPrice_ReturnsPriceOfBread_Int()
    {
      string newType = "boule";
      int countOfType = 1;
      int newPrice = 7;
      Bread newBread = new Bread(newType, countOfType, newPrice);
      
      int testBreadPrice = newBread.Price;

      Assert.AreEqual(7, testBreadPrice);
    }

    [TestMethod]
    public void GetCount_ReturnsCountOfAllPastryInstances_Int()
    {
      string newType = "Conversation";
      int countOfType = 3;
      string secondType = "Cre^pes Suzette";
      int countOfSecond = 4;
      Pastry newPastry = new Pastry(newType, countOfType);
      Pastry oldPastry = new Pastry(secondType, countOfSecond);

      int allInstancesPastry = Pastry.AllPastryInstancesCount();

      Assert.AreEqual(7, allInstancesPastry);
    }

    [TestMethod]
    public void AllBreadInstancesCount_ReturnsCountOfAllBreadInstances_Int()
    {
      string newType = "brioche";
      int countOfType = 12;
      string secondType = "baguette";
      int countOfSecond = 2;
      Bread newBread = new Bread(newType, countOfType);
      Bread crustyBread = new Bread(secondType, countOfSecond);

      int allInstancesBread = Bread.AllBreadInstancesCount();

      Assert.AreEqual(14, allInstancesBread);
    }

    [TestMethod]
    public void CalcPriceBreads_ReturnsCostOfAllBreadInstances_Int()
    {
      string newType = "boule";
      int countOfType = 5;
      int loafPrice = 5;
      string secondType = "baguette";
      int countOfSecond = 32;
      Bread newBread = new Bread(newType, countOfType, loafPrice);
      Bread tastyBread = new Bread(secondType, countOfSecond, loafPrice);

      int allInstancesBreadCost = Bread.CalcPriceBreads();

      Assert.AreEqual(185, allInstancesBreadCost);
    }

    [TestMethod]
    public void CalcPricePastries_ReturnsCostOfAllPastryInstances_Int()
    {
      string newType = "Croquembouche";
      int countOfType = 5;
      int crunchyPrice = 2;
      string flanType = "Flaugnarde";
      int countOfSecond = 32;
      Pastry newTreat = new Pastry(newType, countOfType, crunchyPrice);
      Pastry tastyTreat = new Pastry(flanType, countOfSecond, crunchyPrice);

      int allInstancesPastryCost = Pastry.CalcPricePastries();

      Assert.AreEqual(74, allInstancesPastryCost);
    }

    [TestMethod]
    public void CalcAdjPricePastries_ReturnsCostOfAllPastryInstancesDiscountsApplied_Int()
    {
      string crustyCake = "Galette";
      int countOfType = 5;
      int crunchyPrice = 2;
      string creamyTriangle = "Jesuite";
      int countOfSecond = 32;
      int discountCountThreshold = 3;
      int discountReducer = 1;
      int undiscountedTotal = Pastry.CalcPricePastries();
      Pastry newTreat = new Pastry(crustyCake, countOfType, crunchyPrice);
      Pastry yumTreat = new Pastry(creamyTriangle, countOfSecond, crunchyPrice);

      int allInstancesPastryDiscontedTotal = Pastry.CalcAdjPricePastries(discountCountThreshold, discountReducer);

      Assert.AreEqual(62, allInstancesPastryDiscontedTotal);
    }

    [TestMethod]
    public void CalcAdjNumBreads_ReturnsBreadCountWithBonusApplied_Int()
    {
      string loafOne = "boule";
      int countOfType = 4;
      int boulePrice = 5;
      string eggyLoaf = "brioche";
      int countOfSecond = 36;
      int discountCountThreshold = 2;
      int freeLoafPerPair = 1;
      int undiscountedLoafCount = Bread.AllBreadInstancesCount();
      Bread newBread = new Bread(loafOne, countOfType, boulePrice);
      Bread anotherBread = new Bread(eggyLoaf, countOfSecond, boulePrice);

      int newTotalLoafCount = Bread.CalcAdjNumBreads(discountCountThreshold, freeLoafPerPair);

      Assert.AreEqual(60, newTotalLoafCount);
    }
  }
}