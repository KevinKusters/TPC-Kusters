using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Cliente : Persona
    {
        public int id;
        public string contacto { get; set; }
        public bool estado { get; set; }
        public Localidad localidad;
        public Animal animal;

        public string Localidad { get { return localidad.nombre; } }
    }
}
