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
        case 6: EditEmployees(); break;
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
    }
    protected override void PrintEditEmployees(int chooser)
    {
      base.PrintEditEmployees(chooser);
    }
    protected override void EditEmployees()
    {
      base.EditCompanies();
      var chooser = int.Parse(Console.ReadLine());
      chooser--;
      PrintEditEmployees(chooser);
      Console.WriteLine("\n(7) - Salário\n(8) - Adicionar falta\n(9) - Data de admissão\n(10) - Data de demissão");
      Console.Write("===========: ");

      //Arrumar um jeito de colocar o PrintEditEmployees do AdmMenuScreens 
      //em ordem para pegar o valor daqui e adicionar o (7) e outros.
    }
  }
}