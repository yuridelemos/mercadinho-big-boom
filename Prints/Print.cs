namespace MercadinhoBigBoom.Prints
{
  public class PrintChoosers
  {
    public int Number { get; set; }
    public PrintChoosers(int number) => Number = number;
    public void Print()
    {
      switch (Number)
      {
        case 1:
          // System.Console.WriteLine($"Nome: {company.Name}");
          // System.Console.WriteLine($"Número de telefone: {company.PhoneNumber}");
          // System.Console.WriteLine($"Endereço: {company.Address}");
          // System.Console.WriteLine($"CNPJ: {company.CNPJ}");
          // System.Console.WriteLine($"Ramo: {company.LineBusiness}");
          // System.Console.WriteLine($"Nome: {company.CompanyRepresentative.Name}");
          // System.Console.WriteLine($"Número de telefone: {company.CompanyRepresentative.PhoneNumber}");
          break;
      }
    }
  }

}