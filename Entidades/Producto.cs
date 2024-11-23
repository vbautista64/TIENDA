using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIENDA.Entidades
{
    public class Producto
    {
        public Int32 IdProducto {  get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public Int32 stock { get; set; }
        public DateTime FechaCreacion { get; set; }

    }
}
