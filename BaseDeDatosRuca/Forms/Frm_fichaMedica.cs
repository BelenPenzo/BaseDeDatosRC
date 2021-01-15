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
    public partial class Frm_fichaMedica : Form
    {
        public Frm_fichaMedica()
        {
            InitializeComponent();
        }

        private void bttt_confirmar_Click(object sender, EventArgs e)
        {
            
            DataTable tabla = new DataTable();
            

            if (txt_documento.Text == "" || cmb_tipoDoc.SelectedIndex == -1)
            {
                MessageBox.Show("Falta completar campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_documento.Focus();

            }
            else
            {
                DataTable tabla1 = new DataTable();
                int tipoDocumento = int.Parse(cmb_tipoDoc.SelectedValue.ToString());
                int documento = int.Parse(txt_documento.Text);
                tabla1 = Clases.AcessosB.ObtenerMilicianoFicha(tipoDocumento, documento);

                if (tabla1.Rows.Count != 0)
                {
                    txt_documento.Text = "";
                    MessageBox.Show("Ya existe la ficha medica", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_documento.Focus();
                }
                

                tabla = Clases.AcessosB.ObtenerMilicianoDocumento(tipoDocumento, documento);

                if (tabla.Rows.Count == 0)
                {
                    txt_documento.Text = "";
                    MessageBox.Show("No existe miliciano", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_documento.Focus();
                }

                else
                {
                lbl_apellido.Text = tabla.Rows[0][2].ToString();
                lbl_nombre.Text = tabla.Rows[0][3].ToString();
                }

            }
    }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Frm_fichaMedica_Load(object sender, EventArgs e)
        {

            CargarTipoDoc(ref cmb_tipoDoc, "tipoDocumento", "nombre");
            cmb_tipoDoc.SelectedIndex = -1;
            CargarObraSocial(ref cmb_obraSocial, "tipoObraSocial", "nombre");
            cmb_obraSocial.SelectedIndex = -1;
        }

        public void CargarTipoDoc(ref ComboBox cmb_tipoDoc, string tipoDocumento, string nombre)
        {

            cmb_tipoDoc.DataSource = Clases.AccesosV.llenarComboTipoDoc();
            cmb_tipoDoc.DisplayMember = nombre;
            cmb_tipoDoc.ValueMember = tipoDocumento;
            cmb_tipoDoc.SelectedIndex = -1;

        }

        public void CargarObraSocial(ref ComboBox cmb_obraSocial, string tipoObraSocial, string nombre)
        {

            cmb_obraSocial.DataSource = Clases.AccesosV.llenarComboObraSocial();
            cmb_obraSocial.DisplayMember = nombre;
            cmb_obraSocial.ValueMember = tipoObraSocial;
            cmb_obraSocial.SelectedIndex = -1;

        }

        private void bt_registrar_Click(object sender, EventArgs e)
        {

            int tipoDocumento = int.Parse(cmb_tipoDoc.SelectedValue.ToString());
            int documento = int.Parse(txt_documento.Text);
            string alergia = txt_alergia.Text;
                int ObraSocial = int.Parse(cmb_obraSocial.SelectedValue.ToString());
                string nro = txt_nro.Text.ToString();
                string grupoSan = txt_grupo.Text;
                int anginas = 0, antitetanica = 0, epilepsia = 0, hepatitis = 0, convulsiones = 0, bronquitis = 0,carnet = 0;
                if (che_anginas.Checked.ToString() == "True")
                {
                    
                    anginas = 1;
                }
               
                if (che_antitetanica.Checked.ToString() == "True")
                {
                    antitetanica = 1;
                }

                if ( ch_epilepsia.Checked.ToString() == "True")
                {

                    epilepsia = 1;
                }
                if (ch_hepatitis.Checked.ToString() == "True")
                {
                    hepatitis = 1;
                }

                if (ch_convulsiones.Checked.ToString() == "True")
                {

                    convulsiones = 1;

                }
                if (ch_bronquitis.Checked.ToString() == "True")
                {
                    bronquitis = 1;
                }

                if (ch_carnet.Checked.ToString() == "True")
                {
                    carnet = 1;
                }

                int diabetes =0, urinaria = 0, celiaquia = 0, gastroenteritis = 0, otitis = 0, rubeola = 0, sarampion = 0, varicela = 0;

                if (ch_diabetes.Checked.ToString() == "True")
                {

                    diabetes = 1;
                }

                if (ch_celiaquia.Checked.ToString() == "True")
                {
                    celiaquia = 1;
                }

                if (ch_urinaria.Checked.ToString() == "True")
                {

                    urinaria = 1;
                }
                if (ch_gastroenteritis.Checked.ToString() == "True")
                {
                    gastroenteritis = 1;
                }

                if (ch_otitis.Checked.ToString() == "True")
                {

                    otitis = 1;

                }
                if (ch_rubiola.Checked.ToString() == "True")
                {
                    rubeola = 1;
                }

                if (ch_sarampion.Checked.ToString() == "True")
                {

                    sarampion = 1;

                }
                if (ch_varicela.Checked.ToString() == "True")
                {
                    varicela = 1;
                }

               
                bool resultado = Clases.AcessosR.InsertarFichaMedica(tipoDocumento,documento,ObraSocial,nro,grupoSan, alergia, anginas, antitetanica, epilepsia, hepatitis, convulsiones, bronquitis, carnet, diabetes, urinaria, celiaquia, gastroenteritis, otitis, rubeola, sarampion, varicela);


                if (resultado == true)
                {
                    MessageBox.Show("Se pudo guardar el miliciano");
                cmb_tipoDoc.SelectedIndex = -1;
                txt_documento.Text = "";
                cmb_obraSocial.SelectedIndex = -1;
                txt_nro.Text = "";
                txt_grupo.Text = "";
                che_anginas.Checked = false;
                ch_bronquitis.Checked = false;
                ch_convulsiones.Checked = false;
                ch_diabetes.Checked = false;
                ch_urinaria.Checked = false;
                ch_epilepsia.Checked = false;
                ch_celiaquia.Checked = false;
                ch_gastroenteritis.Checked = false;
                ch_hepatitis.Checked = false;
                ch_otitis.Checked = false;
                ch_rubiola.Checked = false;
                ch_sarampion.Checked = false;
                ch_varicela.Checked = false;
                txt_alergia.Text = "";
                ch_carnet.Checked = false;
                che_antitetanica.Checked = false;

                }
                else
                {
                    MessageBox.Show("Error");
                }

            
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void btt_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_cancelar2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

