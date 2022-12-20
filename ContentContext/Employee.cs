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

    public string CPF { get; internal set; }
    public EContentSector Ocuppation { get; internal set; }
    public EcontentWorkShift Shift { get; internal set; }
    public double Salary { get; internal set; }
    public int Absences { get; internal set; }
    public DateTime DateAdmission { get; internal set; }
    public DateTime? DateResignation { get; internal set; }

    public bool Equals(Employee? other)
    {
      return Name == other.Name || CPF == other.CPF;
    }
  }
}
