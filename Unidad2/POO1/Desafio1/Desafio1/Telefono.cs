/*
   1. Crear un proyecto de consola .Net Framework.
   2. Crear la clase Telefono (recordemos que una clase va en un archivo nuevo; click derecho en el proyecto, agregar, class).
   3. Agregale los siguientes atributos:
      _ Modelo string.
      _ Marca string.
      _ NumeroTelefonico string.
      _ CodigoOperador int (1, 2 o 3).
   4. Agregale las propiedades correspondientes. Podés hacer el formato largo o el corto.
      _ Modelo: solo lectura. Es decir, solo get.
      _ Marca: solo lectura.
      _ NumeroTelefonico: lectura y escritura.
      _ CodigoOperador: lectura y escritura. Validar escritura que solo admita 1, 2 o 3, caso contrario escribir un cero.
   5. Agregar Constructor que reciba Modelo y Marca.
   6. Crear algunos objetos en el main de Program y probar escribirle datos y mostrar en pantalla el estado del Telefono.
   7. Agregar método Llamar() sin parámetros que devuelva un string con la leyenda "Realizando llamada...".
   8. Sobrecargar el método Llamar(string contacto) para que reciba un contacto y devuelva un string con la leyenda "Llamando a " + contacto
   9. Probar métodos en el main mostrando en pantalla el comportamiento de los objetos.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1
{
    internal class Telefono
    {
        private string modelo;
        private string marca;
        private string numeroTelefonico;
        private int codigoOperador;


        // Contructor Clase Telofono. Recibe dos valores string por valor.
        public Telefono(string modelo, string marca) 
        {
            this.modelo = modelo;
            this.marca = marca;
        }


        // Propiedad
        public string Modelo
        {
            get { return modelo; }
        }

        public string Marca
        {
            get { return marca; }
        }
        public string NumeroTelefonico
        {
            get { return numeroTelefonico; }
            set { numeroTelefonico = value; }
        }

        public int CodigoOperador
        {
            get { return codigoOperador; }
            set
            {
                if (value > 0 && value < 4)
                    codigoOperador = value;
                else
                    codigoOperador = 0;  
            }
        }

        
        // Metodo Llamar()
        public string Llamar()
        {
            return "Realizando llamada...";
        }

        // Sobrecarga de método llamar
        public string Llamar(string contacto)
        {
            return "Llamando a " + contacto;
        }

    }
}
