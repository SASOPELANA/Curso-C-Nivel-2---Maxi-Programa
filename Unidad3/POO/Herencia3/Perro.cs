using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia3
{
    internal class Perro : AnimalDomestico
    {
        public override string Comunicarse() // --> override para sobreescribir. Pero se debe poner el virtual en el metodo que esta en la clase padre
        {
            return "Gua ... Gua....";
        }

    }
}
