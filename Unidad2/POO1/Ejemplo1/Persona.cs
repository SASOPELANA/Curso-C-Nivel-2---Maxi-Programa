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
        private int edad;
        private float sueldo;
        private string nombre;

        // METODO EDAD
        public void setEdad(int e)
        {
            edad = e;
        }

        public int getEdad() 
        {
            return edad;
        }

        // METODO SUELDO
        public void setSueldo(float s)
        {
            sueldo = s;
        }

        public float getSueldo()
        {
            return sueldo;
        }

        // METODO NOMBRE
        public void setNombre(string n)
        {
            nombre = n;
        }

        public string getNombre()
        {
            return nombre;
        }
    }
}
