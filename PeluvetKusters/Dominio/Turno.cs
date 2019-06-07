using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Dominio
{
    public class Turno
    {

        public int id;
        public bool estado { get; set; }
        public Cliente cliente;
        public Animal animal;
        public Empleado empleado;
        public Servicio servicio;
        public DateTime fecha { get; set; }
        public DateTime hora { get; set; }
    }
}