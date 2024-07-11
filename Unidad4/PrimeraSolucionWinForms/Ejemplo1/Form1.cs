using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Carga una ventana previa, antes de ejecutar la App.
        private void Form1_Load(object sender, EventArgs e)
        {
           // MessageBox.Show("Te Saludo");
        }

        // Método especial para ejecutar el button. Evento por estandar
        private void button1_Click(object sender, EventArgs e)
        {
            // METODO PARA INVOCAR UNA UN BOTON. ACCION DE EVENTOS CLICK BUTTON
            // MessageBox.Show("Hola Mundo"); // CREA UNA VENTANA 

            // Capturamos el nombre en la variable tipo string  texto
            string texto = txtNombre.Text;
            lblSaludo.Text = "Hola " + texto;

        }

        // Dando click a un evento se crea una funcion en el archvio Form1.cs
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
           // MessageBox.Show("Hasta Luego...");
        }

    }
}
