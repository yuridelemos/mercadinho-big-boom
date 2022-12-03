using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MercadinhoBigBoom.SharedContext;

namespace MercadinhoBigBoom.ContentContext
{
  public class Registration : Base
  {
    public string Name { get; set; }// Começo
    public string PhoneNumber { get; set; } // dos dados
    public string Address { get; set; } // Para cadastro 
  }
}
