using System.Data.SqlClient;
using System.Data;
using Grupo4_PAVI_Veterinaria.formularios;
using Grupo4_PAVI_Veterinaria.Datos;

namespace Grupo4_PAVI_Veterinaria
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Equals("") || txtPassword.Text.Equals(""))
            {
                MessageBox.Show("Ingrese nombre de usuario y contraseña");
            }
            else
            {
                string nombreDeUsuario = txtUsuario.Text;
                string contra = txtPassword.Text;
                bool resultado = false;
                try
                {
                    
                    resultado = UsuariosBD.ValidarUsuario(nombreDeUsuario, contra);
                }
                catch (Exception)
                {

                    MessageBox.Show("Error al consultar el usuario");
                }

                if (resultado)
                {
                    DataTable rol = UsuariosBD.ObtenerRol(nombreDeUsuario, contra);
                    if ((rol.Rows[0][3]).ToString().Equals("administrador"))
                    {
                        formularios.abmcUsuario.Usuarios ven = new formularios.abmcUsuario.Usuarios();
                        ven.Show();
                        this.Hide();
                    }
                    else
                    {
                        PrincipalForm ventana = new PrincipalForm(nombreDeUsuario);
                        ventana.Show();
                        this.Hide();
                    }
                    
                }
                else
                {
                    MessageBox.Show("Usuario Inexistente");
                }
            }
        }

    }
}