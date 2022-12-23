
namespace MercadinhoBigBoom.Menu
{
  class ManagerMenuScreen : AdmMenuScreen
  {
    public override void Show()
    {
      base.Show();
      var chooser = int.Parse(Console.ReadLine());
      switch (chooser)
      {
        case 1: SuplierRegistrationScreen(); break;
        case 2: EmployeeRegistrationScreen(); break;
        case 3: ReadListCompanies(); break;
        case 4: ReadListEmployees(); break;
        case 5: EditCompanies(); break;
        case 6: PrintEditEmployees(); break;
        case 7: MenuLogin.Login(); break;
        default:
          Console.Clear();
          Console.WriteLine("Opção digita é inválida, por favor tente novamente");
          Show();
          break;
      }
    }
    protected override void SuplierRegistrationScreen()
    {
      base.SuplierRegistrationScreen();
    }
    protected override void EmployeeRegistrationScreen()
    {
      base.EmployeeRegistrationScreen();
    }
    protected override void ReadListCompanies()
    {
      base.ReadListCompanies();
    }
    protected override void ReadListEmployees()
    {
      base.ReadListEmployees();
    }
    protected override void EditCompanies()
    {
      base.EditCompanies();
      Console.WriteLine("(1) - Editar dados");
      Console.WriteLine("(2) - Voltar");
      Console.Write("===========: ");
      var chooser = int.Parse(Console.ReadLine());
      switch (chooser)
      {
        case 1: EditCompanies(); break;
        case 2: Show(); break;
        default:
          Console.WriteLine("Opção digita é inválida. Voltando para o menu principal.");
          Show();
          break;
      }
    }
    protected override void EditEmployees(int chooser, int chooserEditor)
    {
      base.EditEmployees(chooser, chooserEditor);
      System.Console.WriteLine("Edição feita com sucesso!");
      Show();
    }

    protected override void PrintEditEmployees()
    {
      base.PrintEditEmployees();
      var chooser = int.Parse(Console.ReadLine());
      chooser--;

      Console.WriteLine($"Nome: {Employees.ElementAt(chooser).Name}");
      Console.WriteLine($"Número de telefone: {Employees.ElementAt(chooser).PhoneNumber}");
      Console.WriteLine($"Endereço: {Employees.ElementAt(chooser).Address}");
      Console.WriteLine($"CPF: {Employees.ElementAt(chooser).CPF}");
      Console.WriteLine($"Ocupação: {Employees.ElementAt(chooser).Ocuppation}");
      Console.WriteLine($"Turno: {Employees.ElementAt(chooser).Shift}");
      Console.WriteLine($"Salário: {Employees.ElementAt(chooser).Salary}");
      Console.WriteLine($"Faltas: {Employees.ElementAt(chooser).Absences}");
      Console.WriteLine($"Data de admissão: {Employees.ElementAt(chooser).DateAdmission.ToString("dd/MM/yyyy")}");
      Console.WriteLine($"Data de demissão: {Employees.ElementAt(chooser).DateResignation}");


      Console.WriteLine("O que deseja editar?");
      Console.WriteLine("(1) - Nome\n(2) - Número de telefone\n(3) - Endereço\n(4) - CPF\n(5) - Ocupação\n(6) - Turno");
      Console.Write("===========: ");
      var chooserEditor = int.Parse(Console.ReadLine());

      EditEmployees(chooser, chooserEditor);

    }
  }
}