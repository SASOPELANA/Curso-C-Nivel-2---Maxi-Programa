using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creramos el objeto telefono1
            Telefono telefono1 = new Telefono("30SE", "TCL");
            Console.WriteLine("La marca del celualr o smartphones: " + telefono1.Marca);
            Console.WriteLine("Modelo del celualar o smartphones: " + telefono1.Modelo);
            Console.Write("Ingrese el número de celular: ");
            telefono1.NumeroTelefonico = Console.ReadLine();
            Console.WriteLine("El número de celular es: " + telefono1.NumeroTelefonico);
            Console.Write("Ingrese el código de operador (1, 2 o 3): ");
            telefono1.CodigoOperador = int.Parse(Console.ReadLine());
            Console.WriteLine("El código de operador: " + telefono1.CodigoOperador);

            Console.WriteLine(telefono1.Llamar());
            Console.WriteLine("Presione Enter para continuar...");
            Console.ReadLine();
            Console.WriteLine(telefono1.Llamar("Sergio"));

            Console.ReadKey();
        }
    }
}
