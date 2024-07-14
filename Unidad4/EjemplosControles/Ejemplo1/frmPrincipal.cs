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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        // Navegar en ventana Perfil Persona
        private void perfilPersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Forma de cancelar ventanas no deseadas, sin usar Dialog
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(Form1))
                    // ENTANA ABIERTA
                    return;
            }

            Form1 ventana = new Form1();
            ventana.MdiParent = this;
            ventana.Show(); // --> Dialog solo dejar abrir una ventana, ---> con su timbre clasico
        }

        private void tsbPerfiPersona_Click(object sender, EventArgs e)
        {
            Form1 ventana = new Form1();
            ventana.ShowDialog();
        }
    }
}
