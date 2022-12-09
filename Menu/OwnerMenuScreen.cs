namespace MercadinhoBigBoom.Menu
{
  public class OwnerMenuScreen : AdmMenuScreen
  {
    static public void Show()
    {
      Console.WriteLine("|==================================|");
      Console.WriteLine("|          Menu Principal          |");
      Console.WriteLine("|==================================|");
      Console.WriteLine("(1) - Inscrição de Fornecedor");
      Console.WriteLine("(2) - Inscrição de Funcionário");
      Console.WriteLine("(3) - Visualizar Fornecedores");
      Console.WriteLine("(4) - Visualizar quadro de Funcionários");
      Console.Write("=====================================: ");

      int test = int.Parse(Console.ReadLine());
      switch (test)
      {
        // case 1: SuplierRegistrationScreen(); break;
        // case 2: EmployeeRegistrationScreen(); break;
        case 3: ReadListCompanies(); break;
        case 4: ReadListEmployees(); break;
        default:
          Console.WriteLine("Opção digita é inválida, por favor tente novamente");
          Show();
          break;
      }
    }
  }
}