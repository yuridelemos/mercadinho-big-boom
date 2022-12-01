using MercadinhoBigBoom.ContentContext;
using MercadinhoBigBoom.ContentContext.Enum;

namespace MercadinhoBigBoom.Menu
{
  public class MenuTagScreen
  {
    static public void Show()
    {
      Console.WriteLine("Menu Principal");
      Console.WriteLine("(1) - Inscrição de Fornecedor");
      Console.WriteLine("(2) - Inscrição de Funcionário");
      Console.WriteLine("(3) - Visualizar Fornecedores");
      Console.WriteLine("(4) - Visualizar quadro de Funcionários");
      Console.Write("=====================================: ");

      int test = int.Parse(Console.ReadLine());
      switch (test)
      {
        case 1:
            SuplierRegistrationScreen();
        break;
        case 2: EmployeeRegistrationScreen(); break;
        case 3: Console.WriteLine("Teste3"); break;
        case 4: Console.WriteLine("Teste4"); break;
        case 5: Console.WriteLine("Teste5"); break;
        case 6: Console.WriteLine("Teste6"); break;
      }
    }
    private static void SuplierRegistrationScreen()
    {
      Console.WriteLine("Dados da empresa");
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
      Console.WriteLine($"Nome: {company.Name}");
      Console.WriteLine($"Número de telefone: {company.PhoneNumber}");
      Console.WriteLine($"Endereço: {company.Address}");
      Console.WriteLine($"CNPJ: {company.CNPJ}");
      Console.WriteLine($"Ramo: {company.LineBusiness}");
      Console.WriteLine($"Nome do Representante: {company.CompanyRepresentative.Name}");
      Console.WriteLine($"Número de telefone do Representante: {company.CompanyRepresentative.PhoneNumber}");
    }

    private static void EmployeeRegistrationScreen()
    {
      Console.WriteLine("Dados do funcionário");
      Console.Write("Nome: ");
      var Name = Console.ReadLine();
      Console.Write("Número de telefone: ");
      var PhoneNumber = Console.ReadLine();
      Console.Write("Endereço: ");
      var Address = Console.ReadLine();
      Console.Write("CPF: ");
      var CPF = Console.ReadLine();
      Console.Write("Ocupação: ");
      var Ocuppation = int.Parse(Console.ReadLine()); //Enum
      Console.Write("Turno: ");
      var Shift = int.Parse(Console.ReadLine()); //Enum
      Console.Write("Salário: ");
      var Salary = double.Parse(Console.ReadLine());
      Console.Write("Data de admissão: ");
      var DateAdmission = DateTime.Parse(Console.ReadLine());
      //Console.Write("Data de demissão: ");
      //var DateResignation = Console.ReadLine();
      
      var employee = new Employee(Name, PhoneNumber, Address, CPF, 
          (EContentSector)Ocuppation, (EcontentWorkShift)Shift,Salary,DateAdmission);

      Console.WriteLine($"Nome: {employee.Name}");
      Console.WriteLine($"Número de telefone: {employee.PhoneNumber}");
      Console.WriteLine($"Endereço: {employee.Address}");
      Console.WriteLine($"CPF: {employee.CPF}");
      Console.WriteLine($"Ocupação: {employee.Ocuppation}");
      Console.WriteLine($"Turno: {employee.Shift}");
      Console.WriteLine($"Salário: {employee.Salary}");
      Console.WriteLine($"Data de admissão: {employee.DateAdmission.ToString("dd/MM/yyyy")}");
    }
  }
    //Trocar o nível de acesso das funções
}