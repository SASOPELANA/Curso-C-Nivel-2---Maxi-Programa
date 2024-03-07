using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Primer lote con 10 registros de productos, cada producto tiene;
            //   _ Codigo de Articulo(3 digitos no correlativos)
            //   _ Precio
            //   _ Código marca (1 a 10)
            // Segundo lote con las ventas de la semana. Cada venta tiene:
            //   _ Código Articulo.
            //   _ Cantidad
            //   _ Código cliente (1 a 100)
            // Este lote corta con código de cliente cero.

            Articulo[] articulos = new Articulo[10];

            for (int x = 0; x < 10; x++)
            {
                articulos[x] = new Articulo();

                Console.WriteLine("Ingrese los datos del producto: ");
                Console.WriteLine("Código: ");
                articulos[x].Codigo_Articulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Precio: ");
                articulos[x].Precio = float.Parse(Console.ReadLine());
                Console.WriteLine("Código de marca (1 a 10): ");
                articulos[x].CodigoMarca = int.Parse(Console.ReadLine());
            }
            // Cargado el vector completo con los 10 

            Ventas venta = new Ventas();
            Console.WriteLine("Ingrese la venta: ");
            Console.WriteLine("Código de cliente: ");
            venta.Codigo_Cliente = int.Parse(Console.ReadLine());

            while (venta.Codigo_Cliente != 0)
            {
                Console.WriteLine("Codigo Articulo: ");
                venta.Codigo_Articulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Cantidad: ");
                venta.Cantidad = int.Parse(Console.ReadLine());

                // Trabajamos....

                // Pido cliente nuevamente.
                Console.WriteLine("Ingrese la venta: ");
                Console.WriteLine("Código de cliente: ");
                venta.Codigo_Cliente = int.Parse(Console.ReadLine());
            }

            Console.ReadKey();
        }
    }
}
