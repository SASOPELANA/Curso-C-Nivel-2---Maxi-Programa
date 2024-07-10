using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gato g1 = new Gato();
            g1.Nombre = "Felix ";

            Perro p1 = new Perro();
            p1.Nombre = "Manchita";






            // Crear una lista para agregar cualquier objecto. Debe ser de la clase padre --> Class Animal
            
            
            List<Animal> animales = new List<Animal>(); // --> Polimorfismo. Cada animal se comunica a su manera....
            animales.Add(p1);
            animales.Add(g1);
            animales.Add(new Pez()); // Crear y asignar un objecto a la lista, se guarda en el indice de la lista
            animales.Add(new Canario());
            animales.Add(new Tigre());
            animales.Add(new Gato());

            // Creamos una lista de voladores. Con la interfaz Flyable. No se puede crear un objecto con una interfaz
            // Solo se puede agregar animales voladores.
            List<Flyable> listaVoladores = new List<Flyable>();
            listaVoladores.Add(new Canario());
            listaVoladores.Add(new Aguila());
            // listaVoladores.Add(new Perro());    --> No se puede agregar la clase perro, por que no esta diseñado para esto.

            foreach (Flyable item in listaVoladores)
            {
                Console.WriteLine(item.Volar());
            }


            // Iterar la lista
            /*
            foreach (Animal item in animales) // aplicando y mostrar el ruido de cada animal. --> Polimorfismo
            {
                Console.WriteLine(item.Comunicarse());
            }
            */


            /*
            Animal a1 = g1;
            // Gato g8 = a1; // Error al crear un nuevo objecto gato, por que el cimplador no save si a1, es un gato. Forma de forsar --> Gato g8 = (Gato)a1;
            Gato g8 = (Gato)a1;
            Console.WriteLine(g8.Nombre);
            //Console.WriteLine(g1.Comunicarse());
            // Console.WriteLine(p1.Comunicarse());
            */

            Console.ReadKey();
        }
    }
}
