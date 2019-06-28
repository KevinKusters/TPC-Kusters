using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Empleado : Persona
    {
        public int id { get; set; }
        public string contacto { get; set; }        
        public bool estado { get; set; }
        public string rubro { get; set; }
        public Puesto puesto;

        public string Puesto { get { return puesto.Descripcion; }}
    }
}
