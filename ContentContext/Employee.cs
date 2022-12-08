using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MercadinhoBigBoom.ContentContext.Enum;

namespace MercadinhoBigBoom.ContentContext
{
  public class Employee : Registration, IEquatable<Employee>
  {
    public Employee(string name, string phoneNumber, string address, string password, string cPF, EContentSector ocuppation,
     EcontentWorkShift shift, double salary, DateTime dateAdmission)
    {
      Name = name;
      PhoneNumber = phoneNumber;
      Address = address;
      Password = password;
      CPF = cPF;
      Ocuppation = ocuppation;
      Shift = shift;
      Salary = salary;
      Absences = 0;
      DateAdmission = dateAdmission;
      DateResignation = null;
    }

    public string CPF { get; private set; }
    public EContentSector Ocuppation { get; private set; }
    public EcontentWorkShift Shift { get; private set; }
    public double Salary { get; private set; }
    public int Absences { get; private set; }
    public DateTime DateAdmission { get; private set; }
    public DateTime? DateResignation { get; private set; }

    public bool Equals(Employee? other)
    {
      return Name == other.Name || CPF == other.CPF;
    }
  }
}
