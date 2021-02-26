namespace BakerySales
{
  public class Pastry
  {
    private string _typePastry { get; }
    public string NameLoaf { get; set; }
    
    public Pastry(string typeOfPastry, int number)
    {
      string Type = typeOfPastry;
      int Count = number;
    }
  }
}