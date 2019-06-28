using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Usuario
    {
        public int id { get; set;}
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }
        public bool Admin { get; set; }
        public bool estado { get; set; }
    }
}
