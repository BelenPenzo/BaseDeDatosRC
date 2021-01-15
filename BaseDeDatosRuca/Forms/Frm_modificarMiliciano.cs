using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseDeDatosRuca.Forms
{
    public partial class Frm_modificarMiliciano : Form
    {
        public Frm_modificarMiliciano()
        {
            InitializeComponent();
        }

        private void Frm_modificarMiliciano_Load(object sender, EventArgs e)
        {
            CargarAgrupaciones(ref cmb_agrupacion, "tipoAgrupacion", "nombre");
            CargarBarrio(ref cmb_barrio, "tipoBarrio", "nombre");
            CargarHobby(ref cmb_hobby, "tipoHobby", "nombre");
            CargarColegio(ref cmb_colegio, "tipoColegio", "nombre");
            CargarCompania(ref cmb_compania, "tipoCompania", "nombre");
            CargarTipoDoc(ref cmb_tipoDoc, "tipoDocumento", "nombre");
            cmb_tipoDoc.SelectedIndex = -1;
            cmb_compania.SelectedIndex = -1;
            cmb_colegio.SelectedIndex = -1;
            cmb_agrupacion.SelectedIndex = -1;
            cmb_seccion.SelectedIndex = -1;
            cmb_barrio.SelectedIndex = -1;
            cmb_hobby.SelectedIndex = -1;
        }

        public void CargarAgrupaciones(ref ComboBox cmb_agrupacion, string tipoAgrupacion, string nombre)
        {
            cmb_agrupacion.Items.Clear();
            cmb_agrupacion.DataSource = Clases.AccesosV.llenarComboAgrupacion();
            cmb_agrupacion.DisplayMember = nombre;
            cmb_agrupacion.ValueMember = tipoAgrupacion;

        }

        public void CargarSeccion(ref ComboBox cmb_seccion, string nombre, string seccion, int agru)
        {

            cmb_seccion.DataSource = Clases.AccesosV.llenarComboSeccion(agru);
            cmb_seccion.DisplayMember = nombre;
            cmb_seccion.ValueMember = seccion;
            cmb_seccion.SelectedIndex = -1;

        }

        public void CargarBarrio(ref ComboBox cmb_barrio, string tipoBarrio, string nombre)
        {
            cmb_barrio.Items.Clear();
            cmb_barrio.DataSource = Clases.AccesosV.llenarComboBarrio();
            cmb_barrio.DisplayMember = nombre;
            cmb_barrio.ValueMember = tipoBarrio;

        }

        public void CargarTipoDoc(ref ComboBox cmb_tipoDoc, string tipoDocumento, string nombre)
        {

            cmb_tipoDoc.DataSource = Clases.AccesosV.llenarComboTipoDoc();
            cmb_tipoDoc.DisplayMember = nombre;
            cmb_tipoDoc.ValueMember = tipoDocumento;
            cmb_tipoDoc.SelectedIndex = -1;

        }

        public void CargarHobby(ref ComboBox cmb_hobby, string tipoHobby, string nombre)
        {
            cmb_hobby.Items.Clear();
            cmb_hobby.DataSource = Clases.AccesosV.llenarComboHobby();
            cmb_hobby.DisplayMember = nombre;
            cmb_hobby.ValueMember = tipoHobby;

        }

        public void CargarColegio(ref ComboBox cmb_colegio, string tipoColegio, string nombre)
        {
            cmb_colegio.Items.Clear();
            cmb_colegio.DataSource = Clases.AccesosV.llenarComboColegio();
            cmb_colegio.DisplayMember = nombre;
            cmb_colegio.ValueMember = tipoColegio;

        }

        public void CargarCompania(ref ComboBox cmb_compania, string tipoCompania, string nombre)
        {
            cmb_compania.Items.Clear();
            cmb_compania.DataSource = Clases.AccesosV.llenarComboCompania();
            cmb_compania.DisplayMember = nombre;
            cmb_compania.ValueMember = tipoCompania;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tipoDocumento = int.Parse(cmb_tipoDoc.SelectedValue.ToString());
            int nroDocu = int.Parse(txt_documento.Text);
            if (cmb_tipoDoc.SelectedIndex == -1 || txt_documento.Text == "" || cmb_seccion.SelectedIndex == -1 )
            {
                MessageBox.Show("Falta completar campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmb_tipoDoc.Focus();
            }
            else
            {
                int agrupacion = int.Parse(cmb_agrupacion.SelectedValue.ToString());
                string nombre = txt_nombre.Text;
                string apellido = txt_apellido.Text;
                string calle = txt_calle.Text;
                string nroCalle = txt_nro.Text;
                int idBarrio = int.Parse(cmb_barrio.SelectedValue.ToString());
                int hobby = int.Parse(cmb_hobby.SelectedValue.ToString());
                int colegio = int.Parse(cmb_colegio.SelectedValue.ToString());
                string telefono = txt_telefono.Text;
                int compania = int.Parse(cmb_compania.SelectedValue.ToString());
                string gmail = txt_gmail.Text;
                int seccion = int.Parse(cmb_seccion.SelectedValue.ToString());
                String nacimiento = Clases.AccesosV.formato_fecha(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day);


                bool resultado = Clases.AcessosR.modificarMiliciano(tipoDocumento, nroDocu, agrupacion, nombre, apellido, calle, nroCalle, idBarrio, hobby, colegio, telefono, compania, gmail, seccion, nacimiento);


                    if (resultado == true)
                    {
                        MessageBox.Show("Se pudo guardar el miliciano");
                    cmb_agrupacion.SelectedIndex = -1;
                    cmb_barrio.SelectedIndex = -1;
                    cmb_colegio.SelectedIndex = -1;
                    cmb_compania.SelectedIndex = -1;
                    cmb_hobby.SelectedIndex = -1;
                    cmb_seccion.SelectedIndex = -1;
                    cmb_tipoDoc.SelectedIndex = -1;
                    txt_apellido.Text = "";
                    txt_calle.Text = "";
                    txt_documento.Text = "";
                    txt_gmail.Text = "";
                    txt_nombre.Text = "";
                    txt_nro.Text = "";
                    txt_telefono.Text = "";
                    cmb_tipoDoc.Focus();
                      
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }

                }
        }


        private void bttt_confirmar_Click(object sender, EventArgs e)
        {
            if (txt_documento.Text == "" || cmb_tipoDoc.SelectedIndex == -1)
            {
                MessageBox.Show("Falta completar campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_documento.Focus();
            }

            int documento = int.Parse(txt_documento.Text);
            int tipoDocumento = int.Parse(cmb_tipoDoc.SelectedValue.ToString());
            DataTable tabla = new DataTable();
            tabla = Clases.AcessosB.ObtenerMilicianoDocumento(tipoDocumento, documento);
            if (tabla.Rows.Count == 0)
            {
                txt_documento.Text = "";
                MessageBox.Show("No existe miliciano", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_documento.Focus();
            }

            else
            {
                txt_apellido.Text = tabla.Rows[0][2].ToString();
                txt_nombre.Text = tabla.Rows[0][3].ToString();
                txt_calle.Text = tabla.Rows[0][4].ToString();
                txt_nro.Text = tabla.Rows[0][5].ToString();
                txt_telefono.Text = tabla.Rows[0][9].ToString();
                txt_gmail.Text = tabla.Rows[0][11].ToString();
                int numeroBarrio = int.Parse(tabla.Rows[0][6].ToString());
                cmb_barrio.Text = Clases.AcessosB.DevolverBarrio(numeroBarrio);
                int numeroHobby = int.Parse(tabla.Rows[0][7].ToString());
                cmb_hobby.Text = Clases.AcessosB.DevolverHobby(numeroHobby);
                int numeroColegio = int.Parse(tabla.Rows[0][8].ToString());
                cmb_colegio.Text = Clases.AcessosB.DevolverColegio(numeroColegio);
                int numeroCompania = int.Parse(tabla.Rows[0][10].ToString());
                cmb_compania.Text = Clases.AcessosB.DevolverCompania(numeroCompania);
                int numeroAgrupacion = int.Parse(tabla.Rows[0][12].ToString());
                cmb_agrupacion.Text = Clases.AcessosB.DevolverAgrupacion(numeroAgrupacion);
                //int numeroSeccion = int.Parse(tabla.Rows[0][13].ToString());
                //cmb_seccion.Text = Clases.AcessosB.DevolverSeccion(numeroSeccion);
                dateTimePicker1.Value = DateTime.Parse(tabla.Rows[0][14].ToString());
               

            }
        }

        private void bt_seccion_Click(object sender, EventArgs e)
        {
            CargarSeccion(ref cmb_seccion, "nombre", "tipoSeccion", int.Parse(cmb_agrupacion.SelectedIndex.ToString()));
        }

        private void btt_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}





