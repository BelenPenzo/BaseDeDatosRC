using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace BaseDeDatosRuca.Clases
{
    class AcessosB
    {
        public static DataTable ObtenerMilicianoDocumento(int tipoDocumento, int documento)
        {

            MySqlConnection cn = new MySqlConnection("server=sql230.main-hosting.eu;user id=u348691639_BelenPenzo;password=15elamanecer15;database=u348691639_RucaChampaqui" +
          "");

            try
            {
                MySqlCommand cmd = new MySqlCommand();

                string consulta = "SELECT * FROM miliciano WHERE tipoDocumento LIKE @codDocu AND nroDocumento LIKE @nroDocu";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codDocu", tipoDocumento);
                cmd.Parameters.AddWithValue("@nroDocu", documento);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                cn.Close();

                DataTable tabla = new DataTable();


                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(tabla);

                return tabla;

            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                cn.Close();
            }
        }

        public static string DevolverBarrio(int numero)
        {

            MySqlConnection cn = new MySqlConnection("server=sql230.main-hosting.eu;user id=u348691639_BelenPenzo;password=15elamanecer15;database=u348691639_RucaChampaqui" +
          "");

            try
            {
                MySqlCommand cmd = new MySqlCommand();

                string consulta = "SELECT nombre FROM barrio WHERE tipoBarrio=@codBarrio";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codBarrio", numero);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();


                string resultado = (string)cmd.ExecuteScalar();
                cn.Close();
                return resultado;

            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                cn.Close();
            }
        }

        public static string DevolverHobby(int numero)
        {

            MySqlConnection cn = new MySqlConnection("server=sql230.main-hosting.eu;user id=u348691639_BelenPenzo;password=15elamanecer15;database=u348691639_RucaChampaqui" +
          "");

            try
            {
                MySqlCommand cmd = new MySqlCommand();

                string consulta = "SELECT nombre FROM hobby WHERE tipoHobby=@codHobby";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codHobby", numero);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();


                string resultado = (string)cmd.ExecuteScalar();
                cn.Close();
                return resultado;

            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                cn.Close();
            }
        }

        public static string DevolverColegio(int numero)
        {

            MySqlConnection cn = new MySqlConnection("server=sql230.main-hosting.eu;user id=u348691639_BelenPenzo;password=15elamanecer15;database=u348691639_RucaChampaqui" +
          "");

            try
            {
                MySqlCommand cmd = new MySqlCommand();

                string consulta = "SELECT nombre FROM colegio WHERE tipoColegio=@codColegio";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codColegio", numero);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();


                string resultado = (string)cmd.ExecuteScalar();
                cn.Close();
                return resultado;

            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                cn.Close();
            }
        }

        public static string DevolverCompania(int numero)
        {

            MySqlConnection cn = new MySqlConnection("server=sql230.main-hosting.eu;user id=u348691639_BelenPenzo;password=15elamanecer15;database=u348691639_RucaChampaqui" +
          "");

            try
            {
                MySqlCommand cmd = new MySqlCommand();

                string consulta = "SELECT nombre FROM companiaTelefonica WHERE tipoCompania=@codCompania";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codCompania", numero);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();


                string resultado = (string)cmd.ExecuteScalar();
                cn.Close();
                return resultado;

            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                cn.Close();
            }
        }

        public static string DevolverAgrupacion(int numero)
        {

            MySqlConnection cn = new MySqlConnection("server=sql230.main-hosting.eu;user id=u348691639_BelenPenzo;password=15elamanecer15;database=u348691639_RucaChampaqui" +
          "");

            try
            {
                MySqlCommand cmd = new MySqlCommand();

                string consulta = "SELECT nombre FROM agrupacion WHERE tipoAgrupacion=@codAgrupacion";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codAgrupacion", numero);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();


                string resultado = (string)cmd.ExecuteScalar();
                cn.Close();
                return resultado;

            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                cn.Close();
            }
        }

        public static string DevolverSeccion(int numero)
        {

            MySqlConnection cn = new MySqlConnection("server=sql230.main-hosting.eu;user id=u348691639_BelenPenzo;password=15elamanecer15;database=u348691639_RucaChampaqui" +
          "");

            try
            {
                MySqlCommand cmd = new MySqlCommand();

                string consulta = "SELECT s.nombre FROM agrupacion a INNER JOIN seccion s ON (a.tipoSeccion=s.tipoSeccion) WHERE a.tipoSeccion=@codSeccion";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codSeccion", numero);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();


                string resultado = (string)cmd.ExecuteScalar();
                cn.Close();
                return resultado;

            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                cn.Close();
            }
        }

        public static DataTable ObtenerMilicianoCuota(int tipoDocumento, int documento)
        {

            MySqlConnection cn = new MySqlConnection("server=sql230.main-hosting.eu;user id=u348691639_BelenPenzo;password=15elamanecer15;database=u348691639_RucaChampaqui" +
          "");

            try
            {
                MySqlCommand cmd = new MySqlCommand();

                string consulta = "SELECT c.primeraCuota, c.segundaCuota, c.formasPagoExtra, c.fechaPrimeraCuota, c.fechaSegundaCuota FROM cuota c INNER JOIN miliciano m ON (c.tipoDocumento = m.tipoDocumento AND c.documento=m.nroDocumento) WHERE m.tipoDocumento LIKE @codDocu AND m.nroDocumento LIKE @nroDocu";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nroDocu", documento);
                cmd.Parameters.AddWithValue("@codDocu", tipoDocumento);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                cn.Close();

                DataTable tabla = new DataTable();


                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(tabla);

                return tabla;

            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                cn.Close();
            }
        }

        public static DataTable ObtenerMilicianoFicha(int tipoDocumento, int documento)
        {

            MySqlConnection cn = new MySqlConnection("server=sql230.main-hosting.eu;user id=u348691639_BelenPenzo;password=15elamanecer15;database=u348691639_RucaChampaqui" +
          "");

            try
            {
                MySqlCommand cmd = new MySqlCommand();

                string consulta = "SELECT * FROM fichaMedica f INNER JOIN miliciano m ON (f.tipoDocumento = m.tipoDocumento AND f.NroDocumento=m.nroDocumento) WHERE m.tipoDocumento LIKE @codDocu AND m.nroDocumento LIKE @nroDocu";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nroDocu", documento);
                cmd.Parameters.AddWithValue("@codDocu", tipoDocumento);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                cn.Close();

                DataTable tabla = new DataTable();


                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(tabla);

                return tabla;

            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                cn.Close();
            }
        }


        public static DataTable ObtenerParienteDocumentoMiliciano(int tipoDocumento, int documento)
        {

            MySqlConnection cn = new MySqlConnection("server=sql230.main-hosting.eu;user id=u348691639_BelenPenzo;password=15elamanecer15;database=u348691639_RucaChampaqui" +
          "");

            try
            {
                MySqlCommand cmd = new MySqlCommand();

                string consulta = "SELECT * FROM pariente WHERE tipoDocumentoMiliciano LIKE @codDocu AND nroDocumentoMiliciano LIKE @nroDocu";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codDocu", tipoDocumento);
                cmd.Parameters.AddWithValue("@nroDocu", documento);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                cn.Close();

                DataTable tabla = new DataTable();


                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(tabla);

                return tabla;

            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                cn.Close();
            }
        }

       
        public static string DevolverOcupacion(int numero)
        {

            MySqlConnection cn = new MySqlConnection("server=sql230.main-hosting.eu;user id=u348691639_BelenPenzo;password=15elamanecer15;database=u348691639_RucaChampaqui" +
          "");

            try
            {
                MySqlCommand cmd = new MySqlCommand();

                string consulta = "SELECT nombre FROM ocupacion WHERE tipoOcupacion=@codOcupacion";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codOcupacion", numero);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();


                string resultado = (string)cmd.ExecuteScalar();
                cn.Close();
                return resultado;

            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                cn.Close();
            }
        }

        public static string DevolverParentesco(int numero)
        {

            MySqlConnection cn = new MySqlConnection("server=sql230.main-hosting.eu;user id=u348691639_BelenPenzo;password=15elamanecer15;database=u348691639_RucaChampaqui" +
          "");

            try
            {
                MySqlCommand cmd = new MySqlCommand();

                string consulta = "SELECT nombre FROM parentesco WHERE tipoPariente=@codP";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codP", numero);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();


                string resultado = (string)cmd.ExecuteScalar();
                cn.Close();
                return resultado;

            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                cn.Close();
            }
        }
        public static string DevolverPariente(int numero)
        {

            MySqlConnection cn = new MySqlConnection("server=sql230.main-hosting.eu;user id=u348691639_BelenPenzo;password=15elamanecer15;database=u348691639_RucaChampaqui" +
          "");

            try
            {
                MySqlCommand cmd = new MySqlCommand();

                string consulta = "SELECT nombre FROM parentesco WHERE tipoPariente=@codPa";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codPa", numero);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();


                string resultado = (string)cmd.ExecuteScalar();
                cn.Close();
                return resultado;

            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                cn.Close();
            }
        }

        public static string DevolverValorFicha(bool numero)
        {
            if(numero.ToString() == "True" )
            {
                return "Si";
            }
            else
            {
                return "No";
            }
        }

        public static void DevolverValorFichaCH(ref CheckBox ch_seleccionado, bool numero)
        {
            if (numero.ToString() ==  "True")
            {
               ch_seleccionado.Checked = true; 
            }
            
        }

        public static string DevolverObraSocial(int numero)
        {

            MySqlConnection cn = new MySqlConnection("server=sql230.main-hosting.eu;user id=u348691639_BelenPenzo;password=15elamanecer15;database=u348691639_RucaChampaqui" +
          "");

            try
            {
                MySqlCommand cmd = new MySqlCommand();

                string consulta = "SELECT nombre FROM obraSocial WHERE tipoObraSocial=@codObra";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codObra", numero);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();


                string resultado = (string)cmd.ExecuteScalar();
                cn.Close();
                return resultado;

            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                cn.Close();
            }
        }

        public static string DevolverTipoDocumento(int numero)
        {

            MySqlConnection cn = new MySqlConnection("server=sql230.main-hosting.eu;user id=u348691639_BelenPenzo;password=15elamanecer15;database=u348691639_RucaChampaqui" +
          "");

            try
            {
                MySqlCommand cmd = new MySqlCommand();

                string consulta = "SELECT nombre FROM tipoDocumento WHERE tipoDocumento=@codPa";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codPa", numero);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();


                string resultado = (string)cmd.ExecuteScalar();
                cn.Close();
                return resultado;

            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                cn.Close();
            }
        }

    }
}