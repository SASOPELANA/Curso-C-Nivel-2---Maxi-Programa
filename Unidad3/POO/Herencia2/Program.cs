using System;
using System.Collections.Generic;
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

            // Se debe aplicar la jerarquias en al clase
            Vehiculo v2 = new Camioneta(); // Esto es valido
            // Camioneta c2 = new Vehiculo(); --> Esto no es valido.

        }
    }
}
