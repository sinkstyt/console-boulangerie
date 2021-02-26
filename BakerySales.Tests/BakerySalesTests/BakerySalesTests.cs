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
      Assert.AreEqual(5, testBreadPrice);
    }

    // When the user runs the application, they should receive a prompt with a welcome message along with the cost for both Bread and Pastry.

    // A user should be able to specify how many loaves of Bread and how many Pastrys they'd like.

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