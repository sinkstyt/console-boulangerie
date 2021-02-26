using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakerySales.Models;

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
  {
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
      string newType = "cinnamon";
      int countOfType = 1;

      // Act
      Pastry newPastry = new Pastry(newType, countOfType);
      
      // Assert
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void GetPastryPrice_GetsPriceOfPastry_Int()
    {
      // Act
      testPastryPrice = Pastry._price.Get();
      
      // Assert
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    // string newType = "bichon au citron";
    // [TestMethod]
    // public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()
    // {
    //   // any necessary logic to prep for test; instantiating new classes, etc.
    //   Assert.AreEqual(EXPECTED RESULT, CODE TO TEST);
    // }
  }
}