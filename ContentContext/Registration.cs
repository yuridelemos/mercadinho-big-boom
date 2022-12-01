using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MercadinhoBigBoom.SharedContext;

namespace MercadinhoBigBoom.ContentContext
{
  abstract class Registration : Base
  {
    public string Name { get; private set; }// Começo
    public string PhoneNumber { get; private set; } // dos dados
    public string Address { get; private set; } // Para cadastro 
  }
}
