using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia3
{
    internal class Canario : AnimalDomestico, Flyable
    {
        // Se define el método, o se hace una excepcion
        string Flyable.Volar()
        {
            return "Vuela como un canario...";
        }
    }
}
