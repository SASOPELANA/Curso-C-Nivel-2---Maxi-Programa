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
            /*
            Primer lote con 10 registros de productos, cada producto tiene;
              _ Codigo de Articulo(3 digitos no correlativos)
              _ Precio
              _ Código marca (1 a 10)
            Segundo lote con las ventas de la semana. Cada venta tiene:
              _ Código Articulo.
              _ Cantidad
              _ Código cliente (1 a 100)
            Este lote corta con código de cliente cero.
            */

            // Creamos un vector de 10 articulos.
            Articulo[] articulos = new Articulo[3];

            for (int x= 0; x < 3; x++)
            {
                // Inicializamos cada instancia de Articulo
                articulos[x] = new Articulo();


                Console.WriteLine("Ingrese los datos del producto..");
                Console.Write("Código: ");
                articulos[x].CodigoArticulo = int.Parse(Console.ReadLine());
                Console.Write("Precio: ");
                articulos[x].Precio = float.Parse(Console.ReadLine());
                Console.Write("Marca (1 a 10) ");
                articulos[x].CodigoMarca = int.Parse(Console.ReadLine());
            }

            // Cargando el vector completo con los 10
            Ventas venta = new Ventas();
            Console.WriteLine("\n=== Ingrese la venta === ");
            Console.Write("Código de Cliente o cero (0) para finalizar: ");
            venta.CodigoCliente = int.Parse(Console.ReadLine());

            while (venta.CodigoCliente != 0)
            {
                Console.Write("Código de Artículo: ");
                venta.CodigoArticulo = int.Parse(Console.ReadLine());
                Console.Write("Cantidad: ");
                venta.Cantidad = int.Parse(Console.ReadLine());



                // Pido cliente de nuevo
                Console.WriteLine("=== Ingrese la venta === ");
                Console.Write("Código de Cliente o cero (0) para finalizar: ");
                venta.CodigoCliente = int.Parse(Console.ReadLine());
            }



            Console.ReadKey();
        }
    }
}
