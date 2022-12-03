using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MercadinhoBigBoom.ContentContext.Enum;


namespace MercadinhoBigBoom.ContentContext
{
    class Providers
    {
        public Providers()
        {
            Companies = new List<Company>();
        }
        public List<Company> Companies { get; set; }
    }
}
