using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia2
{
    internal class Auto : Vehiculo
    {
        public Auto() 
        {
            Chasis = new Chasis(); // Solo get por que no se debe modificar.
        }


        private string Anio {  get; set; }
        private string Modelo { get; set; }
        private string Color {  get; set; }

        // Composicion --> Asociacion.
        public Chasis Chasis { get; } // Solo debe tener get, por que es la composicion del mismo, no se debe modificar. Nace con un chasis



        // Agregacion. --> Cuando el objecto se le agrega el metodo. No nace con motor se le agrega.
        public Motor Motor { get; set; } // Por que se le agrega el motor.


    }
}
