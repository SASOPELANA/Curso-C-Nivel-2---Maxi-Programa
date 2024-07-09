using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    internal class Botella
    {
        // Capacidad Máxima: 100
        // Cantidad Actual: 0
        // Método recarga: carga al 100 y devuelve el costo de recargar. 50 cada 100


        // Crear un constructor en C#
        public Botella(string color, string material)
        {
            this.color = color;
            this.material = material;
            capacidad = 100;
            cantidadActual = 0;
        }

        // Sobrecargar de constructor
        public Botella() { } // --> Constructor vacio

        // Desctructor en C#. No es necesario en .NET por que se ejeucta automaticamente en esta plataforma.
        ~Botella() { } // --> Destructor en C#


        // Botella: Capacidad, Color, Material
        // Atributos
        private int capacidad;         
        private string color;
        private string material;
        private int cantidadActual;

        public int Capacidad
        {
            get { return capacidad; }
        }


        public int CantidadActual
        {
            get { return cantidadActual; }
        }

        public string Material
        {
            get { return material; }
        }


       /*
        // Propiedad
        public int Capacidad
        {
            get { return capacidad; } // Get --> Obtener
            set { capacidad = value; } // Set --> Devolver
        }
       */

        // Métodos
        public float recargar()
        {
            if (cantidadActual > 0)
            {
                int diferencia = capacidad - cantidadActual;
                // 100 50  --> regla de tres simple
                // diferencia --> regla de tres simple
                float monto = diferencia * 50 / 100;
                cantidadActual += diferencia;
                return monto;
            }
            cantidadActual = 100;
            return 50;
        }

        // Sobrecargar el método recargar
        public float recargar(int cantidad)
        {
            cantidadActual += cantidad;
            return cantidad * 50 / 100;
            // 100  50    --> regla de tres simples
            // cantidad =   x?    --> regla de tres simples
        }

    }
}
