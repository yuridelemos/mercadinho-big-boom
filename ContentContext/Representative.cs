namespace MercadinhoBigBoom.ContentContext
{
  public class Representative
  {
    public Representative(string name, string phoneNumber)
    {
        Name = name;
        PhoneNumber = phoneNumber;
    }
    public string Name { get; set; }
    public string PhoneNumber { get; set; }
  }
}