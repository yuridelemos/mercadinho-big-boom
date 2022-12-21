using MercadinhoBigBoom.ContentContext;
using MercadinhoBigBoom.ContentContext.Enum;

namespace MercadinhoBigBoom.Menu
{
  abstract class AdmMenuScreen
  {
    protected static List<Company> Companies = new List<Company>();
    protected static List<Employee> Employees = new List<Employee>();
    public virtual void Show()
    {
      Console.WriteLine("|==================================|");
      Console.WriteLine("|          Menu Principal          |");
      Console.WriteLine("|==================================|");
      Console.WriteLine("(1) - Inscrição de Fornecedor");
      Console.WriteLine("(2) - Inscrição de Funcionário");
      Console.WriteLine("(3) - Visualizar Fornecedores");
      Console.WriteLine("(4) - Visualizar quadro de Funcionários");
      Console.WriteLine("(5) - Editar fornecedor");
      Console.WriteLine("(6) - Editar funcionário");
      Console.Write("=====================================: ");
    }
    protected virtual void SuplierRegistrationScreen()
    {
      Console.Clear();
      Console.WriteLine("|==================================|");
      Console.WriteLine("|    Insira os dados da empresa    |");
      Console.WriteLine("|==================================|");
      Console.Write("Nome: ");
      var Name = Console.ReadLine();
      Console.Write("Número de telefone: ");
      var PhoneNumber = Console.ReadLine();
      Console.Write("Endereço: ");
      var Address = Console.ReadLine();
      Console.Write("CNPJ: ");
      var CNPJ = Console.ReadLine();
      Console.Write("Ramo da empresa: ");
      var LineBusiness = int.Parse(Console.ReadLine());
      Console.Write("Nome do Representante: ");
      var CompanyRepresentativeName = Console.ReadLine();
      Console.Write("Número de telefone do Representante: ");
      var CompanyRepresentativePhoneNumber = Console.ReadLine();

      var companyRepresentative = new Representative(CompanyRepresentativeName, CompanyRepresentativePhoneNumber);
      var company = new Company(Name, PhoneNumber, Address, CNPJ, (EContentBranch)LineBusiness, companyRepresentative);

      if (Companies.Count != 0)
        foreach (var itens in Companies.ToList())
        {
          if (itens.Equals(company))
          {
            Console.WriteLine("Fornecedor já possui cadastrado");
            Thread.Sleep(1000);
            SuplierRegistrationScreen();
          }
        }
      Companies.Add(company);

      Thread.Sleep(2000);
      Console.Clear();

      Console.WriteLine("|=================================|");
      Console.WriteLine("|Fornecedor cadastrado com sucesso|");
      Console.WriteLine("|=================================|");

      Console.WriteLine("(1) - Cadastrar nova empresa");
      Console.WriteLine("(2) - Voltar para o menu");
      var chooser = int.Parse(Console.ReadLine());

      switch (chooser)
      {
        case 1: SuplierRegistrationScreen(); break;
        case 2: Show(); break;
        default: //implementar algo para refazer a opção
          break;
      }
      Show();

      // Console.WriteLine($"Nome: {company.Name}");
      // Console.WriteLine($"Número de telefone: {company.PhoneNumber}");
      // Console.WriteLine($"Endereço: {company.Address}");
      // Console.WriteLine($"CNPJ: {company.CNPJ}");
      // Console.WriteLine($"Ramo: {company.LineBusiness}");
      // Console.WriteLine($"Nome do Representante: {company.CompanyRepresentative.Name}");
      // Console.WriteLine($"Número de telefone do Representante: {company.CompanyRepresentative.PhoneNumber}");
      // Thread.Sleep(2000);
      // //Console.Clear();

      // Thread.Sleep(2000);
    }

    protected virtual void EmployeeRegistrationScreen()
    {
      Console.Clear();
      Console.WriteLine("|=================================|");
      Console.WriteLine("|  Insira os dados do funcionário |");
      Console.WriteLine("|=================================|");
      Console.Write("Nome: ");
      var Name = Console.ReadLine();
      Console.Write("Número de telefone: ");
      var PhoneNumber = Console.ReadLine();
      Console.Write("Endereço: ");
      var Address = Console.ReadLine();
      Console.Write("Senha: ");
      var Password = Console.ReadLine();
      Console.Write("CPF: ");
      var CPF = Console.ReadLine();
      Console.Write("Ocupação: ");
      var Ocuppation = int.Parse(Console.ReadLine()); //Enum
      Console.Write("Turno: ");
      var Shift = int.Parse(Console.ReadLine()); //Enum
      Console.Write("Salário: ");
      var Salary = double.Parse(Console.ReadLine());
      Console.Write("Data de admissão (DD/MM/YYYY): ");
      var DateAdmission = DateTime.Parse(Console.ReadLine());

      var employee = new Employee(Name, PhoneNumber, Address, Password, CPF,
          (EContentSector)Ocuppation, (EcontentWorkShift)Shift, Salary, DateAdmission);

      if (Employees.Count != 0)
        foreach (var itens in Employees.ToList())
        {
          if (itens.Equals(employee))
          {
            Console.WriteLine("Funcionário já possui cadastrado");
            Thread.Sleep(1000);
            EmployeeRegistrationScreen();
          }
        }
      Employees.Add(employee);
      Thread.Sleep(2000);
      Console.Clear();
      Console.WriteLine("|==================================|");
      Console.WriteLine("|Funcionário cadastrado com sucesso|");
      Console.WriteLine("|==================================|");

      Console.WriteLine("(1) - Cadastrar novo funcionário");
      Console.WriteLine("(2) - Voltar para o menu");
      var chooser = int.Parse(Console.ReadLine());

      switch (chooser)
      {
        case 1: EmployeeRegistrationScreen(); break;
        case 2: Show(); break;
        default: //implementar algo para refazer a opção
          break;
      }
      Show();
    }
    protected virtual void ReadListCompanies()
    {
      var contador = 1;
      foreach (var company in Companies)
      {
        Console.WriteLine($"{contador++} Nome: {company.Name} CPF: {company.CNPJ}");
      }
      Console.WriteLine("(1) - Editar dados");
      Console.WriteLine("(2) - Voltar");
      Console.Write("===========: ");
      int test = int.Parse(Console.ReadLine());
      switch (test)
      {
        case 1: EditCompanies(); break;
        case 2: Show(); break;
        default:
          Console.WriteLine("Opção digita é inválida. Voltando para o menu principal.");
          Show();
          break;
      }
      Show();
    }

    protected virtual void ReadListEmployees()
    {
      var contador = 1;
      foreach (var employee in Employees)
      {
        Console.WriteLine($"{contador++} Nome: {employee.Name} CPF: {employee.CPF}");
      }
    }

    protected virtual void EditCompanies()
    {
      Console.WriteLine("Digite o número da empresa");
      Console.Write("===========: ");
      var chooser = int.Parse(Console.ReadLine());
      chooser--;
      Console.WriteLine($"Nome: {Companies.ElementAt(chooser).Name}");
      Console.WriteLine($"Número de telefone: {Companies.ElementAt(chooser).PhoneNumber}");
      Console.WriteLine($"Endereço: {Companies.ElementAt(chooser).Address}");
      Console.WriteLine($"CNPJ: {Companies.ElementAt(chooser).CNPJ}");
      Console.WriteLine($"Ramo: {Companies.ElementAt(chooser).LineBusiness}");
      Console.WriteLine($"Nome do Representante: {Companies.ElementAt(chooser).CompanyRepresentative.Name}");
      Console.WriteLine($"Número de telefone do Representante: {Companies.ElementAt(chooser).CompanyRepresentative.PhoneNumber}");

      Console.WriteLine("O que deseja editar?");
      Console.WriteLine("(1) - Nome\n(2) - Número de telefone\n(3) - Endereço\n(4) - CNPJ\n(5) - Ramo\n(6) - Nome do Representante\n(7) - Número de telefone do Representante");
      Console.Write("===========: ");
      var chooserEdit = int.Parse(Console.ReadLine());

      switch (chooserEdit)
      {
        case 1:
          Console.Write("Nome: ");
          Companies.ElementAt(chooser).Name = Console.ReadLine();
          break;
        case 2:
          Console.Write("Número de Telefone: ");
          Companies.ElementAt(chooser).PhoneNumber = Console.ReadLine();
          break;
        case 3:
          Console.Write("Endereço: ");
          Companies.ElementAt(chooser).Address = Console.ReadLine();
          break;
        case 4:
          Console.Write("CNPJ: ");
          Companies.ElementAt(chooser).CNPJ = Console.ReadLine();
          break;
        case 5:
          Console.Write("Ramo: ");
          var ramo = int.Parse(Console.ReadLine());
          Companies.ElementAt(chooser).LineBusiness = (EContentBranch)ramo;
          break;
        case 6:
          Console.Write("Nome do Representante: ");
          Companies.ElementAt(chooser).CompanyRepresentative.Name = Console.ReadLine();
          break;
        case 7:
          Console.Write("Número de telefone do Representante: ");
          Companies.ElementAt(chooser).CompanyRepresentative.PhoneNumber = Console.ReadLine();
          break;
      }
    }

    protected virtual void EditEmployees(int chooser, int chooserEditor)
    {
      switch (chooserEditor)
      {
        case 1:
          Console.Write("Nome: ");
          Employees.ElementAt(chooser).Name = Console.ReadLine();
          break;
        case 2:
          Console.Write("Número de Telefone: ");
          Employees.ElementAt(chooser).PhoneNumber = Console.ReadLine();
          break;
        case 3:
          Console.Write("Endereço: ");
          Employees.ElementAt(chooser).Address = Console.ReadLine();
          break;
        case 4:
          Console.Write("CPF: ");
          Employees.ElementAt(chooser).CPF = Console.ReadLine();
          break;
        case 5:
          Console.Write("Cargo: ");
          var ocuppation = int.Parse(Console.ReadLine());
          Employees.ElementAt(chooser).Ocuppation = (EContentSector)ocuppation;
          break;
        case 6:
          Console.Write("Turno: ");
          var shift = int.Parse(Console.ReadLine());
          Employees.ElementAt(chooser).Shift = (EcontentWorkShift)shift;
          break;
        case 7:
          Employees.ElementAt(chooser).Absences++;
          break;
      }
      if(chooserEditor > 0 && chooserEditor < 8)
        System.Console.WriteLine("Edição feita com sucesso!");
      Thread.Sleep(2000);
      Console.Clear();
    }
    protected virtual void PrintEditEmployees()
    {
      ReadListEmployees();
      Console.WriteLine("Digite o número do funcionário");
      Console.Write("===========: ");

    }
  }
}