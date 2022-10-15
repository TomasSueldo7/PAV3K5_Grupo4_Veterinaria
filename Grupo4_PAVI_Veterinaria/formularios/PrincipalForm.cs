using Grupo4_PAVI_Veterinaria.Datos;
using Grupo4_PAVI_Veterinaria.formularios.abmcDueños;
using Grupo4_PAVI_Veterinaria.formularios.abmcEmpleados;
using Grupo4_PAVI_Veterinaria.formularios.abmcPerros;
using Grupo4_PAVI_Veterinaria.formularios.abmcUsuario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupo4_PAVI_Veterinaria.formularios
{
    public partial class PrincipalForm : Form
    {
        public PrincipalForm(string nombreDeUsuario, string pwd)
        {
            InitializeComponent();
            lblBienvenido.Text = lblBienvenido.Text + " " + nombreDeUsuario;
            DataTable rol = UsuariosBD.ObtenerRol(nombreDeUsuario, pwd);
            if ((rol.Rows[0][3]).ToString().Equals("administrador"))
            {
                reportesToolStripMenuItem.Enabled = false;
                consultasToolStripMenuItem.Enabled = false;
                empleadosToolStripMenuItem1.Enabled = false;
                nuevoToolStripMenuItem.Enabled = false;
            }

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

        private void registrarConsultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaMedica ventana = new ConsultaMedica();
            ventana.ShowDialog();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Usuarios ventana = new Usuarios();
            ventana.ShowDialog();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("App Veterinaria V1.0", "PAVI2022", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lblBienvenido_Click(object sender, EventArgs e)
        {

        }

        private void PrincipalForm_Load(object sender, EventArgs e)
        {

        }

        private void dueñosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dueños ventana = new Dueños();
            ventana.ShowDialog();
        }
    }
}
