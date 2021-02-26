using System.Collections.Generic;

namespace BakerySales.Models
{
  public class Bread
  {
    public string TypeLoaf { get; set; }
    public int CountLoaf { get; set; }
    private static List<Bread> _allLoaves = new List<Bread> { };
    
    public Bread(string type, int num)
    {
      string Type = type;
      int Count = num;
      _allLoaves.Add(this);
    }

    public static void ClearAll()
    {
      _allLoaves.Clear();
    }
  }
}