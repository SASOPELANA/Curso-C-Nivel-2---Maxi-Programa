using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Persona > Lider > Developer > Tester
            Persona p1 = new Persona();
           
            Developer dev = new Developer();

            // Console.WriteLine(); --> Console es una clase statica. No nesecita ser creada. No abusar de esto por que se ejecuta en memoria.
            
        }
    }
}
