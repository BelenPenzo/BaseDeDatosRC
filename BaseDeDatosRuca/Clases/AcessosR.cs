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
    class AcessosR
    {
        public static bool InsertarColegio(string colegio)
        {

            MySqlConnection con = new MySqlConnection("server=sql230.main-hosting.eu;user id=u348691639_BelenPenzo;password=15elamanecer15;database=u348691639_RucaChampaqui");
            
            try
            {
                MySqlCommand cmd = new MySqlCommand();

                string consulta = "INSERT INTO colegio (nombre) VALUES (@nombre);";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre",colegio.Trim());
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                con.Open();
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                con.Close();

                return true;

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

        public static bool InsertarMiliciano(int tipoDocumento,int nroDocu,int agrupacion,string nombre,string apellido,string calle,string nroCalle,int idBarrio,int hobby,int colegio,string telefono,int compania, string gmail, int seccion, string nacimiento)
        {
            string cadena = "server=sql230.main-hosting.eu;user id=u348691639_BelenPenzo;password=15elamanecer15;database=u348691639_RucaChampaqui";
            MySqlConnection cn = new MySqlConnection(cadena);
            try
            {
                MySqlCommand cmd = new MySqlCommand();

                string consulta = "INSERT INTO miliciano (tipoDocumento, nroDocumento, apellido, nombre, calle, nroCalle, idBarrio, idHobby,idColegio, telefono, tipoCompania,gmail,agrupacion, tipoSeccion, fechaNacimiento) VALUES (@tipo,@nroDocu,@apellid, @nombr,@cal,@nroCal,@idBar,@hobby,@coleg,@telef,@compa,@gma,@agrup,@secci, @nacimiento);";

                cmd.Parameters.Clear();
                
                cmd.Parameters.AddWithValue("@tipo", tipoDocumento);
                cmd.Parameters.AddWithValue("@nroDocu", nroDocu);
                cmd.Parameters.AddWithValue("@agrup", agrupacion);
                cmd.Parameters.AddWithValue("@nombr", nombre);
                cmd.Parameters.AddWithValue("@apellid", apellido);
                cmd.Parameters.AddWithValue("@cal", calle);
                cmd.Parameters.AddWithValue("@nroCal", nroCalle);
                cmd.Parameters.AddWithValue("@idBar", idBarrio);
                cmd.Parameters.AddWithValue("@hobby", hobby);
                cmd.Parameters.AddWithValue("@coleg",colegio);
                cmd.Parameters.AddWithValue("@telef", telefono);
                cmd.Parameters.AddWithValue("@compa", compania);
                cmd.Parameters.AddWithValue("@gma", gmail);
                cmd.Parameters.AddWithValue("@secci", seccion);
                cmd.Parameters.AddWithValue("@nacimiento", nacimiento);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                cn.Close();

                return true;

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

        public static bool ActualizarCuota(int tipoDocumento, int nroDocu,int primera,int segunda, string forma, string fechaP, string fechaS)
        {
            string cadena = "server=sql230.main-hosting.eu;user id=u348691639_BelenPenzo;password=15elamanecer15;database=u348691639_RucaChampaqui";
            MySqlConnection cn = new MySqlConnection(cadena);
            try
            {
                MySqlCommand cmd = new MySqlCommand();

                string consulta = "UPDATE cuota SET primeraCuota=@pri, segundaCuota=@seg, formasPagoExtra=@forma,  fechaPrimeraCuota=@fechaP, fechaSegundaCuota=@fechaS WHERE documento=@nroDocu AND tipoDocumento=@tipo";

                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@tipo", tipoDocumento);
                cmd.Parameters.AddWithValue("@nroDocu", nroDocu);
                cmd.Parameters.AddWithValue("@pri", primera);
                cmd.Parameters.AddWithValue("@seg", segunda);
                cmd.Parameters.AddWithValue("@forma", forma);
                cmd.Parameters.AddWithValue("@fechaP", fechaP);
                cmd.Parameters.AddWithValue("@fechaS", fechaS);


                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                cn.Close();

                return true;

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


        public static bool InsertarBarrio(string barrio)
        {

            MySqlConnection con = new MySqlConnection("server=sql230.main-hosting.eu;user id=u348691639_BelenPenzo;password=15elamanecer15;database=u348691639_RucaChampaqui");

            try
            {
                MySqlCommand cmd = new MySqlCommand();

                string consulta = "INSERT INTO barrio (nombre) VALUES (@nombre);";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", barrio.Trim());
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                con.Open();
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                con.Close();

                return true;

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

        public static bool InsertarHobby(string hobby)
        {

            MySqlConnection con = new MySqlConnection("server=sql230.main-hosting.eu;user id=u348691639_BelenPenzo;password=15elamanecer15;database=u348691639_RucaChampaqui");

            try
            {
                MySqlCommand cmd = new MySqlCommand();

                string consulta = "INSERT INTO hobby (nombre) VALUES (@nombre);";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre",hobby.Trim());
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                con.Open();
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                con.Close();

                return true;

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

        public static bool InsertarCompania(string compania)
        {

            MySqlConnection con = new MySqlConnection("server=sql230.main-hosting.eu;user id=u348691639_BelenPenzo;password=15elamanecer15;database=u348691639_RucaChampaqui");

            try
            {
                MySqlCommand cmd = new MySqlCommand();

                string consulta = "INSERT INTO companiaTelefonica (nombre) VALUES (@nombre);";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", compania.Trim());
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                con.Open();
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                con.Close();

                return true;

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

        public static bool InsertarOcupacion(string ocupacion)
        {

            MySqlConnection con = new MySqlConnection("server=sql230.main-hosting.eu;user id=u348691639_BelenPenzo;password=15elamanecer15;database=u348691639_RucaChampaqui");

            try
            {
                MySqlCommand cmd = new MySqlCommand();

                string consulta = "INSERT INTO ocupacion (nombre) VALUES (@nombre);";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", ocupacion.Trim());
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                con.Open();
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                con.Close();

                return true;

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

        public static bool InsertarObraSocial(string ObraSocial)
        {

            MySqlConnection con = new MySqlConnection("server=sql230.main-hosting.eu;user id=u348691639_BelenPenzo;password=15elamanecer15;database=u348691639_RucaChampaqui");

            try
            {
                MySqlCommand cmd = new MySqlCommand();

                string consulta = "INSERT INTO obraSocial (nombre) VALUES (@nombre);";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", ObraSocial.Trim());
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                con.Open();
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                con.Close();

                return true;

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

        public static bool InsertarCuota(int tipoDocumento, int nroDocu, int primera, int segunda, string forma,string fechapri, string fechaseg)
        {
            string cadena = "server=sql230.main-hosting.eu;user id=u348691639_BelenPenzo;password=15elamanecer15;database=u348691639_RucaChampaqui";
            MySqlConnection cn = new MySqlConnection(cadena);
            try
            {
                MySqlCommand cmd = new MySqlCommand();

                string consulta = "INSERT INTO cuota(tipoDocumento,documento,primeraCuota,segundaCuota,formasPagoExtra, fechaPrimeraCuota, fechaSegundaCuota) VALUES(@tipo,@nroDocu,@pri,@seg,@forma,@primera,@segunda); ";

                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@tipo", tipoDocumento);
                cmd.Parameters.AddWithValue("@nroDocu", nroDocu);
                cmd.Parameters.AddWithValue("@pri", primera);
                cmd.Parameters.AddWithValue("@seg", segunda);
                cmd.Parameters.AddWithValue("@forma", forma);
                cmd.Parameters.AddWithValue("@primera", fechapri);
                cmd.Parameters.AddWithValue("@segunda", fechaseg);



                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                cn.Close();

                return true;

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


        public static bool InsertarFichaMedica(int TipoDocumento, int NroDocu, int obraSocial, string nroAfiliado, string grupoSan, string alergia, int anginas,int antitetanica,int epilepsia,int hepatitis,int convulsiones,int bronquitis,int carnet,int diabetes,int urinaria,int celiaquia,int gastroenteritis,int otitis,int rubeola,int sarampion,int varicela)
        {
            string cadena = "server=sql230.main-hosting.eu;user id=u348691639_BelenPenzo;password=15elamanecer15;database=u348691639_RucaChampaqui";
            MySqlConnection cn = new MySqlConnection(cadena);
            try
            {
                MySqlCommand cmd = new MySqlCommand();

                string consulta = "INSERT INTO fichaMedica(tipoDocumento, nroDocumento, obraSocial, nroAfiliado, " +
                    "grupoSanguineo, rubeola,varicela, otitis, anginas, hepatitis, urinaria, diabetes, epilepsia," +
                    " sarampion, bronquitis, gastroenteritis" +
                    ", antitetanica, vacunacionCompleto, alergias, celiaquia, convulsion ) VALUES(@tipo,@nroDocu,@obra,@nro,@grupo," +
                    "@rubiol,@var,@oti,@ang,@hep,@uri,@dia,@epi,@saram,@bron,@gastr," +
                    "@anti,@car,@aler,@celi,@convu);";

                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@tipo",TipoDocumento);
                cmd.Parameters.AddWithValue("@nroDocu", NroDocu);
                cmd.Parameters.AddWithValue("@obra", obraSocial);
                cmd.Parameters.AddWithValue("@nro", nroAfiliado);
                cmd.Parameters.AddWithValue("@grupo", grupoSan);
                

                cmd.Parameters.AddWithValue("@rubiol",rubeola);
                cmd.Parameters.AddWithValue("@oti", otitis);
                cmd.Parameters.AddWithValue("@var", varicela);
                cmd.Parameters.AddWithValue("@ang", anginas);
                cmd.Parameters.AddWithValue("@hep", hepatitis);

                cmd.Parameters.AddWithValue("@uri", urinaria);
                cmd.Parameters.AddWithValue("@dia", diabetes);
                cmd.Parameters.AddWithValue("@epi", epilepsia);
                cmd.Parameters.AddWithValue("@saram", sarampion);
                cmd.Parameters.AddWithValue("@bron", bronquitis);

                cmd.Parameters.AddWithValue("@gastr", gastroenteritis);
                cmd.Parameters.AddWithValue("@anti", antitetanica);
                cmd.Parameters.AddWithValue("@car", carnet);
                cmd.Parameters.AddWithValue("@aler", alergia);
                cmd.Parameters.AddWithValue("@celi", celiaquia);
                cmd.Parameters.AddWithValue("@convu", convulsiones);


                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                cn.Close();

                return true;

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

        public static bool InsertarPariente(int tipoDocumento, int nroDocu, string nombre, string apellido, string telefono, int compania, string gmail,int ocupacion,int pariente,string docMili, int TipoMili)
        {
            string cadena = "server=sql230.main-hosting.eu;user id=u348691639_BelenPenzo;password=15elamanecer15;database=u348691639_RucaChampaqui";
            MySqlConnection cn = new MySqlConnection(cadena);
            try
            {
                MySqlCommand cmd = new MySqlCommand();

                string consulta = "INSERT INTO pariente (tipoDocumento,nroDocumento,nombre,apellido, telefono,tipoCompania,tipoOcupacion,gmail,tipoPariente,tipoDocumentoMiliciano,nroDocumentoMiliciano)" +
                    " VALUES (@tipo,@nroDocu,@nombr,@apellid,@telef,@compa,@ocu,@gma,@pari,@tipoMili,@docMili);";

                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@tipo", tipoDocumento);
                cmd.Parameters.AddWithValue("@nroDocu", nroDocu);
                cmd.Parameters.AddWithValue("@nombr", nombre);
                cmd.Parameters.AddWithValue("@apellid", apellido);
                cmd.Parameters.AddWithValue("@telef", telefono);
                cmd.Parameters.AddWithValue("@compa", compania);
                cmd.Parameters.AddWithValue("@gma", gmail);
                cmd.Parameters.AddWithValue("@ocu", ocupacion);
                cmd.Parameters.AddWithValue("@pari", pariente);
                cmd.Parameters.AddWithValue("@tipoMili", TipoMili);
                cmd.Parameters.AddWithValue("@docMili", docMili);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                cn.Close();

                return true;

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

        public static bool modificarMiliciano(int tipoDocumento, int nroDocu, int agrupacion, string nombre, string apellido, string calle, string nroCalle, int idBarrio, int hobby, int colegio, string telefono, int compania, string gmail, int seccion, string nacimiento)
        {
            string cadena = "server=sql230.main-hosting.eu;user id=u348691639_BelenPenzo;password=15elamanecer15;database=u348691639_RucaChampaqui";
            MySqlConnection cn = new MySqlConnection(cadena);
            try
            {
                MySqlCommand cmd = new MySqlCommand();

                string consulta = "UPDATE miliciano SET apellido=@apellid,nombre=@nombr,calle=@cal,nroCalle=@nroCal,idBarrio=@idBar,idHobby=@hobby,idColegio=@coleg,telefono=@tele,tipoCompania=@compa,gmail=@gma,agrupacion=@agrup,tipoSeccion=@secci,fechaNacimiento=@nacimiento WHERE  nroDocumento=@nroDocu ";

                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@tipo", tipoDocumento);
                cmd.Parameters.AddWithValue("@nroDocu", nroDocu);
                cmd.Parameters.AddWithValue("@agrup", agrupacion);
                cmd.Parameters.AddWithValue("@nombr", nombre);
                cmd.Parameters.AddWithValue("@apellid", apellido);
                cmd.Parameters.AddWithValue("@cal", calle);
                cmd.Parameters.AddWithValue("@nroCal", nroCalle);
                cmd.Parameters.AddWithValue("@idBar", idBarrio);
                cmd.Parameters.AddWithValue("@hobby", hobby);
                cmd.Parameters.AddWithValue("@coleg", colegio);
                cmd.Parameters.AddWithValue("@tele", telefono);
                cmd.Parameters.AddWithValue("@compa", compania);
                cmd.Parameters.AddWithValue("@gma", gmail);
                cmd.Parameters.AddWithValue("@secci", seccion);
                cmd.Parameters.AddWithValue("@nacimiento", nacimiento);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                cn.Close();

                return true;

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

        public static bool modificarPariente(int tipoDocumento, int nroDocu, string nombre, string apellido, string telefono, int compania, string gmail, int ocupacion, int pariente)
        {
            string cadena = "server=sql230.main-hosting.eu;user id=u348691639_BelenPenzo;password=15elamanecer15;database=u348691639_RucaChampaqui";
            MySqlConnection cn = new MySqlConnection(cadena);
            try
            {
                MySqlCommand cmd = new MySqlCommand();

                string consulta = "UPDATE pariente SET  nombre=@nombr,apellido=@apellid,telefono=@telef, tipoCompania=@compa,tipoOcupacion=@ocupa, gmail=@gma , tipoPariente=@pari WHERE nroDocumentoMiliciano=@nroDocu ";

                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@tipo", tipoDocumento);
                cmd.Parameters.AddWithValue("@nroDocu", nroDocu);
                cmd.Parameters.AddWithValue("@ocupa",ocupacion);
                cmd.Parameters.AddWithValue("@nombr", nombre);
                cmd.Parameters.AddWithValue("@apellid", apellido);
                cmd.Parameters.AddWithValue("@telef", telefono);
                cmd.Parameters.AddWithValue("@compa", compania);
                cmd.Parameters.AddWithValue("@gma", gmail);
                cmd.Parameters.AddWithValue("@pari", pariente);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                cn.Close();

                return true;

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

        public static bool ActualizarFichaMedica(int TipoDocumento, int NroDocu, int obraSocial, string nroAfiliado, string grupoSan, string alergia, int anginas, int antitetanica, int epilepsia, int hepatitis, int convulsiones, int bronquitis, int carnet, int diabetes, int urinaria, int celiaquia, int gastroenteritis, int otitis, int rubeola, int sarampion, int varicela)
        {
            string cadena = "server=sql230.main-hosting.eu;user id=u348691639_BelenPenzo;password=15elamanecer15;database=u348691639_RucaChampaqui";
            MySqlConnection cn = new MySqlConnection(cadena);
            try
            {
                MySqlCommand cmd = new MySqlCommand();

                string consulta = "UPDATE fichaMedica SET obraSocial=@obra, nroAfiliado=@nro, " +
                    "grupoSanguineo=@grupo, rubeola=@rubiol, varicela=@var, otitis=@oti, anginas=@ang, " +
                    "hepatitis=@hep, urinaria=@uri, diabetes=@dia, epilepsia=@epi, " +
                    " sarampion=@saram, bronquitis=@bron, gastroenteritis=@gastr" +
                    ", antitetanica=@anti,vacunacionCompleto=@car, alergias=@aler, celiaquia=@celi, convulsion=@convu " +
                    "WHERE nroDocumento=@nroDocu AND tipoDocumento=@tipo;";

                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@tipo", TipoDocumento);
                cmd.Parameters.AddWithValue("@nroDocu", NroDocu);
                cmd.Parameters.AddWithValue("@obra", obraSocial);
                cmd.Parameters.AddWithValue("@nro", nroAfiliado);
                cmd.Parameters.AddWithValue("@grupo", grupoSan);


                cmd.Parameters.AddWithValue("@rubiol", rubeola);
                cmd.Parameters.AddWithValue("@oti", otitis);
                cmd.Parameters.AddWithValue("@var", varicela);
                cmd.Parameters.AddWithValue("@ang", anginas);
                cmd.Parameters.AddWithValue("@hep", hepatitis);

                cmd.Parameters.AddWithValue("@uri", urinaria);
                cmd.Parameters.AddWithValue("@dia", diabetes);
                cmd.Parameters.AddWithValue("@epi", epilepsia);
                cmd.Parameters.AddWithValue("@saram", sarampion);
                cmd.Parameters.AddWithValue("@bron", bronquitis);

                cmd.Parameters.AddWithValue("@gastr", gastroenteritis);
                cmd.Parameters.AddWithValue("@anti", antitetanica);
                cmd.Parameters.AddWithValue("@car", carnet);
                cmd.Parameters.AddWithValue("@aler", alergia);
                cmd.Parameters.AddWithValue("@celi", celiaquia);
                cmd.Parameters.AddWithValue("@convu", convulsiones);


                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                cn.Close();

                return true;

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


