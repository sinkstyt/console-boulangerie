using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
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
      // Arrange
      string newType = "bichon au citron";
      int countOfType = 1;
      int newPrice = 5;

      // Act
      Pastry newPastry = new Pastry(newType, countOfType, newPrice);
      
      // Assert
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void GetPastryPrice_ReturnsPriceOfPastry_Int()
    {
      // Arrange
      string newType = "Charlotte";
      int countOfType = 1;
      int newPrice = 5;
      Pastry newPastry = new Pastry(newType, countOfType, newPrice);
      
      // Act
      int testPastryPrice = newPastry.Price;

      // Assert
      Assert.AreEqual(5, testPastryPrice);
    }

    [TestMethod]
    public void GetBreadPrice_ReturnsPriceOfBread_Int()
    {
      // Arrange
      string newType = "boule";
      int countOfType = 1;
      int newPrice = 7;
      Bread newBread = new Bread(newType, countOfType, newPrice);
      
      // Act
      int testBreadPrice = newBread.Price;

      // Assert
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
    public void GetCount_ReturnsCountOfAllBreadInstances_Int()
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

    // When the user runs the application, they should receive a prompt with a welcome message along with the cost for both Bread and Pastry.

    // A user should be able to specify how many loaves of Bread and how many <Pastry>s they'd like.

    // The application will return the total cost of the order.

    // Pierre offers the following deals:

    // Bread: Buy 2, get 1 free. A single loaf costs $5.
    // Pastry: Buy 1 for \$2 or 3 for $5.
    // All functionality for the models should be tested.

    // [TestMethod]
    // public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()
    // {
        // any necessary logic to prep for test; instantiating new 
            // classes, etc.
    //   Assert.AreEqual(EXPECTED RESULT, CODE TO TEST);
    // }
  }
}