namespace BakerySales.Models
{
  public class Bread
  {
    public string TypeLoaf { get; set; }
    public int CountLoaf { get; set; }
    
    public Bread(string type, int num)
    {
      string Type = type;
      int Count = num;
    }
  }
}