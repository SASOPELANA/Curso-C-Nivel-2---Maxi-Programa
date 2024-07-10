using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia3
{
    internal class Gato : AnimalDomestico
    {
        // Sobre escribir un metodo -> que tiene virtual
        public override string Comunicarse()
        {
            return "Miau ... Miau...";
        }



    }
}
