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

    class AccesosV
    {
        public static DataTable llenarComboAgrupacion()
        {
            MySqlConnection con = new MySqlConnection("server=sql230.main-hosting.eu;user id=u348691639_BelenPenzo;password=15elamanecer15;database=u348691639_RucaChampaqui" +
          "");

            try
            {
                MySqlCommand cm = new MySqlCommand();
                string consulta = "SELECT DISTINCT nombre, tipoAgrupacion FROM agrupacion";
                cm.Parameters.Clear();
                cm.CommandType = CommandType.Text;
                cm.CommandText = consulta;
                con.Open();
                cm.Connection = con;
                MySqlDataAdapter da = new MySqlDataAdapter(cm);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;


            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                con.Close();
            }
        }

        public static DataTable llenarComboPariente()
        {
            MySqlConnection con = new MySqlConnection("server=sql230.main-hosting.eu;user id=u348691639_BelenPenzo;password=15elamanecer15;database=u348691639_RucaChampaqui" +
          "");

            try
            {
                MySqlCommand cm = new MySqlCommand();
                string consulta = "SELECT * FROM parentesco";
                cm.Parameters.Clear();
                cm.CommandType = CommandType.Text;
                cm.CommandText = consulta;
                con.Open();
                cm.Connection = con;
                MySqlDataAdapter da = new MySqlDataAdapter(cm);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;


            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                con.Close();
            }
        }
        public static DataTable llenarComboSeccion(int agru)
        {
            MySqlConnection con = new MySqlConnection("server=sql230.main-hosting.eu;user id=u348691639_BelenPenzo;password=15elamanecer15;database=u348691639_RucaChampaqui" +
          "");

            try
            {
               
                MySqlCommand cm = new MySqlCommand();
                string consulta = "SELECT s.nombre, s.tipoSeccion FROM agrupacion a INNER JOIN seccion s ON (a.tipoSeccion = s.tipoSeccion) WHERE a.tipoAgrupacion=" + agru;
                cm.Parameters.Clear();
                cm.CommandType = CommandType.Text;
                cm.CommandText = consulta;
                con.Open();
                cm.Connection = con;
                MySqlDataAdapter da = new MySqlDataAdapter(cm);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;


            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                con.Close();
            }
        }

        public static DataTable llenarComboBarrio()
        {
            MySqlConnection con = new MySqlConnection("server=sql230.main-hosting.eu;user id=u348691639_BelenPenzo;password=15elamanecer15;database=u348691639_RucaChampaqui" +
          "");

            try
            {
                MySqlCommand cm = new MySqlCommand();
                string consulta = "SELECT * FROM barrio";
                cm.Parameters.Clear();
                cm.CommandType = CommandType.Text;
                cm.CommandText = consulta;
                con.Open();
                cm.Connection = con;
                MySqlDataAdapter da = new MySqlDataAdapter(cm);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;


            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                con.Close();
            }
        }

        public static DataTable llenarComboColegio()
        {
            MySqlConnection con = new MySqlConnection("server=sql230.main-hosting.eu;user id=u348691639_BelenPenzo;password=15elamanecer15;database=u348691639_RucaChampaqui" +
          "");

            try
            {
                MySqlCommand cm = new MySqlCommand();
                string consulta = "SELECT * FROM colegio";
                cm.Parameters.Clear();
                cm.CommandType = CommandType.Text;
                cm.CommandText = consulta;
                con.Open();
                cm.Connection = con;
                MySqlDataAdapter da = new MySqlDataAdapter(cm);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;


            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                con.Close();
            }
        }

        public static DataTable llenarComboCompania()
        {
            MySqlConnection con = new MySqlConnection("server=sql230.main-hosting.eu;user id=u348691639_BelenPenzo;password=15elamanecer15;database=u348691639_RucaChampaqui" +
          "");

            try
            {
                MySqlCommand cm = new MySqlCommand();
                string consulta = "SELECT * FROM companiaTelefonica";
                cm.Parameters.Clear();
                cm.CommandType = CommandType.Text;
                cm.CommandText = consulta;
                con.Open();
                cm.Connection = con;
                MySqlDataAdapter da = new MySqlDataAdapter(cm);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;


            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                con.Close();
            }
        }

        public static DataTable llenarComboTipoDoc()
        {
            MySqlConnection con = new MySqlConnection("server=sql230.main-hosting.eu;user id=u348691639_BelenPenzo;password=15elamanecer15;database=u348691639_RucaChampaqui" +
          "");

            try
            {
                MySqlCommand cm = new MySqlCommand();
                string consulta = "SELECT * FROM tipoDocumento";
                cm.Parameters.Clear();
                cm.CommandType = CommandType.Text;
                cm.CommandText = consulta;
                con.Open();
                cm.Connection = con;
                MySqlDataAdapter da = new MySqlDataAdapter(cm);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;


            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                con.Close();
            }
        }

        public static DataTable llenarComboHobby()
        {
            MySqlConnection con = new MySqlConnection("server=sql230.main-hosting.eu;user id=u348691639_BelenPenzo;password=15elamanecer15;database=u348691639_RucaChampaqui" +
          "");

            try
            {
                MySqlCommand cm = new MySqlCommand();
                string consulta = "SELECT * FROM hobby";
                cm.Parameters.Clear();
                cm.CommandType = CommandType.Text;
                cm.CommandText = consulta;
                con.Open();
                cm.Connection = con;
                MySqlDataAdapter da = new MySqlDataAdapter(cm);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;


            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                con.Close();
            }
        }

        public static String formato_fecha(int año, int mes, int dia)
        {
            return año.ToString() + "-" + mes.ToString() + "-" + dia.ToString();
        }

        public static String formato_fechaBuscar(int año, int mes, int dia)
        {
            return dia.ToString()+ "-" + mes.ToString()+ "-" + año.ToString();
        }

        public static DataTable llenarComboObraSocial()
        {
            MySqlConnection con = new MySqlConnection("server=sql230.main-hosting.eu;user id=u348691639_BelenPenzo;password=15elamanecer15;database=u348691639_RucaChampaqui" +
          "");

            try
            {
                MySqlCommand cm = new MySqlCommand();
                string consulta = "SELECT * FROM obraSocial";
                cm.Parameters.Clear();
                cm.CommandType = CommandType.Text;
                cm.CommandText = consulta;
                con.Open();
                cm.Connection = con;
                MySqlDataAdapter da = new MySqlDataAdapter(cm);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;


            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                con.Close();
            }
        }

        public static DataTable llenarComboOcupacion()
        {
            MySqlConnection con = new MySqlConnection("server=sql230.main-hosting.eu;user id=u348691639_BelenPenzo;password=15elamanecer15;database=u348691639_RucaChampaqui" +
          "");

            try
            {
                MySqlCommand cm = new MySqlCommand();
                string consulta = "SELECT * FROM ocupacion";
                cm.Parameters.Clear();
                cm.CommandType = CommandType.Text;
                cm.CommandText = consulta;
                con.Open();
                cm.Connection = con;
                MySqlDataAdapter da = new MySqlDataAdapter(cm);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;


            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                con.Close();
            }
        }

        public static DataTable DevolverContraseña(string numero, string nombre)
        {

            MySqlConnection cn = new MySqlConnection("server=sql230.main-hosting.eu;user id=u348691639_BelenPenzo;password=15elamanecer15;database=u348691639_RucaChampaqui" +
          "");

            try
            {
                MySqlCommand cmd = new MySqlCommand();

                string consulta = "SELECT * FROM login WHERE contasena LIKE @contr AND nombre LIKE @nomb AND control LIKE @control";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@contr", numero);
                cmd.Parameters.AddWithValue("@nomb", nombre);
                cmd.Parameters.AddWithValue("@control", "2.0");
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

    }
}

