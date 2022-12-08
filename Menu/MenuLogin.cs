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
      Employee Owner = new Employee("Yuri de Lemos", "21 99999-9999", "Rua GitHub", "123456789", "12479905938", (EContentSector)0, (EcontentWorkShift)1, 5555.00, DateTime.Now);
      Employees.Add(Owner);
      System.Console.Write("Digite o CPF: ");
      var CPF = Console.ReadLine();
      System.Console.Write("Digite o Password: ");
      var Password = Console.ReadLine();

      //   Pessoa pessoa = pessoas.FirstOrDefault(x => x.CPF == CPF && x.Senha == senha);
      Employee employee = Employees.FirstOrDefault(x => x.CPF == CPF && x.Password == Password);

      System.Console.WriteLine(employee.Name);
      System.Console.WriteLine(employee.CPF);
      MenuTagScreen.Show();
      var chooser = 0;
      switch (chooser)
      {
        case 1:
          //OwnerMenuTagScreen
          break;
        case 2:
          //ManagerMenuTagScreen
          break;
        case 3:
          //SellerMenuTagScreen
          break;
        default:
          break;
      }
    }
  }
}