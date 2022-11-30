using MercadinhoBigBoom.ContentContext;
using MercadinhoBigBoom.ContentContext.Enum;

namespace MercadinhoBigBoom.Menu
{
  public class MenuTagScreen
  {
    static public void Show()
    {
      System.Console.WriteLine("Menu Principal");
      System.Console.WriteLine("(1) - Inscrição de Fornecedor");
      System.Console.WriteLine("(2) - Inscrição de Funcionário");
      System.Console.WriteLine("(3) - Visualizar Fornecedores");
      System.Console.WriteLine("(4) - Visualizar quadro de Funcionários");
      System.Console.Write("=====================================: ");

      int test = int.Parse(System.Console.ReadLine());
      switch (test)
      {
        case 1:
            SuplierRegistrationScreen();
        break;
        case 2: System.Console.WriteLine("Teste2"); break;
        case 3: System.Console.WriteLine("Teste3"); break;
        case 4: System.Console.WriteLine("Teste4"); break;
        case 5: System.Console.WriteLine("Teste5"); break;
        case 6: System.Console.WriteLine("Teste6"); break;
      }
    }
    public static void SuplierRegistrationScreen()
    {
      System.Console.WriteLine("Dados da empresa");
      System.Console.Write("Nome: ");
      var Name = Console.ReadLine();
      System.Console.Write("Número de telefone: ");
      var PhoneNumber = Console.ReadLine();
      System.Console.Write("Endereço: ");
      var Address = Console.ReadLine();
      System.Console.Write("CNPJ: ");
      var CNPJ = Console.ReadLine();
      System.Console.Write("Ramo da empresa: ");
      var LineBusiness = int.Parse(Console.ReadLine());
      System.Console.Write("Nome do Representante: ");
      var CompanyRepresentativeName = Console.ReadLine();
      System.Console.Write("Número de telefone do Representante: ");
      var CompanyRepresentativePhoneNumber = Console.ReadLine();

      var companyRepresentative = new Representative(CompanyRepresentativeName, CompanyRepresentativePhoneNumber);
      var company = new Company(Name, PhoneNumber, Address, CNPJ, (EContentBranch)LineBusiness, companyRepresentative);
      System.Console.WriteLine($"Nome: {company.Name}");
      System.Console.WriteLine($"Número de telefone: {company.PhoneNumber}");
      System.Console.WriteLine($"Endereço: {company.Address}");
      System.Console.WriteLine($"CNPJ: {company.CNPJ}");
      System.Console.WriteLine($"Ramo: {company.LineBusiness}");
      System.Console.WriteLine($"Nome do Representante: {company.CompanyRepresentative.Name}");
      System.Console.WriteLine($"Número de telefone do Representante: {company.CompanyRepresentative.PhoneNumber}");
      }

        public static void EmployeeRegistrationScreen()
        {

        }
    }

}