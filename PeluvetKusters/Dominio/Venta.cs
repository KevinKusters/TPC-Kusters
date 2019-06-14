using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Venta
    {
        public int IdVenta { get; set; }
        public decimal Costo { get; set; }        
        public decimal PrecioVenta { get; set; }
        public int cantidad { get; set; }
        public DateTime Fecha;
        public bool estado { get; set;}        
        public Producto producto;

        public string Producto { get { return producto.descripcion; } }
        public DateTime FechaVenta { get { return Fecha; } }
    }
}
