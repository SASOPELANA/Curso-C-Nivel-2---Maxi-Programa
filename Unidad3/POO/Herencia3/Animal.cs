using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia3
{
    internal class Animal
    {
        // virtual sirve para sobreescribir un metodo.
        public virtual string Comunicarse()
        {
            return "ruido .... ruido...";
        }

    }
}
