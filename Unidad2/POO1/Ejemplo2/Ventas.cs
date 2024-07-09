using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo2
{
    internal class Ventas
    {
        //   _ Código Articulo.
        //   _ Cantidad
        //   _ Código cliente (1 a 100)

        // Creamos metodo propiedad reducido en C#
        public int CodigoArticulo {  get; set; }
        public int Cantidad { get; set; }
        public int CodigoCliente { get; set; }
        
    }
}
