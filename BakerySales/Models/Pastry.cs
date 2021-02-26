using System.Collections.Generic;

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

    public static void ClearAll()
    {
      _allPastries.Clear();
    }
  }
}