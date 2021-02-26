using System.Collections.Generic;

namespace BakerySales.Models
{
  public class Pastry
  {
    private string _typePastry { get; }
    public string NameLoaf { get; set; }
    public int Price { get; }
    private static List<Pastry> _allPastries = new List<Pastry> { };
    
    public Pastry(string typeOfPastry, int number)
    {
      string Type = typeOfPastry;
      int Count = number;
      _allPastries.Add(this);
      int Price = 1;
    }

    public static void ClearAll()
    {
      _allPastries.Clear();
    }
  }
}