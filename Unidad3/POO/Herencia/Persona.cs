using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Persona
    {
        // abstract internal class Persona --> para que sea astracta la clase, no se puede crear objectos persona. No se puede instanciar esta clase padre

        // sealed internal class Persona --> no permite hacer herencia. Esta sellado.

        // static internal class Persona --> permite haceder durectamente a la clase. No hace falta instanciar o usar el new. Sirve para rutilzar, mostrar pedir.
       

        // Clase padre o principal.
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int legajo { get; set; }

    }
}
