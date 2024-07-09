using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    internal class Botella
    {
        // Botella: Capacidad, Color, Material
        // Atributos
        private int capacidad;         
        private string color;
        private string material;

        // Uso de Propiedad en C#. Esto es del lenguaje, esto propone C#.
        public int Capacidad
        {
            get { return capacidad; } // Get --> Obtener
            set { capacidad = value; } // Set --> Devolver
        }

    }
}
