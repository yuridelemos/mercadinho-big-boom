namespace MercadinhoBigBoom.Menu
{
  class OwnerMenuScreen : AdmMenuScreen
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
      switch (chooserEditor)
      {
        case 8:
          Console.Write("Salário: ");
          Employees.ElementAt(chooser).Salary = double.Parse(Console.ReadLine());
          break;
        case 9:
          Console.Write("Data de admissão (DD/MM/YYYY): ");
          Employees.ElementAt(chooser).DateAdmission = DateTime.Parse(Console.ReadLine());
          break;
        case 10:
          Console.Write("Data de demissão (DD/MM/YYYY): ");
          Employees.ElementAt(chooser).DateResignation = DateTime.Parse(Console.ReadLine());
          break;
        default:
          if (chooserEditor > 8 && chooserEditor < 0)
            System.Console.WriteLine("Opção digitada é inválida. Por favor tente novamente");
          PrintEditEmployees();
          break;
          Console.WriteLine("Funcionário editado com sucesso!");
      }
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
      Console.WriteLine("(7) - Adicionar falta\n(8) - Salário\n(9) - Data de admissão\n(10) - Data de demissão");
      Console.Write("===========: ");
      var chooserEditor = int.Parse(Console.ReadLine());

      EditEmployees(chooser, chooserEditor);

      //Arrumar um jeito de colocar o PrintEditEmployees do AdmMenuScreens 
      //em ordem para pegar o valor daqui e adicionar o (7) e outros.
    }
  }
}