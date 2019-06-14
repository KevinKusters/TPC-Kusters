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
        public bool  realizado { get; set; }
        public Cliente cliente;
        public Animal animal;
        public Empleado empleado;
        public Servicio servicio;
        public string fecha { get; set; }
        public string hora { get; set; }
        

        public string NombreCliente { get { return cliente.nombre; } }
        public string ApellidoCliente { get { return cliente.apellido; } }
        public string NombreMascota { get { return animal.nombre; } }
        public string Raza { get { return animal.raza.nombre; } }
        public string Especie { get { return animal.especie; } }
        public string NombreEmpleado { get { return empleado.nombre; } }
        public string ApellidoEmpleado { get { return empleado.apellido; } }
        public string Servicio { get { return servicio.descripcion; } }
        public decimal Precio { get { return servicio.precio; } }
    }
}