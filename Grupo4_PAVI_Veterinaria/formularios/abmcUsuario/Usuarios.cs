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

namespace Grupo4_PAVI_Veterinaria.formularios.abmcUsuario
{
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            btnActualizarUsuario.Enabled = false;
            btnBajaUsuario.Enabled = false;
            
            CargarGrillaUsuarios();
        }


        private void txtRepetirPassword_TextChanged(object sender, EventArgs e)
        { 

        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtNombreUsuario.Text = "";
            txtPasswordUsuario.Text = "";
            txtRepetirPassword.Text = "";
            txtRol.Text = "";
            btnActualizarUsuario.Enabled = false;
            btnBajaUsuario.Enabled = false;
            btnAltaUsuario.Enabled = false;
        }

        private void btnAltaUsuario_Click(object sender, EventArgs e)
        {
            if (txtNombreUsuario.Text.Equals(""))
            {
                MessageBox.Show("Ingrese nombre de usuario");
            }
            else
            {
                if (txtPasswordUsuario.Text.Equals(txtRepetirPassword.Text))
                {
                    try
                    {
                        Usuario usu = ObtenerDatosUsuario();
                        bool resultado = UsuariosBD.InsertarUsuario(usu);
                        if (resultado == true)
                        {
                            MessageBox.Show("Usuario dado de alta con exito");
                            LimpiarCampos();
                            CargarGrillaUsuarios();
                            txtNombreUsuario.Focus();
                        }
                        else
                        {
                            MessageBox.Show("Error al insertar nuevo usuario");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al insertar nuevo usuario");
                        txtNombreUsuario.Focus(); ;
                    }
                }
                else
                {
                    MessageBox.Show("Los passwords no coinciden");
                }
            }
        }


        private void CargarGrillaUsuarios()
        {
            try
            {
                grillaUsuarios.DataSource = UsuariosBD.CargarGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la grilla de Empleados");
            }
        }

        private void btnActualizarUsuario_Click(object sender, EventArgs e)
        {
            Usuario usu = ObtenerDatosUsuario();
            bool resultado = UsuariosBD.ActualizarUsuario(usu);
            if (resultado == true)
            {
                MessageBox.Show("Usuario actualizado con éxito..");
                btnAltaUsuario.Enabled = true;
                btnActualizarUsuario.Enabled = false;
                btnBajaUsuario.Enabled = false;
                CargarGrillaUsuarios();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Error, no se pudo actualizar el usuario");
            }
        }

        private Usuario ObtenerDatosUsuario()
        {
            Usuario usu = new Usuario();
            usu.NombreDeUsuario = txtNombreUsuario.Text.Trim(); 
            usu.Contraseña = txtPasswordUsuario.Text.Trim();
            usu.RolUsuario = txtRol.Text.Trim();
            usu.ActivoUsuario = 1;

            return usu;
        }


        private void btnBajaUsuario_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Desea continuar con la baja?", "Confirmación de baja", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Usuario usu = ObtenerDatosUsuario(); //Obtengo los datos de los txt
                bool resultado = UsuariosBD.EliminarUsuarioBD(usu); //Los agrego a la BD
                if (resultado)
                {
                    MessageBox.Show("Usuario eliminado con éxito");
                    btnAltaUsuario.Enabled = true;
                    btnActualizarUsuario.Enabled = false;
                    btnBajaUsuario.Enabled = false;
                    CargarGrillaUsuarios();
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

        private void grillaUsuarios_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            btnActualizarUsuario.Enabled = true;
            btnBajaUsuario.Enabled = true;
            btnAltaUsuario.Enabled = false;
            DataGridViewRow filaSeleccionada = grillaUsuarios.Rows[indice];
            string usuario = filaSeleccionada.Cells["Usuario"].Value.ToString();
            Usuario usu = UsuariosBD.ObtenerUsuario(usuario);
            LimpiarCampos();
            cargarUsuario(usu);

        }

        private void cargarUsuario(Usuario usu)
        {
            txtNombreUsuario.Text = usu.NombreDeUsuario.ToString();
            txtPasswordUsuario.Text = usu.Contraseña.ToString();
            txtRepetirPassword.Text = usu.Contraseña.ToString();
            txtRol.Text = usu.RolUsuario.ToString();
        }
    }
}
