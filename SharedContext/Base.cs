namespace MercadinhoBigBoom.SharedContext
{
  public class Base
  {
    public Base()
    {
      Id = Guid.NewGuid();
    }
    public Guid Id { get; set; }
  }
}