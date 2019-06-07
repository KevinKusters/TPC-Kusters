using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Producto
    {
        public int idProducto { get; set; }
        public string descripcion { get; set; }
        public string marca { get; set; }
        public decimal precio { get; set; }
        public decimal precioVenta { get; set; }
        public int porcentGanancia { get; set; }
        public int stock { get; set; }      
        public bool estado { get; set; }
    }
}