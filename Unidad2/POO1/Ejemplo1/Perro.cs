using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    internal class Perro
    {
        // Perro: nombre, color, origen
        // Atributos o Miembros
        private string nombre;
        private string color;
        private string origen;

        // Propiedad en C#. Esto es del lenguaje. Se usa para hacerder a los atributos privados.
        // Uso de propiedad en C#      
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public string Origen
        {
            get { return origen; }
            set { origen = value; }
        }
    }
}
