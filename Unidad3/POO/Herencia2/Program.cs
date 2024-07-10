using System;
using System.Collections.Generic; // --> Esta libreria es para coleccion
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Vehiculo > Auto > AutoDeportivo > AutoUrbano
            // >Camioneta
            // >Moto

            Vehiculo v1 = new Vehiculo();
            Camioneta c1 = new Camioneta();
            Camioneta c2 = new Camioneta();
            Camioneta c3 = new Camioneta();
            c1.Color = "Amarillo";
            c2.Color = "Roja";
            c3.Color = "Gris";

            // Se debe aplicar la jerarquias en al clase
            //Vehiculo v2 = new Camioneta(); // Esto es valido
            // Camioneta c2 = new Vehiculo(); --> Esto no es valido.

            // Crear una Coleccion en C#. La lista es un objecto fuertemente tipado. No se define el tamaño.
            List<Camioneta> listaCamioneta = new List<Camioneta>(); // --> Una lista de camioneta. No es lo mismo que un objecto
            listaCamioneta.Add(c1); // Es como un vector. Usamos la funcion -->    Add()
            listaCamioneta.Add(c2);
            listaCamioneta.Add(c3);

            /*
            // Forma de mostrar la lista. Usamos Count para contar la cantidad que almacena cierta lista.
            Console.WriteLine("La cantidad de camionetas es: " + listaCamioneta.Count); // Usamos Count para leer la lista
            Console.WriteLine("El color es: " + listaCamioneta[1].Color); // Podemos acceder a un elemento en particluar como un vector.

            //listaCamioneta[1].Color = "Azul"; // Se cambia el valor de la lista
            c2.Color = "Verde";
            Console.WriteLine("El color es: " + listaCamioneta[1].Color);

            // Remover una lista. funcion --> Remove()
            listaCamioneta.Remove(c2);
            Console.WriteLine("La cantidad de camionetas es: " + listaCamioneta.Count); // Usamos Count para leer la lista
            */

            // Recorrer una lista de camioneta. forech --> Para iterar un coleccion 

            foreach (Camioneta item in listaCamioneta)
            {
                Console.WriteLine(item.Color);
            }




            Console.ReadKey();
        }
    }
}
