using System;
using BakerySales.Models;

class Program : Product
{
  public string loavesPrice = "A loaf of Pierre's fine bread costs $5";
  public string pastriesPrice = "An individual pastry goes for just $2";
  public string specialsAnnounce = "Specials for today include:";
  public string breadDiscount = "Buy 2 loaves and receive an additional for free";
  public string pastryDiscount = "For every three pastries that you buy, Pierre discounts your order by a whole dollar";

  public void Greet()
  {
    Console.WriteLine(WelcomeToShop);
    Console.WriteLine(loavesPrice);
    Console.WriteLine(pastriesPrice);
    Console.WriteLine(specialsAnnounce);
    Console.WriteLine(breadDiscount);
    Console.WriteLine(pastryDiscount);
  }

  public int offerBreadProduct(string typeProduct, string countWanted)
  {
    Console.WriteLine("Would you like to purchase bread? [yes or no]");
    try
    {
      int numLoaves = int.Parse(Console.ReadLine());
    }
    catch (System.Exception)
    {
      Console.WriteLine("Message = {0}", ex.Message);  
      throw;
    }
        Console.WriteLine("Would you like to purchase bread? [yes or no]");

    Console.WriteLine("How many loaves would you like?")
    try
    {
      int numLoaves = int.Parse(Console.ReadLine());
    }
    catch (System.Exception)
    {
      Console.WriteLine("Message = {0}", ex.Message);  
      throw;
    }
    Console.WriteLine("How many loaves would you like?")
  }

  static void Main()
  {
    Greet();

    Console.WriteLine("Would you like to add pastries to your order? [yes or no]");
    
    Console.WriteLine("How many loaves would you like?")
    try
    {
      int numLoaves = int.Parse(Console.ReadLine());
    }
    catch (System.Exception)
    {
      Console.WriteLine("Message = {0}", ex.Message + "is what our system is telling us. Please enter the number of loaves of bread desired:");

      throw;
    }
  }
}