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

        // private int codigo_articulo;
        public int Codigo_Articulo { get; set; }

        // private float precio;
        public float Precio { get; set; }

        private int codigo_marca;

        public int CodigoMarca
        {
            get { return codigo_marca; }
            set
            {
                if (value > 0 && value < 11)
                    codigo_marca = value;
                else
                    codigo_marca = -1;
            }
        }


    }
}
