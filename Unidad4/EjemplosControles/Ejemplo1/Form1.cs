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

        // Agremaos elementos en la variable string elem
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string elem = txtNombre.Text;
            lwElementos.Items.Add(elem);
        }

        // AGREGAR LISTA AL --> ComboBox
        private void Form1_Load(object sender, EventArgs e)
        {
            cboColorFavorito.Items.Add("Rojo");
            cboColorFavorito.Items.Add("Azul");
            cboColorFavorito.Items.Add("Verde");
        }

        // Logica para capturar los datos y mostrar perfil.
        private void btnPerfil_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            DateTime fecha = dtpFechaNacimiento.Value; // --> DateTime guarda dato especial de fechas, el Value devuelve un tipo dato ime.
            
            // Operdaor ternario en C#
            string chocolate = ckbChocolate.Checked == true ? "Me gusta el Chocolate.  <3" : "No me gusta el chocolate.  :(";

            // Logica para el GrupBox y RadioButton
            string tipo;
            if (rbtMuggle.Checked)
                tipo = "Muggle";
            else if (rbtWizard.Checked)
                tipo = "Wizard";
            else
                tipo = "Squibs";

            // Logica para el color favorito y numero favorito
            string colorFavorito = cboColorFavorito.SelectedItem.ToString();
            string numeroFavorito = numNumeroFavorito.Value.ToString();

            string mensaje = chocolate + "\nEs " + tipo + ".\nSu color favorito es " + colorFavorito+ "." + "\nSu número favorito " + numeroFavorito+ ".";
            MessageBox.Show("Nombre: " + nombre + ".\nFecha de nacimiento: " + fecha + "\n" + mensaje);

            // Configure message box
            string message = "Hasta luego";
            string caption = "Bye....";
            // Show message box
            MessageBox.Show(message, caption);

        }
    }
}
