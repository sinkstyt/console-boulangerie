using System;
using BakerySales.Models;

class Program : Product
{
  public string loavesPrice = "A loaf of Pierre's fine bread costs $5";
  public string pastriesPrice = "An individual pastry goes for just $2";
  public string specialsAnnounce = "Specials for today include:";
  public string breadDiscount = "Buy 2 loaves and receive an additional for free";
  public string pastryDiscount = "For every three pastries that you buy, Pierre discounts your order by a whole dollar";

  public string Greet()
  {
    Console.WriteLine(WelcomeToShop);
    Console.WriteLine(loavesPrice);
    Console.WriteLine(pastriesPrice);
    Console.WriteLine(specialsAnnounce);
    Console.WriteLine(breadDiscount);
    Console.WriteLine(pastryDiscount);
    return WelcomeToShop;
  }


  static void Main()
  {
    Console.WriteLine();
  }
}