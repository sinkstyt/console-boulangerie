using System.Collections.Generic;
using System;

namespace BakerySales.Models
{
  public class Bread
  {
    public string TypeLoaf { get; set; }
    public int CountLoaf { get; set; }
    public int Price { get; set; }
    private static List<Bread> _allLoaves = new List<Bread> { };
    
    public Bread(string type, int num)
    {
      TypeLoaf = type;
      CountLoaf = num;
      _allLoaves.Add(this);
    }

    public Bread(string type, int num, int cost)
      : this(type, num)
    {
      Price = cost;
    }

    public static int AllBreadInstancesCount()
    {
      int countOfAllTypes = 0;
      foreach(Bread loaf in _allLoaves)
      {
        countOfAllTypes += loaf.CountLoaf;
      }
      return countOfAllTypes;
    }

    public static int CalcPriceBreads()
    {
      int breadCostTotal = 0;
      foreach(Bread loavesCount in _allLoaves)
      {
        breadCostTotal += loavesCount.Price * loavesCount.CountLoaf;
      }
      return breadCostTotal;
    }

    public static int CalcAdjNumBreads(int countPerDiscount, int bonusLoaves)
    {
      int totalBreadNum = Bread.AllBreadInstancesCount();
      if (totalBreadNum >= 2)
      {
        decimal loafBonusCount = Math.Floor(Convert.ToDecimal(totalBreadNum / countPerDiscount));
        int bonus = Convert.ToInt32(loafBonusCount);
        totalBreadNum += Convert.ToInt32(bonus);
        return totalBreadNum;
      }
      else
      {
        return totalBreadNum;
      }
    }
    
    public static void ClearAll()
    {
      _allLoaves.Clear();
    }
  }
}