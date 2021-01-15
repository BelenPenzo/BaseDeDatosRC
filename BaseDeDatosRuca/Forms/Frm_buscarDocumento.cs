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
    public partial class Frm_buscarDocumento : Form
    {
        public Frm_buscarDocumento()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Frm_buscarDocumento_Load(object sender, EventArgs e)
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
                txt_documento.Focus();
            }
            else
            {

                int documento = int.Parse(txt_documento.Text);
            int tipoDocumento = int.Parse(cmb_tipoDoc.SelectedValue.ToString());
            DataTable tabla = new DataTable();
            tabla = Clases.AcessosB.ObtenerMilicianoDocumento(tipoDocumento,documento);
            if (tabla.Rows.Count == 0 )
            {
                txt_documento.Text = "";
                MessageBox.Show("No existe miliciano", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_documento.Focus();
            }

            else
            {
                lbl_apellido.Text = tabla.Rows[0][2].ToString();
                lbl_nombre.Text = tabla.Rows[0][3].ToString();
                lbl_calle.Text = tabla.Rows[0][4].ToString();
                lbl_nro.Text = tabla.Rows[0][5].ToString();
                lbl_telefono.Text = tabla.Rows[0][9].ToString();
                lbl_gmail.Text = tabla.Rows[0][11].ToString();
                int numeroBarrio = int.Parse(tabla.Rows[0][6].ToString());
                lbl_barrio.Text = Clases.AcessosB.DevolverBarrio(numeroBarrio);
                int numeroHobby = int.Parse(tabla.Rows[0][7].ToString());
                lbl_hobby.Text = Clases.AcessosB.DevolverHobby(numeroHobby);
                int numeroColegio = int.Parse(tabla.Rows[0][8].ToString());
                lbl_colegio.Text = Clases.AcessosB.DevolverColegio(numeroColegio);
                int numeroCompania = int.Parse(tabla.Rows[0][10].ToString());
                lbl_compania.Text = Clases.AcessosB.DevolverCompania(numeroCompania);
                int numeroAgrupacion = int.Parse(tabla.Rows[0][12].ToString());
                lbl_agrupacion.Text = Clases.AcessosB.DevolverAgrupacion(numeroAgrupacion);
                int numeroSeccion = int.Parse(tabla.Rows[0][13].ToString());
                lbl_seccion.Text = Clases.AcessosB.DevolverSeccion(numeroSeccion);
                //String nacimiento = Clases.AccesosV.formato_fecha(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day);
                DateTime fecha = DateTime.Parse(tabla.Rows[0][14].ToString());
                String fecha1 = Clases.AccesosV.formato_fechaBuscar(fecha.Year,fecha.Month,fecha.Day);
                lbl_fecha.Text =fecha1;
            }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void btt_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
