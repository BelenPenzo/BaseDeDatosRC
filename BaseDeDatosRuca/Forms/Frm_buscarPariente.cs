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
    public partial class Frm_buscarPariente : Form
    {
        public Frm_buscarPariente()
        {
            InitializeComponent();
        }

        private void Frm_buscarPariente_Load(object sender, EventArgs e)
        {
            CargarTipoDoc(ref cmb_tipoDoc, "tipoDocumento", "nombre");
            cmb_tipoDoc.SelectedIndex = -1;
        }

        public void CargarTipoDoc(ref ComboBox cmb_tipoDoc, string tipoDocumento, string nombre)
        {

            cmb_tipoDoc.DataSource = Clases.AccesosV.llenarComboTipoDoc();
            cmb_tipoDoc.DisplayMember = nombre;
            cmb_tipoDoc.ValueMember = tipoDocumento;
            cmb_tipoDoc.SelectedIndex = -1;

        }

        private void bttt_confirmar_Click(object sender, EventArgs e)
        {

            if (txt_documento.Text == "" || cmb_tipoDoc.SelectedIndex == -1)
            {
                MessageBox.Show("Falta completar campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmb_tipoDoc.Focus();
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

                lbl_apellido.Text = tabla1.Rows[0][5].ToString();
                lbl_nombre.Text = tabla1.Rows[0][4].ToString();
                lbl_telefono.Text = tabla1.Rows[0][6].ToString();
                lbl_gmail.Text = tabla1.Rows[0][9].ToString();
                int numeroCompania = int.Parse(tabla1.Rows[0][7].ToString());
                lbl_compania.Text = Clases.AcessosB.DevolverCompania(numeroCompania);
                int numeroOcupacion = int.Parse(tabla1.Rows[0][8].ToString());
                lbl_ocupacion.Text = Clases.AcessosB.DevolverOcupacion(numeroOcupacion);
                int pariente = int.Parse(tabla1.Rows[0][10].ToString());
                lbl_pariente.Text = Clases.AcessosB.DevolverPariente(pariente);
                cmb_tipoDoc.SelectedIndex = -1;
                txt_documento.Text = "";
            }
            }

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btt_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
