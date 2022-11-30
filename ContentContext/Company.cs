using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MercadinhoBigBoom.ContentContext;
using MercadinhoBigBoom.ContentContext.Enum;

namespace MercadinhoBigBoom.ContentContext
{
  class Company : Registration
  {
    public Company(string name, string phoneNumber, string address, 
        string cnpj, EContentBranch lineBusiness, Representative companyRepresentative)
    {
      Name = name;
      PhoneNumber = phoneNumber;
      Address = address;
      CNPJ = cnpj;
      LineBusiness = lineBusiness;
      CompanyRepresentative = companyRepresentative;
    }

    public string CNPJ { get; set; }
    public EContentBranch LineBusiness { get; set; }
    public Representative CompanyRepresentative { get; set; }
  }
}
