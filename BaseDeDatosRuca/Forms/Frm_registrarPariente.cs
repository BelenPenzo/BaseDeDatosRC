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
    public partial class Frm_registrarPariente : Form
    {
        public Frm_registrarPariente()
        {
            InitializeComponent();
        }

        private void Frm_registrarPariente_Load(object sender, EventArgs e)
        {

            CargarTipoDoc(ref cmb_tipoDocMili, "tipoDocumento", "nombre");
            cmb_tipoDoc.SelectedIndex = -1;
            txt_documento.Enabled = false;
            txt_apellido.Enabled = false;
            txt_gmail.Enabled = false;
            txt_nombre.Enabled = false;
            txt_nombre.Enabled = false;
            txt_telefono.Enabled = false;
            cmb_tipoDoc.Visible = false;
            cmb_parentesco.Visible = false;
            cmb_ocupacion.Visible = false;
            cmb_compania.Visible = false;

            CargarOcupacion(ref cmb_ocupacion, "tipoOcupacion", "nombre"); 
            CargarCompania(ref cmb_compania, "tipoCompania", "nombre");
            CargarTipoDoc(ref cmb_tipoDoc, "tipoDocumento", "nombre");
            CargarPariente(ref cmb_parentesco, "tipoPariente", "nombre");
            cmb_parentesco.SelectedIndex = -1;
            cmb_tipoDoc.SelectedIndex = -1;
            cmb_compania.SelectedIndex = -1;
            cmb_ocupacion.SelectedIndex = -1;          
        }
        public void CargarTipoDoc(ref ComboBox cmb_tipoDoc, string tipoDocumento, string nombre)
        {

            cmb_tipoDoc.DataSource = Clases.AccesosV.llenarComboTipoDoc();
            cmb_tipoDoc.DisplayMember = nombre;
            cmb_tipoDoc.ValueMember = tipoDocumento;
            cmb_tipoDoc.SelectedIndex = -1;

        }
       

        public void CargarPariente(ref ComboBox cmb_parentesco, string tipoPariente, string nombre)
        {

            cmb_parentesco.DataSource = Clases.AccesosV.llenarComboPariente();
            cmb_parentesco.DisplayMember = nombre;
            cmb_parentesco.ValueMember = tipoPariente;
            cmb_parentesco.SelectedIndex = -1;

        }

        public void CargarCompania(ref ComboBox cmb_compania, string tipoCompania, string nombre)
        {
            cmb_compania.Items.Clear();
            cmb_compania.DataSource = Clases.AccesosV.llenarComboCompania();
            cmb_compania.DisplayMember = nombre;
            cmb_compania.ValueMember = tipoCompania;

        }

        public void CargarOcupacion(ref ComboBox cmb_ocupacion, string tipoOcupacion, string nombre)
        {
            cmb_ocupacion.Items.Clear();
            cmb_ocupacion.DataSource = Clases.AccesosV.llenarComboOcupacion();
            cmb_ocupacion.DisplayMember = nombre;
            cmb_ocupacion.ValueMember = tipoOcupacion;

        }

        private void bttt_confirmar_Click(object sender, EventArgs e)
        {
            

            if (cmb_tipoDoc.SelectedIndex == -1 || txt_documento.Text == "" || cmb_ocupacion.SelectedIndex == -1 || txt_nombre.Text == "" || txt_apellido.Text == "" || txt_telefono.Text == "" || cmb_compania.SelectedIndex == -1 || txt_gmail.Text == "" )
            {
                MessageBox.Show("Falta completar campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmb_tipoDoc.Focus();
            }
            else
            {
                int tipoDocumento = int.Parse(cmb_tipoDoc.SelectedValue.ToString());
                int nroDocu = int.Parse(txt_documento.Text);
                    string nombre = txt_nombre.Text;
                    string apellido = txt_apellido.Text;
                    string telefono = txt_telefono.Text;
                    int compania = int.Parse(cmb_compania.SelectedValue.ToString());
                    string gmail = txt_gmail.Text;
                    int ocupacion = int.Parse(cmb_ocupacion.SelectedValue.ToString());
                    int pariente = int.Parse(cmb_parentesco.SelectedValue.ToString());
                    string docMili = txt_numeroMili.Text;
                    int tipoMili = int.Parse(cmb_tipoDocMili.SelectedValue.ToString());

                    bool resultado = Clases.AcessosR.InsertarPariente(tipoDocumento, nroDocu, nombre, apellido,telefono, compania, gmail,ocupacion, pariente,docMili,tipoMili);


                    if (resultado == true)
                    {
                        MessageBox.Show("Se pudo guardar con exito");
                        cmb_tipoDoc.SelectedIndex = -1;
                        txt_documento.Text = "";
                        txt_nombre.Text = "";
                        txt_apellido.Text = "";
                        txt_telefono.Text = "";
                        txt_gmail.Text = "";
                        cmb_compania.SelectedIndex = -1;
                        cmb_ocupacion.SelectedIndex = -1;
                        cmb_parentesco.SelectedIndex = -1;
                        txt_numeroMili.Text = "";
                        cmb_tipoDocMili.SelectedIndex = -1;
                    }
                    else
                    {
                        MessageBox.Show("Error");
                        cmb_tipoDoc.SelectedIndex = -1;
                        txt_documento.Text = "";
                        txt_nombre.Text = "";
                        txt_apellido.Text = "";
                        txt_telefono.Text = "";
                        txt_gmail.Text = "";
                        cmb_compania.SelectedIndex = -1;
                        cmb_ocupacion.SelectedIndex = -1;
                        cmb_parentesco.SelectedIndex = -1;
                        txt_numeroMili.Text = "";
                        cmb_tipoDocMili.SelectedIndex = -1;
                    }

                }
            }
        

        private void btt_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmb_ocupacion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();


            if (txt_numeroMili.Text == "" || cmb_tipoDocMili.SelectedIndex == -1)
            {
                MessageBox.Show("Falta completar campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_documento.Focus();

            }
            else
            {

                int tipoDocumento = int.Parse(cmb_tipoDocMili.SelectedValue.ToString());
                int documento = int.Parse(txt_numeroMili.Text);


                tabla = Clases.AcessosB.ObtenerMilicianoDocumento(tipoDocumento, documento);

                if (tabla.Rows.Count == 0)
                {
                    txt_numeroMili.Text = "";
                    MessageBox.Show("No existe miliciano", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_numeroMili.Focus();
                }

                else
                {
                    DataTable tabla1 = new DataTable();
                    tabla1 = Clases.AcessosB.ObtenerParienteDocumentoMiliciano(tipoDocumento, documento);
                    if (tabla1.Rows.Count != 0)
                    {
                        txt_numeroMili.Text = "";
                        MessageBox.Show("Ya existe un pariente registado al Miliciano", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_numeroMili.Focus();
                    }
                    else { 
                    lbl_apellido.Text = tabla.Rows[0][2].ToString();
                    lbl_nombre.Text = tabla.Rows[0][3].ToString();
                    txt_documento.Enabled = true;
                    txt_apellido.Enabled = true;
                    txt_gmail.Enabled = true;
                    txt_nombre.Enabled = true;
                    txt_nombre.Enabled = true;
                    txt_telefono.Enabled = true;
                    cmb_tipoDoc.Visible = true;
                    cmb_parentesco.Visible = true;
                    cmb_ocupacion.Visible = true;
                    cmb_compania.Visible = true;
                    }
                }
            }
    }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}