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

namespace Grupo4_PAVI_Veterinaria.formularios.abmcDueños
{
    public partial class Dueños : Form
    {
        public Dueños()
        {
            InitializeComponent();
        }

        private void Dueños_Load(object sender, EventArgs e)
        {
            cargarComboTipoDoc();
            LimpiarCampos();
            cargarGrillaDueños();
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;

        }

        private void cargarGrillaDueños()
        {
            try
            {
                gdrDueños.DataSource = DueñosBD.ObtenerGrillaDueños();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la grilla de Empleados");
            }
        }

        private void LimpiarCampos()
        {
            txtNombreDueño.Text = "";
            txtApellidoDueño.Text = "";
            txtTelefonoDueño.Text = "";
            txtNroDocumento.Text = "";
            cmbTipoDoc.Text = "";

        }

        private void gdrDueños_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex; //Me indica en que fila estoy parado
            btnActualizar.Enabled = true;
            btnEliminar.Enabled = true;
            btnRegistrar.Enabled = false;
            DataGridViewRow filaSeleccionada = gdrDueños.Rows[indice];
            string doc = filaSeleccionada.Cells["Documento"].Value.ToString();
            Dueño due = DueñosBD.ObtenerDueño(doc);
            LimpiarCampos();
            cargarDueño(due);
        }

        private void cargarDueño(Dueño due)
        {
            txtNombreDueño.Text = due.NombreDueño;
            txtApellidoDueño.Text = due.ApellidoDueño;
            txtTelefonoDueño.Text = due.TelefonoDueño;
            txtNroDocumento.Text = due.DocumentoDueño;
            cmbTipoDoc.SelectedValue = due.IdTipoDoc;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
            btnRegistrar.Enabled = true;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (VerificarCampos() == true)
            {


                Dueño du = ObtenerDatosDueño(); //Obtengo los datos de los txt
                bool resultado = DueñosBD.AgregarDueñoABD(du); //Los agrego a la BD
                if (resultado)
                {
                    MessageBox.Show("Empleado agregado con éxito");
                   cargarGrillaDueños();
                    LimpiarCampos();

                }
                else
                {
                    MessageBox.Show("Error al agregar Empleado");
                }
            }
            else
            {
                MessageBox.Show("Error al registrar.");
            }
        }

        private Dueño ObtenerDatosDueño()
        {
            Dueño du = new Dueño();
            
            du.NombreDueño = txtNombreDueño.Text.Trim();
            du.ApellidoDueño = txtApellidoDueño.Text.Trim();
            du.TelefonoDueño = txtTelefonoDueño.Text.Trim();
            du.ActivoDueño = 1;
            du.DocumentoDueño = txtNroDocumento.Text.Trim();
            du.IdTipoDoc = (int)cmbTipoDoc.SelectedValue;


            return du;
        }

        private bool VerificarCampos()
        {
            bool verificador = false;
            if (!txtTelefonoDueño.Text.Equals("") && !txtNombreDueño.Text.Equals("") && !txtApellidoDueño.Text.Equals(""))
            {
                verificador = true;
            }
            return verificador;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Dueño du = ObtenerDatosDueño();
            bool resultado = DueñosBD.ActualizarDueño(du);
            if (resultado == true)
            {
                MessageBox.Show("Dueño actualizado con éxito..");
                btnRegistrar.Enabled = true;
                btnActualizar.Enabled = false;
                btnEliminar.Enabled = false;
                cargarGrillaDueños();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Error, no se pudo actualizar el usuario");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Desea continuar con la baja?", "Confirmación de baja", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Dueño du = ObtenerDatosDueño(); //Obtengo los datos de los txt
                bool resultado = DueñosBD.EliminarDueñoBD(du); //Los agrego a la BD
                if (resultado)
                {
                    MessageBox.Show("Dueño eliminado con éxito");
                    btnRegistrar.Enabled = true;
                    btnActualizar.Enabled = false;
                    btnEliminar.Enabled = false;
                    cargarGrillaDueños();
                    LimpiarCampos();

                }
                else
                {
                    MessageBox.Show("Error al eliminar usuario");
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Usted ha cancelado la acción.");
            }
        }
        private void cargarComboTipoDoc()
        {
            try
            {
                cmbTipoDoc.DataSource = DueñosBD.ObtenerTipoDoc();
                cmbTipoDoc.DisplayMember = "Nombre"; //Cada opcion del combo me lo mostras de la columna Nombre
                cmbTipoDoc.ValueMember = "Id_tipodoc"; //Cada opcion del combo su valor esta dado por su id
                cmbTipoDoc.SelectedIndex = -1; //Deja por defecto nada seleccionado

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al cargar los tipos de Documentos");
            }
        }
    }
}
