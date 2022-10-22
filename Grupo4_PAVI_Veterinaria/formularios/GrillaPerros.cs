using Grupo4_PAVI_Veterinaria.Datos;
using Grupo4_PAVI_Veterinaria.Entidades;
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
    public partial class GrillaPerros : Form
    {
        public GrillaPerros()
        {
            InitializeComponent();
            gdr_perros.DataSource = PerrosBD.ObtenerGrilla();

        }

        private void gdr_perros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            DataGridViewRow fila = gdr_perros.Rows[indice];
            string nro_Hc = fila.Cells["Nro_HC"].Value.ToString();
            Perro p = PerrosBD.ObtenerPerro(nro_Hc);
            ConsultaMedica ventana = new ConsultaMedica(p);
            ventana.ShowDialog();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            gdr_perros.DataSource = PerrosBD.ObtenerPerroXNombre(nombre);


        }

        private void CargarGrilla()
        {
            gdr_perros.DataSource = PerrosBD.ObtenerGrilla();
        }

    }
}
