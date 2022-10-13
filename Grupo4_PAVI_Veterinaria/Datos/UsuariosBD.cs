using Grupo4_PAVI_Veterinaria.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo4_PAVI_Veterinaria.Datos
{
    internal class UsuariosBD
    {
        public static bool ValidarUsuario(string nombreDeUsuario, string password)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                bool resultado = false;
                SqlCommand cmd = new SqlCommand();


                string consulta = "SELECT * FROM Usuarios WHERE Usuario LIKE @nombreDeUsuario AND Contra LIKE @password";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("nombreDeUsuario", nombreDeUsuario);
                cmd.Parameters.AddWithValue("password", password);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                if (tabla.Rows.Count == 1)
                {
                    resultado = true;
                }

                return resultado;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }

        }

        public static DataTable ObtenerRol(string nombreDeUsuario, string password)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                bool resultado = false;
                SqlCommand cmd = new SqlCommand();


                string consulta = "SELECT * FROM Usuarios WHERE Usuario LIKE @nombreDeUsuario AND Contra LIKE @password";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("nombreDeUsuario", nombreDeUsuario);
                cmd.Parameters.AddWithValue("password", password);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                
                return tabla;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }

        }

        public static bool InsertarUsuario(Usuario usu)
        {
            bool resultado = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO Usuarios (Usuario, Contra, Rol, Activo) VALUES(@nombreUsu, @pass, @rol, @activo)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombreUsu", usu.NombreDeUsuario);
                cmd.Parameters.AddWithValue("@pass", usu.Contraseña);
                cmd.Parameters.AddWithValue("@rol", usu.RolUsuario);
                cmd.Parameters.AddWithValue("@activo", usu.ActivoUsuario);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;

            }
            catch (Exception)
            {
                throw;
            }

            return resultado;
        }

        public static bool ActualizarUsuario(Usuario usu)
        {
            bool resultado = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE Usuarios SET Contra = @contra, Rol = @rol WHERE Usuario LIKE @nombreUsu"; //el nombre de usuario no se puede cambiar 
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombreUsu", usu.NombreDeUsuario);
                cmd.Parameters.AddWithValue("@contra", usu.Contraseña);
                cmd.Parameters.AddWithValue("@rol", usu.RolUsuario);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;

            }
            catch (Exception)
            {
                throw;
            }

            return resultado;
        }

        public static bool EliminarUsuarioBD(Usuario usu)
        {
            bool resultado = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE Usuarios SET Activo = 0 WHERE Usuario = @usu"; //el nombre de usuario no se puede cambiar 
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@usu", usu.NombreDeUsuario);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;

            }
            catch (Exception)
            {
                throw;
            }

            return resultado;
        }

        public static DataTable CargarGrilla()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Usuarios where Activo = 1";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                return tabla;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
        }

        public static Usuario ObtenerUsuario(string usuario)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Usuario usu = new Usuario();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Usuarios WHERE Usuario LIKE @usuario";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@usuario", usuario);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    usu.NombreDeUsuario = dr["Usuario"].ToString();
                    usu.Contraseña = dr["Contra"].ToString();
                    usu.RolUsuario = dr["Rol"].ToString();
                }

            }
            catch (Exception)
            {
                throw;
            }
            return usu;
        }

    }    
    
}
