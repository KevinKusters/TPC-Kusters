using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Venta
    {
        public int idVenta { get; set; }
        public int costo { get; set; }
        public DateTime fecha;
        public bool estado { get; set;}
        Cliente client;
    }
}
