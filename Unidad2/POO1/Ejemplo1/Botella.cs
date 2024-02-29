using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    internal class Botella
    {
        // Botella: Capacidad, Color, Material

        private int capacidad;
        private string color;
        private string material;

        // PROPIEDAD
        public int Capacidad // esta funcion o metodo permite asignar un valor, como una variable
        { 
            get { return capacidad; } // get significa obtener
            set { capacidad = value; } // set significa establecer o configurar
        }

        // Metodo Color
        public void setColor(string azul)
        {
            color = azul;
        }

        public string getColor()
        {
            return color;
        }

        // Metodo material
        public void setMaterial(string mate)
        {
            material = mate;
        }

        public string getMaterial() 
        {
            return material;
        }
    }
}
