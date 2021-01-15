using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaseDeDatosRuca;


namespace BaseDeDatosRuca.Forms
{
    public partial class Frm_miliciano : Form
    {

        
        public Frm_miliciano()
        {
            InitializeComponent();
        }

        private void Frm_miliciano_Load(object sender, EventArgs e)
        {
            txt_apellido.Enabled = false;
            txt_calle.Enabled = false;
            txt_gmail.Enabled = false;
            txt_nombre.Enabled = false;
            txt_nro.Enabled = false;
            txt_telefono.Enabled = false;
            cmb_agrupacion.Visible = false;
            cmb_barrio.Visible = false;
            cmb_agrupacion.Visible = false;
            cmb_barrio.Visible = false;
            cmb_colegio.Visible = false;
            cmb_compania.Visible = false;
            cmb_hobby.Visible = false;
            cmb_seccion.Visible = false;
            dateTimePicker1.Enabled = false;



            CargarAgrupaciones(ref cmb_agrupacion,"tipoAgrupacion","nombre");
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

        public void CargarSeccion(ref ComboBox cmb_seccion, string nombre, string seccion,int agru)
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

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void cmb_agrupacion_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_compañia_TextChanged(object sender, EventArgs e)
        {

        }

        private void bttt_confirmar_Click(object sender, EventArgs e)
        {
            if (cmb_tipoDoc.SelectedIndex == -1 || txt_documento.Text == "" || cmb_agrupacion.SelectedIndex == -1 || txt_nombre.Text == "" || txt_apellido.Text == "" || txt_calle.Text == "" || txt_nro.Text == "" || cmb_barrio.SelectedIndex == -1 || cmb_hobby.SelectedIndex == -1 || cmb_colegio.SelectedIndex == -1 || txt_telefono.Text == "" || cmb_compania.SelectedIndex == -1 || txt_gmail.Text == "" || cmb_seccion.SelectedIndex == -1 || dateTimePicker1.Value.Date > DateTime.Now)
            {
                MessageBox.Show("Falta completar campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmb_tipoDoc.Focus();
            }
            else {
                int tipoDocumento = int.Parse(cmb_tipoDoc.SelectedValue.ToString());
                int nroDocu = int.Parse(txt_documento.Text);
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



                bool resultado = Clases.AcessosR.InsertarMiliciano(tipoDocumento, nroDocu, agrupacion, nombre, apellido, calle, nroCalle, idBarrio, hobby, colegio, telefono, compania, gmail, seccion, nacimiento);


                if (resultado == true)
                {
                    MessageBox.Show("Se pudo guardar el miliciano");
                    cmb_tipoDoc.SelectedIndex = -1;
                    cmb_agrupacion.SelectedIndex = -1;
                    txt_documento.Text = "";
                    txt_nombre.Text = "";
                    txt_apellido.Text = "";
                    txt_calle.Text = "";
                    txt_nro.Text = "";
                    cmb_barrio.SelectedIndex = -1;
                    cmb_hobby.SelectedIndex = -1;
                    cmb_colegio.SelectedIndex = -1;
                    txt_telefono.Text = "";
                    cmb_compania.SelectedIndex = -1;
                    txt_gmail.Text = "";
                    cmb_seccion.SelectedIndex = -1;

                }
                else
                {
                    MessageBox.Show("Error");
                }

            }
        }
        
        
        private void cmb_seccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void bt_seccion_Click(object sender, EventArgs e)
        {
            
            CargarSeccion(ref cmb_seccion, "nombre", "tipoSeccion",int.Parse(cmb_agrupacion.SelectedIndex.ToString()));
        }

        private void cmb_compania_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_documento_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btt_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_documento.Text == "" || cmb_tipoDoc.SelectedIndex == -1)
            {
                MessageBox.Show("Falta completar campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_documento.Focus();
            }

        
        else
        {
               
                int documento = int.Parse(txt_documento.Text);
                int tipoDocumento = int.Parse(cmb_tipoDoc.SelectedValue.ToString());
                DataTable tabla1 = new DataTable();
            tabla1 = Clases.AcessosB.ObtenerMilicianoDocumento(tipoDocumento,documento);

            if (tabla1.Rows.Count != 0)
            {
                txt_documento.Text = "";

                MessageBox.Show("Ya se encuentra registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_documento.Focus();
                
                cmb_tipoDoc.SelectedIndex = -1;
                
                txt_documento.Text = "";
                
                cmb_tipoDoc.Focus();
            }

                else
                {
                    txt_apellido.Enabled = true;
                    txt_calle.Enabled = true;
                    txt_gmail.Enabled = true;
                    txt_nombre.Enabled = true;
                    txt_nro.Enabled = true;
                    txt_telefono.Enabled = true;
                    cmb_agrupacion.Visible = true;
                    cmb_barrio.Visible = true;
                    cmb_agrupacion.Visible = true;
                    cmb_barrio.Visible = true;
                    cmb_colegio.Visible = true;
                    cmb_compania.Visible = true;
                    cmb_hobby.Visible = true;
                    cmb_seccion.Visible = true;
                    dateTimePicker1.Enabled = true;
                }
        }
}
    }
}

