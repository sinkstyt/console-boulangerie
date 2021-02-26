using System.Collections.Generic;
using System;

namespace BakerySales.Models
{
  public class Pastry
  {
    public string Type { get; set; }
    public int Count { get; set; }
    public int Price { get; set; }
    private static List<Pastry> _allPastries = new List<Pastry> { };
    
    public Pastry(string typeOfPastry, int numberOf)
    {
      Type = typeOfPastry;
      Count = numberOf;
      _allPastries.Add(this);
    }

    public Pastry(string typeOfPastry, int numberOf, int thisPrice)
      : this(typeOfPastry, numberOf)
    {
      Price = thisPrice;
    }

    public static int AllPastryInstancesCount()
    {
      int countOfAllTypes = 0;
      foreach(Pastry pastry in _allPastries)
      {
        countOfAllTypes += pastry.Count;
      }
      return countOfAllTypes;
    }

    public static int CalcPricePastries()
    {
      int costForAllPastries = 0;
      foreach(Pastry desiredNumber in _allPastries)
      {
        costForAllPastries += desiredNumber.Count * desiredNumber.Price;
      }
      return costForAllPastries;
    }

    public static int CalcAdjPricePastries(int countForDiscount, int discount)
    {
      int adjustedTotal = Pastry.CalcPricePastries();
      Console.WriteLine("adjustedTotal before if is {0}", adjustedTotal);
      int totalPastryNum = Pastry.AllPastryInstancesCount();
      if (totalPastryNum >= 3)
      {
        decimal validForDiscount = Math.Floor(Convert.ToDecimal(totalPastryNum / countForDiscount));
        Console.WriteLine("validForDiscount value is {0}", validForDiscount);
        decimal amountToDiscount = Convert.ToDecimal(validForDiscount * discount);
        Console.WriteLine("amountToDiscount value is {0}", amountToDiscount);
        adjustedTotal -= Convert.ToInt32(amountToDiscount);
      } else {
        adjustedTotal = Pastry.CalcPricePastries();
      }
      return adjustedTotal;
    }

    public static void ClearAll()
    {
      _allPastries.Clear();
    }
  }
}