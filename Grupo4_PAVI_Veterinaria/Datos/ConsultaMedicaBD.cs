using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo4_PAVI_Veterinaria.Datos
{
    internal class ConsultaMedicaBD
    {

        public static string UltimaConsultaXNroHC(string nroHc)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();


                string consulta = "SELECT MAX(Id_Consulta) FROM Consultas WHERE Nro_HC = @nroHC ";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nroHC", nroHc);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                int resultado = (int)cmd.ExecuteScalar();
                int id = resultado + 1;
                return id.ToString();

            }
            catch (Exception)
            {
                return "1";
            }
            finally
            {
                cn.Close();
            }
        }
        public static bool AltaNuevaConsulta(int nroHC, int idConsulta, int legajo, List<int> listaMedicamentos, List<int> listaSintomas)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlTransaction objTransaccion = null;
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();


                string consulta = "INSERT INTO Consultas VALUES(@nroHC,@idConsulta,@fecha, @legajo)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nroHC", nroHC);
                cmd.Parameters.AddWithValue("@idConsulta", idConsulta);
                cmd.Parameters.AddWithValue("@fecha", DateTime.Now);
                cmd.Parameters.AddWithValue("@legajo", legajo);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;


                cn.Open();
                objTransaccion = cn.BeginTransaction("AltaConsultaMedica");
                cmd.Transaction = objTransaccion;
                cmd.Connection = cn;

                cmd.ExecuteNonQuery();

                foreach (var idMedicamento in listaMedicamentos)
                {
                    string consulta2 = "INSERT INTO MedicamentosXConsulta VALUES(@idMedicamento, @nroHC,@idConsulta)";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@idMedicamento", idMedicamento);
                    cmd.Parameters.AddWithValue("@nroHC", nroHC);
                    cmd.Parameters.AddWithValue("@idConsulta", idConsulta);

                    cmd.CommandText = consulta2;
                    cmd.ExecuteNonQuery();
                }

                foreach (var idSintoma in listaSintomas)
                {
                    string consulta3 = "INSERT INTO SintomasXConsultas VALUES(@nroHC,@idConsulta,@idSintoma)";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@idSintoma", idSintoma);
                    cmd.Parameters.AddWithValue("@nroHC", nroHC);
                    cmd.Parameters.AddWithValue("@idConsulta", idConsulta);

                    cmd.CommandText = consulta3;
                    cmd.ExecuteNonQuery();
                }

                objTransaccion.Commit();
                return true;


            }
            catch (Exception)
            {
                objTransaccion.Rollback();
                return false;
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
