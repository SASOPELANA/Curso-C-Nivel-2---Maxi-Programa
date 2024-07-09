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

            // Crear el objecto persona en C#
            Persona p1 = new Persona("Sergio ");
            p1.setEdad(35);

            // Aqui aplicamos sobrecarga de método saludar.
            Console.WriteLine(p1.saludar());
            Console.WriteLine(p1.saludar("Daniel"));
            Console.WriteLine("La edad de la persona es: " + p1.getEdad());


            Console.WriteLine("\n=================================================================\n");

            // Botella
            Botella b1 = new Botella("Azul", "Plástico");
            // b1.Capacidad = 400;
            // int capa = b1.Capacidad;

            // Botella b2 = new Botella();


            Console.WriteLine("La capacidad de la Botella es: " + b1.Capacidad);
            Console.WriteLine("La cantidad actual: " + b1.CantidadActual);

            b1.recargar(50);
            Console.WriteLine("Luego de recargar, la cantidad actual: " + b1.CantidadActual);

            b1.recargar();
            Console.WriteLine("Luego de recargar, la cantidad actual: " + b1.CantidadActual);


            Console.WriteLine("\n=================================================================\n");

            // Clase Perro
            Perro perro = new Perro();
            perro.Nombre = "Firulai";
            perro.Color = "marrón con negro";
            perro.Origen = "Aleman.";

            // Crear y asignar valores a un vector en C#
            string[] pastor = {perro.Nombre, perro.Color, perro.Origen };

            Console.WriteLine("Nombre del perro " + pastor[0] + ", es de color " + pastor[1] + " y su origen " + pastor[2]);



            Console.ReadKey();
        }
    }
}
