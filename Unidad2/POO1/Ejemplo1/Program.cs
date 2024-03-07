using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Persona: Edad, Sueldo, Nombre
            // Atributos o Miembros

            Persona p1 = new Persona(); //crea una clase persona
            p1.setEdad(30);
            Console.WriteLine("La edad de la persona es: " + p1.getEdad()); // llama a la funcion y ala clase persona p1

            p1.setSueldo(520000);
            Console.WriteLine("El sueldo de la persona es: $" + p1.getSueldo());

            p1.setNombre("Sergio Alejandro Sopelana");
            Console.WriteLine("El monbre de la persona es: " + p1.getNombre());

            Console.WriteLine(" ");

            // Botellla
            // Atributos 
            Botella b1 = new Botella();
            b1.Capacidad = 500;   // con get y set en la funcion o metodo permite asginar el valor como variable
            int algo = b1.Capacidad; // Se puede asignar a una variable para leer
            Console.WriteLine("La botella tiene la capacidad de: " + algo);

            b1.setColor("Blue.");
            Console.WriteLine("El color de la Botella es: " + b1.getColor());

            b1.setMaterial("Vidrio.");
            Console.WriteLine("El material de la botella es: " + b1.getMaterial());

            Console.WriteLine(" ");

            // Perro 
            // Atributos 
            Perro perro1 = new Perro();
            perro1.Nombre = "Chad";
            string dog = perro1.Nombre;
            Console.WriteLine("El nombre del perro es: " +  dog);

            perro1.Color = "Marron y Negro.";
            string clasico1 = perro1.Color;
            Console.WriteLine("El color del perro es: " +  clasico1);

            perro1.Origen = "Pastor Aleman.";
            string pastor = perro1.Origen;
            Console.WriteLine("El origen del perro es: " + pastor);

            Console.ReadKey();
        }
    }
}
