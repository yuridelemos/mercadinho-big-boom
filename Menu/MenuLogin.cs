using MercadinhoBigBoom.ContentContext;
using MercadinhoBigBoom.ContentContext.Enum;

namespace MercadinhoBigBoom.Menu
{
  public class MenuLogin
  {
    public static List<Employee> Employees = new List<Employee>();
    static public void Login()
    {
      // Essa conta já será criada automáticamente, será dada ao proprietário para criação da conta dos
      // funcionários e gerente.
      Employee Owner = new Employee("Yuri de Lemos", "21 99999-9999", "Rua GitHub", "123", "123", (EContentSector)0, (EcontentWorkShift)1, 5555.00, DateTime.Now);
      Employees.Add(Owner);
      try
      {
        System.Console.Write("Digite o CPF: ");
        var CPF = Console.ReadLine();
        System.Console.Write("Digite o Password: ");
        var Password = Console.ReadLine();

        var employee = Employees.FirstOrDefault(x => x.CPF == CPF && x.Password == Password);

        switch ((int)employee.Ocuppation)
        {
          case 0:
            var owner = new OwnerMenuScreen();
            owner.Show();
            break;
          case 1:
            // ManagerMenuTagScreen.Show();
            break;
          case 2:
            System.Console.WriteLine("Teste 3");
            // SellerMenuTagScreen.Show();
            break;
        }
      }
      catch (Exception e)
      {
        System.Console.WriteLine("\nCPF ou senha incorretas");
      }
    }
  }
}