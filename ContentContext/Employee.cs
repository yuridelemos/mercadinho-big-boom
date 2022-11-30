using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MercadinhoBigBoom.ContentContext.Enum;

namespace MercadinhoBigBoom.ContentContext
{
  class Employee : Registration
  {
    public Registration RegistrationData { get; set; }
    public string CPF { get; set; }
    public EContentSector Ocuppation { get; set; }
    public EcontentWorkShift Shift { get; set; }
    public double Salary { get; set; }
    public int Absences { get; set; }
    public DateTime DateAdmission { get; set; }
    public DateTime DateResignation { get; set; }
  }
}
