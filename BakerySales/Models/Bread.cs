namespace BakerySales
{
  public class Bread
  {
    private string typeLoaf { get; }
    public string regLoaf { get; set; }
    
    public Bread(string type, int num)
    {
      string Type = type;
      int Count = num;
    }
  }
}