using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    internal class Persona
    {
        // Persona: Edad, Sueldo, Nombre
        // Atributos o mienbros
        private int edad;
        private float sueldo;
        private string nombre;

        // Constructor Persona para nombre
        public Persona (string nombre)
        {
            this.nombre = nombre;
        }

        // METODO EDAD
        public void setEdad(int e)
        {
            edad = e;
        }

        public int getEdad() 
        {
            return edad;
        }

        // Metodos --> Comportamiento del objecto de persona
        public string saludar() // el metodo debe ser public. Funcion especial 
        {
            return "Hola soy ..." + nombre;
        }

    }
}
