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
    internal class DueñosBD
    {

        public static DataTable ObtenerGrillaDueños()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {

                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT Nombre, Apellido, Telefono, nro_doc " +
                    "FROM Dueños where Activo = 1";

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

        public static Dueño ObtenerDueño(string? nrodoc)
        {
            bool resultado = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Dueño du = new Dueño();

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Dueños where nro_doc like @nrodoc";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nrodoc", nrodoc);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader(); 
                if (dr != null && dr.Read()) 
                                              
                {
                    du.NombreDueño = dr["Nombre"].ToString();
                    du.ApellidoDueño = dr["Apellido"].ToString();
                    du.TelefonoDueño = dr["Telefono"].ToString();
                    du.IdTipoDoc = (int)dr["Id_tipodoc"];
                    du.DocumentoDueño = dr["nro_doc"].ToString();

                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }
            return du;
        }

        public static bool AgregarDueñoABD(Dueño du)
        {
            bool resultado = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand(); //falta insertar el activo
                string consulta = "INSERT INTO Dueños(Nombre, Apellido, Telefono, Activo, Id_tipodoc, nro_doc ) VALUES(@nombre, @apellido, @telefono, @activo, @tipodoc, @nrodoc) ";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", du.NombreDueño);
                cmd.Parameters.AddWithValue("@apellido", du.ApellidoDueño);
                cmd.Parameters.AddWithValue("@telefono", du.TelefonoDueño);
                cmd.Parameters.AddWithValue("@activo", du.ActivoDueño);
                cmd.Parameters.AddWithValue("@tipodoc", du.IdTipoDoc);
                cmd.Parameters.AddWithValue("@nrodoc", du.DocumentoDueño);

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
            finally
            {
                cn.Close();
            }
            return resultado;
        }

        public static bool ActualizarDueño(Dueño du)
        {
            bool resultado = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE Dueños SET Nombre = @nombre, Apellido = @apellido, Telefono = @telefono, Id_tipodoc = @tipodoc WHERE nro_doc LIKE @nrodoc"; //el dni del dueño no se puede cambiar
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", du.NombreDueño);
                cmd.Parameters.AddWithValue("@apellido", du.ApellidoDueño);
                cmd.Parameters.AddWithValue("@telefono", du.TelefonoDueño);
                cmd.Parameters.AddWithValue("@nrodoc", du.DocumentoDueño);
                cmd.Parameters.AddWithValue("@tipodoc", du.IdTipoDoc);
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

        public static bool EliminarDueñoBD(Dueño du)
        {
            bool resultado = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE Dueños SET Activo = 0 WHERE Nombre = @du"; 
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@du", du.NombreDueño);
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

        public static DataTable ObtenerTipoDoc()
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {

                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * " +
                    "FROM Tipo_Doc";

                cmd.Parameters.Clear(); //Limpiar todos los tipos de parámetros que puede llegar a tener

                cmd.CommandType = CommandType.Text; //El commandtype es .text, es decir yo escribo a mano la consulta
                cmd.CommandText = consulta; //cual es la consulta q quiero ejecutar

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
    }
}
