using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    internal class Botella
    {
        // Capacidad maxima 100
        // Cantidad actual: inicia en cero
        // Método recarga: carga el 100 y devuelve el costo de recargar. 50 cada 100.


        // Contructor, puede tener el mismo nombre de la clase. Botella
        public Botella (string color, string material) // No se puede escribir desde el exterior. Se accede con otras herramientas.
        {
            this.color = color;         // this.    sirve para indicar a la Clase, mi objecto
            this.material = material;
            capacidad = 100;
            cantidad_actual = 0;
        }

        // Sobrecargar el constructor

        public Botella () { }  // Contructor vacio, sin parametros, sin logica.

        // Destructor
        ~Botella ()
        {
            // Logica.....
        }

        // Botella: Capacidad, Color, Material
        private int capacidad;
        private string color;
        private string material;
        private int cantidad_actual;

        public int Capacidad //Funcion
        {
            get { return capacidad; }   // get   devuelve con este metodo
        }

        public int Capacidad_actual // Funcion 
        {
            get { return cantidad_actual; }
        }


        public string Material
        {
            get { return material; }
        }


        // PROPIEDAD
        // public int Capacidad // esta funcion o metodo permite asignar un valor, como una variable
        // { 
        //     get { return capacidad; } // get significa obtener
        //     set { capacidad = value; } // set significa establecer o configurar
        // }

        // Métodos
        public float recargar()
        {
            if (cantidad_actual > 0)
            {
                int diferencia = capacidad - cantidad_actual;
                // 100  50
                // diferencia
                float monto = diferencia * 50 / 100;
                cantidad_actual += diferencia;
                return monto;
            }
            cantidad_actual = 100;
            return 50;
        }

    }
}
