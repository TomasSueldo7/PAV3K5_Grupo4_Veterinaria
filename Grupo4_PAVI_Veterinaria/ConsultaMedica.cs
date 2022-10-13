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
        public ConsultaMedica()
        {
            InitializeComponent();
        }

        private void btnBuscarHC_Click(object sender, EventArgs e)
        {
            if (txtNroHC.Text.Equals(""))
            {
                MessageBox.Show("Ingrese un número de historia clínica.");
            }
            else
            {
                string nroHc = txtNroHC.Text;
                Perro p = PerrosBD.ObtenerPerro(nroHc);
                if(p.Activo)
                {
                    txtNroConsulta.Text = ConsultaMedicaBD.UltimaConsultaXNroHC(nroHc);
                    RellenarPerro(p);
                }
                else
                {
                    MessageBox.Show("El perro buscado no existe, por favor ingrese un N° de historia clínica existente.");
                    LimpiarCampos();
                }
            }
        }

        private void RellenarPerro(Perro p)
        {
            txtNombre.Text = p.Nombre;
            txtFechaNacimiento.Text = p.FechaNacimiento.ToString();
            txtAltura.Text = p.Altura.ToString();
            txtPeso.Text = p.Peso.ToString();
            txtRaza.Text = p.Id_raza.ToString();
            txtDueño.Text = p.Id_dueño.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtFechaNacimiento.Text = "";
            txtAltura.Text = "";
            txtPeso.Text = "";
            txtRaza.Text = "";
            txtDueño.Text = "";
            txtNroHC.Text = "";
            txtLegajo.Text = "";
            grdMedicamentos.Rows.Clear();
            gdrSintomas.Rows.Clear();
            txtNroConsulta.Text = "";
        }
        private void btnBuscarMedicamentos_Click(object sender, EventArgs e)
        {
            if (txtNroMedicamento.Text.Equals(""))
            {
                MessageBox.Show("Ingrese un número de medicamento.");
            }
            else
            {
                try
                {
                    DataTable tablaResultado = Comunes.ObtenerMedicamentosXId(int.Parse(txtNroMedicamento.Text.Trim()));
                    if (tablaResultado.Rows.Count > 0)
                    {
                        txtMedicamento.Text = tablaResultado.Rows[0][1].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Medicamento inexistente.");
                        txtNroMedicamento.Focus();
                        txtNroMedicamento.Text = "";
                    }
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
        }

        private void btnBuscarSintomas_Click(object sender, EventArgs e)
        {
            if (txtNroSintoma.Text.Equals(""))
            {
                MessageBox.Show("Ingrese un número de sintoma.");
            }
            else
            {
                try
                {
                    DataTable tablaResultado = Comunes.ObtenerSintomasXId(int.Parse(txtNroSintoma.Text.Trim()));
                    if (tablaResultado.Rows.Count > 0)
                    {
                        txtSintoma.Text = tablaResultado.Rows[0][1].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Sintoma inexistente.");
                        txtNroSintoma.Focus();
                        txtNroSintoma.Text = "";
                    }
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
        }

        private void btnAgregarMedicamentos_Click(object sender, EventArgs e)
        {
            grdMedicamentos.Rows.Add(txtNroMedicamento.Text.Trim(), txtMedicamento.Text.Trim());
        }

        private void btnAgregarSintomas_Click(object sender, EventArgs e)
        {
            gdrSintomas.Rows.Add(txtNroSintoma.Text.Trim(), txtSintoma.Text.Trim());
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
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

        private void txtNroConsulta_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
