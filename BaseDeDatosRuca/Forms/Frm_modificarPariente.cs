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
    public partial class Frm_modificarPariente : Form
    {
        public Frm_modificarPariente()
        {
            InitializeComponent();
        }

        private void Frm_modificarPariente_Load(object sender, EventArgs e)
        {
            CargarOcupacion(ref cmb_ocupacion, "tipoOcupacion", "nombre");
            CargarCompania(ref cmb_compania, "tipoCompania", "nombre");
            CargarTipoDoc(ref cmb_tipoDoc, "tipoDocumento", "nombre");
            CargarPariente(ref cmb_parentesco, "tipoPariente", "nombre");
            cmb_parentesco.SelectedIndex = -1;
            cmb_tipoDoc.SelectedIndex = -1;
            cmb_compania.SelectedIndex = -1;
            cmb_ocupacion.SelectedIndex = -1;

            
            txt_apellido.Enabled = false;
            txt_gmail.Enabled = false;
            txt_nombre.Enabled = false;
            txt_nombre.Enabled = false;
            txt_telefono.Enabled = false;
            
            cmb_parentesco.Visible = false;
            cmb_ocupacion.Visible = false;
            cmb_compania.Visible = false;
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
                MessageBox.Show("No existe el miliciano", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_documento.Focus();
            }


            else
            {
                DataTable tabla1 = new DataTable();
                tabla1 = Clases.AcessosB.ObtenerParienteDocumentoMiliciano(tipoDocumento, documento);
                if (tabla1.Rows.Count == 0)
                {
                    txt_documento.Text = "";
                    MessageBox.Show("No existe un pariente registado al Miliciano", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmb_tipoDoc.Focus();
                }
                else
                {
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
                    txt_apellido.Text = tabla1.Rows[0][5].ToString();
                txt_nombre.Text = tabla1.Rows[0][4].ToString();
                txt_telefono.Text = tabla1.Rows[0][6].ToString();
                txt_gmail.Text = tabla1.Rows[0][9].ToString();
                int numeroCompania = int.Parse(tabla1.Rows[0][7].ToString());
                cmb_compania.Text = Clases.AcessosB.DevolverCompania(numeroCompania);
                int numeroOcupacion = int.Parse(tabla1.Rows[0][8].ToString());
                cmb_ocupacion.Text = Clases.AcessosB.DevolverOcupacion(numeroOcupacion);
                int pariente = int.Parse(tabla1.Rows[0][10].ToString());
                cmb_parentesco.Text = Clases.AcessosB.DevolverPariente(pariente);

            }
        }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (cmb_tipoDoc.SelectedIndex == -1 || txt_documento.Text == "")
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

              bool resultado = Clases.AcessosR.modificarPariente(tipoDocumento, nroDocu, nombre, apellido, telefono, compania, gmail,ocupacion,pariente);


               if (resultado == true)
               {
                   MessageBox.Show("Se pudo guardar el pariente");
                txt_nombre.Text = "";
                txt_nombre.Text = "";
                    txt_telefono.Text = "";
                txt_apellido.Text = "";
                cmb_compania.SelectedIndex = -1;
                txt_gmail.Text = "";
                cmb_ocupacion.SelectedIndex = -1;
                cmb_parentesco.SelectedIndex = -1;
                    cmb_tipoDoc.SelectedIndex = -1;
                    txt_documento.Text = "";
               }
               else
                {
                   MessageBox.Show("Error");
                }

                }
        }
        private void cmb_ocupacion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btt_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
        }
    
    

