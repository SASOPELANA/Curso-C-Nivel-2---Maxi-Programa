using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    internal class Persona
    {
        // Atributos o mienbros
        // Persona: Edad, Sueldo, Nombre
        private int edad;
        private float sueldo;
        private string nombre;

        // Metodo edad
        public void setEdad(int e)
        {
            edad = e;
        }

        // Get obtener
        public int getEdad() 
        {
            return edad;
        }
            
         
    }
}
