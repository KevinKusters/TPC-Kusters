using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class PersonaJuridica
    {
        public int id { get; set; }
        public string razonSocial { get; set; }
        public Int64 cuit { get; set; }
        public bool estado { get; set; }
    }
}

