using Grupo4_PAVI_Veterinaria.formularios.abmcEmpleados;
using Grupo4_PAVI_Veterinaria.formularios.abmcPerros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupo4_PAVI_Veterinaria.formularios
{
    public partial class PrincipalForm : Form
    {
        public PrincipalForm(string nombreDeUsuario)
        {
            InitializeComponent();
            lblBienvenido.Text = lblBienvenido.Text + " " + nombreDeUsuario;

        }

        private void nuevoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NuevoEmpleado ventana = new NuevoEmpleado();
            ventana.ShowDialog();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Perros ventana = new Perros();
            ventana.ShowDialog();
        }

        private void empleadosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NuevoEmpleado ventana = new NuevoEmpleado();
            ventana.ShowDialog();
        }
    }
}
