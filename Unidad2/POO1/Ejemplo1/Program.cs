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

            /**
            Persona p1 = new Persona("Ricardo o Pepe"); //crea una clase persona
            p1.setEdad(30);
            Console.WriteLine(p1.saludar());
            Console.WriteLine("La edad de la persona es: " + p1.getEdad()); // llama a la funcion y ala clase persona p1
          
            Console.WriteLine(" ");
            */

            // Botellla
            // Atributos 
            Botella b1 = new Botella("Rojo", "Plastico");
            // b1.Capacidad = 500;   // con get y set en la funcion o metodo permite asginar el valor como variable
            // int algo = b1.Capacidad; // Se puede asignar a una variable para leer

            // Botella b2 = new Botella(); // Se invoco al desctrutor vacio, sin parametros.

            Console.WriteLine("Capacidad Botella " + b1.Capacidad);
            Console.WriteLine("La cantidad actual es: " + b1.Capacidad_actual);

            b1.recargar();
            Console.WriteLine("Luego de recarga, la cantidad actual es: " + b1.Capacidad_actual);
            // Console.WriteLine("La botella tiene la capacidad de: " + algo);



            Console.WriteLine(" ");

            /**
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
            */

            Console.ReadKey();
        }
    }
}
