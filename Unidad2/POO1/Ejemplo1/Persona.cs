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

        // Constructor para la clase Persona
        public Persona(string nombre)
        {
            this.nombre = nombre;
        }


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
            
        // Metodos en C#
        public string saludar()
        {
            return "Hola soy " + nombre;
        }

        // Sobrecargar el Método saludar
        public string saludar(string personaje)
        {
            return "Hola " + personaje + ", soy ..." + nombre;
        }
         
    }
}
