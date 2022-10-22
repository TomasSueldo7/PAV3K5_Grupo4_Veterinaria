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

namespace Grupo4_PAVI_Veterinaria
{
    public partial class ConsultaMedica : Form
    {
        public ConsultaMedica(Perro p)
        {
            InitializeComponent();
            RellenarPerro(p);
            string nroHc = txtNroHC.Text;
            txtNroConsulta.Text = ConsultaMedicaBD.UltimaConsultaXNroHC(nroHc);
            CargarCombosMedicamentos();
            CargarCombosSintomas(); 
                
            
        }


        private void RellenarPerro(Perro p)
        {
            txtNombre.Text = p.Nombre;
            txtNroHC.Text = p.Nro_HC.ToString();
            txtFechaNacimiento.Text = p.FechaNacimiento.ToString();
            txtAltura.Text = p.Altura.ToString();
            txtPeso.Text = p.Peso.ToString();
            Dueño d = DueñosBD.ObtenerDueñoXId(p.Id_dueño.ToString());
            txtRaza.Text = PerrosBD.ObtenerRazasXId(p.Id_raza.ToString());
            txtDueño.Text = d.NombreDueño.ToString() + " " + d.ApellidoDueño.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
        private void LimpiarCampos() { 
        
            grdMedicamentos.Rows.Clear();
            gdrSintomas.Rows.Clear();
            cmbMedicamentos.SelectedIndex = -1;
            cmbSintomas.SelectedIndex = -1;
        }

        private void Volver()
        {
            this.Close();
        }
        private void btnBuscarMedicamentos_Click(object sender, EventArgs e)
        {
            if (txtMedicamento.Text.Equals(""))
            {
                MessageBox.Show("Ingrese un nombre de medicamento");
            }
            else
            {
                string filtro = txtMedicamento.Text.Trim();
                cmbMedicamentos.DataSource = Comunes.ObtenerMedicamentosXNombre(filtro);
                cmbMedicamentos.DisplayMember = "Nombre";
                cmbMedicamentos.ValueMember = "Id_medicamento";
                cmbMedicamentos.SelectedIndex = -1;
            }
        }

        private void btnBuscarSintomas_Click(object sender, EventArgs e)
        {
            if (txtMedicamento.Text.Equals(""))
            {
                MessageBox.Show("Ingrese un nombre de sintoma");
            }
            else
            {
                string filtro = txtSintoma.Text.Trim();
                cmbSintomas.DataSource = Comunes.ObtenerSintomasXNombre(filtro);
                cmbSintomas.DisplayMember = "Descripcion";
                cmbSintomas.ValueMember = "Id_sintoma";
                cmbSintomas.SelectedIndex = -1;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(txtLegajo.Equals("") || grdMedicamentos.Rows.Count == 0 || gdrSintomas.Rows.Count == 0)
            {
                MessageBox.Show("Algunos campos se encuentran vacios, por favor verifique.");
                return;
            }
            
            List<int> listaMedicamentos = new List<int>();
            for (int i = 0; i < grdMedicamentos.Rows.Count; i++)
            {
                listaMedicamentos.Add(int.Parse(grdMedicamentos.Rows[i].Cells[0].Value.ToString()));
            }

            List<int> listaSintomas = new List<int>();
            for (int i = 0; i < gdrSintomas.Rows.Count; i++)
            {
                listaSintomas.Add(int.Parse(gdrSintomas.Rows[i].Cells[0].Value.ToString()));
            }

            bool resultado = ConsultaMedicaBD.AltaNuevaConsulta(int.Parse(txtNroHC.Text.Trim()), int.Parse(txtNroConsulta.Text.Trim()), int.Parse(txtLegajo.Text.Trim()), listaMedicamentos,listaSintomas);
            if (resultado)
            {
                MessageBox.Show("Consulta dada de alta.");
                LimpiarCampos();
               
            }
            else
            {
                MessageBox.Show("Error al dar alta nuevo consulta.");
            }
        }

        private void CargarCombosMedicamentos()
        {
            cmbMedicamentos.DataSource = Comunes.ObtenerMedicamentos();
            cmbMedicamentos.DisplayMember = "Nombre";
            cmbMedicamentos.ValueMember = "Id_medicamento";
            cmbMedicamentos.SelectedIndex = -1;
        }

        private void CargarCombosSintomas()
        {
            cmbSintomas.DataSource = Comunes.ObtenerSintomas();
            cmbSintomas.DisplayMember = "Descripcion";
            cmbSintomas.ValueMember = "Id_sintoma";
            cmbSintomas.SelectedIndex = -1;
        }



        private void ConsultaMedica_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregarM_Click(object sender, EventArgs e)
        {
            grdMedicamentos.Rows.Add(cmbMedicamentos.SelectedValue, cmbMedicamentos.Text);
        }

        private void btnAgregarSintomas_Click(object sender, EventArgs e)
        {
            gdrSintomas.Rows.Add(cmbSintomas.SelectedValue, cmbSintomas.Text);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Volver();
        }
    }
}
