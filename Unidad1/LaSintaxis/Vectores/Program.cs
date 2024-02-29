using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10];

            numeros[0] = 10;
            numeros[5] = 7;
            int j = numeros[5];
            int d = numeros[0];

            Console.WriteLine(j + " " + d);

            Console.ReadKey();

        }
    }
}
