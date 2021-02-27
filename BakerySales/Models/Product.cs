using System;

namespace BakerySales.Models
{
  abstract class Product
  {
    public abstract int CalculateTotal();
    public abstract int GatherAllByProperty();

    public string WelcomeToShop = "Welcome to Pierre's Boulangerie. Pierre's offers pastries and loaves of bread. For pricing and what is available today, see below:";

    public void Greet()
    {
      Console.WriteLine(WelcomeToShop);
    }
  }
}