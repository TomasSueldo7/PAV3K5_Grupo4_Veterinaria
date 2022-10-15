using Grupo4_PAVI_Veterinaria.Datos;
using Grupo4_PAVI_Veterinaria.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupo4_PAVI_Veterinaria.formularios.abmcPerros
{
    public partial class Perros : Form
    {
        public Perros()
        {
            InitializeComponent();
        }

        private void Perros_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            CargarCombosRazas();
            CargarCombosDueños();
            CargarGrilla();
            
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtFecha.Text = "";
            txtAltura.Text = "";
            txtPeso.Text = "";
            txtNombreBuscar.Text = "";
            cmbDueño.SelectedIndex = -1;
            cmbRaza.SelectedIndex = -1;
            txtMotivo.Text = "";
            btnEliminar.Enabled = false;
            btnActualizar.Enabled = false;
            txtMotivo.Enabled = false;
            txtNroHC.Text = PerrosBD.ObtenerUltimoNroHC();
        }

        private void CargarGrilla()
        {
            gdr_perros.DataSource = PerrosBD.ObtenerGrilla();
        }

        private void CargarCombosRazas()
        {
                cmbRaza.DataSource = PerrosBD.ObtenerRazas();
                cmbRaza.DisplayMember = "Denominacion";
                cmbRaza.ValueMember = "Id_raza";
                cmbRaza.SelectedIndex = -1;
        }

        private void CargarCombosDueños()
        {
                cmbDueño.DataSource = PerrosBD.ObtenerDueños();
                cmbDueño.DisplayMember = "Nombre";
                cmbDueño.ValueMember = "Id_dueño";
                cmbDueño.SelectedIndex = -1;
        }

        private Perro ObtenerDatosPerro()
        {
            Perro p = new Perro();
            p.Nro_HC = int.Parse(txtNroHC.Text.Trim());
            p.Nombre = txtNombre.Text.Trim();
            if (txtFecha.Text.Equals("  /  /"))
            {
                p.FechaNacimiento = DateTime.Now;
            }
            else
            {
                p.FechaNacimiento = DateTime.Parse(txtFecha.Text);
            }
            p.Id_raza = (int)cmbRaza.SelectedValue;
            p.Id_dueño = (int)cmbDueño.SelectedValue;
            p.Peso = float.Parse(txtPeso.Text.Trim());
            p.Altura = float.Parse(txtAltura.Text.Trim());
            p.Activo = true;
            return p;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (VerificarCampos() == true)
            {
                Perro p = ObtenerDatosPerro();
                bool resultado = PerrosBD.AgregarPerroBD(p);
                if (resultado)
                {
                    MessageBox.Show("Perro agregado con éxito.");
                    LimpiarCampos();
                    CargarCombosRazas();
                    CargarCombosDueños();
                    CargarGrilla();
                }
                else
                {
                    MessageBox.Show("Error al registrar.");
                }
            }
            else
            {
                MessageBox.Show("Por favor ingrese los datos solicitados");
            }
            
        }

        private void gdr_perros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            LimpiarCampos();
            btnActualizar.Enabled = true;
            btnEliminar.Enabled = true;
            txtMotivo.Enabled = true;
            DataGridViewRow fila = gdr_perros.Rows[indice];

            string nro_Hc = fila.Cells["Nro_HC"].Value.ToString();

            Perro p = PerrosBD.ObtenerPerro(nro_Hc);
            
            CargarCampos(p);
        }

        private void CargarCampos(Perro p)
        {
            txtNroHC.Text = p.Nro_HC.ToString();
            txtNombre.Text = p.Nombre;
            txtPeso.Text = p.Peso.ToString();
            txtAltura.Text = p.Altura.ToString();
            DateTime fecha = p.FechaNacimiento;
            string dia = fecha.Date.Day.ToString();
            string mes = fecha.Date.Month.ToString();
            string año = fecha.Date.Year.ToString();
            if (dia.Length == 1)
            {
                dia = "0" + dia;
            }
            if (mes.Length == 1)
            {
                mes = "0" + mes;
            }
            txtFecha.Text = dia + mes + año;
            cmbRaza.SelectedValue = p.Id_raza;
            cmbDueño.SelectedValue = p.Id_dueño;
        }
        private bool VerificarCampos()
        {
            bool verificador = false;
            if(cmbDueño.SelectedValue != null && cmbRaza.SelectedValue != null && ! txtNombre.Text.Equals(""))
            {
                verificador = true;
            }
            return verificador;
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Perro p = ObtenerDatosPerro();
            bool resultado = PerrosBD.ActualizarPerro(p);
            if (resultado)
            {
                MessageBox.Show("Perro actualizado con éxito.");
                LimpiarCampos();
                CargarCombosRazas();
                CargarCombosDueños();
                CargarGrilla();
            }
            else
            {
                MessageBox.Show("Error al actualizar.");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {       
            
                if (txtMotivo.Text.Equals(""))
                {
                    MessageBox.Show("Por favor cargue un motivo.");
                }
                else
                {
                    Perro p = ObtenerDatosPerro();
                    DialogResult dialogResult = MessageBox.Show("¿Desea continuar con la baja?", "Confirmación de baja", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        bool resultado = PerrosBD.EliminarPerro(p.Nro_HC.ToString());
                        MessageBox.Show("Se ha eliminado el registro.");
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        MessageBox.Show("Usted ha cancelado la acción.");
                    }
                    LimpiarCampos();
                    CargarCombosRazas();
                    CargarCombosDueños();
                    CargarGrilla();

                }                     
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
            if (txtNombreBuscar.Text.Equals(""))
            {
                MessageBox.Show("Ingrese un nombre");
            }
            else
            {
                string filtro = txtNombreBuscar.Text.Trim();
                gdr_perros.DataSource = PerrosBD.ObtenerFiltroGrilla(filtro);
            }
            
        }

        private void gdr_perros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
