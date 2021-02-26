using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakerySales.Models;

namespace BakerySales.Tests
{
  [TestClass]
  public class BakerySalesTests
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

    // [TestMethod]
    // public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()
    // {
    //   // any necessary logic to prep for test; instantiating new classes, etc.
    //   Assert.AreEqual(EXPECTED RESULT, CODE TO TEST);
    // }
  }
}