using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo2
{
    internal class Articulo
    {
        //  _ Codigo de Articulo(3 digitos no correlativos)
        //  _ Precio
        //  _ Código marca (1 a 10)
        // private int codigArticulo;
        
        // Forma reducida de armar la Propiedad en C#.
        public int CodigoArticulo { get; set; } // --> Metodo propiedad en C# reducido. Pero no de puede manipular el ger y el set con este metodo.

        // private floar precio
        public float Precio { get; set; }

        private int codiMarca;

        // En metodo propiedad sin resumir, puedo manipular el get y set.
        public int CodigoMarca
        {
            get { return codiMarca; }
            set
            {
                if (value > 0 && value < 11)
                    codiMarca = value;
                else
                    codiMarca = -1;
            }
        }

    }
}
