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
    public partial class Frm_buscarFichaMedica : Form
    {
        public Frm_buscarFichaMedica()
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

         
                tabla = Clases.AcessosB.ObtenerMilicianoDocumento(tipoDocumento, documento);

                if (tabla.Rows.Count == 0)
                {
                    txt_documento.Text = "";
                    MessageBox.Show("No existe el miliciano", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_documento.Focus();
                }

                if (tabla1.Rows.Count == 0)
                {
                    txt_documento.Text = "";
                    MessageBox.Show("No existe la ficha medica", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_documento.Focus();
                }

                else
                {
                    lbl_apellido.Text = tabla.Rows[0][2].ToString();    
                    lbl_nombre.Text = tabla.Rows[0][3].ToString();
                    int obra = int.Parse(tabla1.Rows[0][2].ToString());
                    lbl_obraSocial.Text = Clases.AcessosB.DevolverObraSocial(obra);
                    lbl_nroAfiliado.Text = tabla1.Rows[0][3].ToString();
                    lbl_grupoSanguineo.Text = tabla1.Rows[0][4].ToString();
                    lbl_alergia.Text = tabla1.Rows[0][18].ToString();


                    bool rubeola =bool.Parse(tabla1.Rows[0][5].ToString());
                    lbl_rubeola.Text = Clases.AcessosB.DevolverValorFicha(rubeola);

                    bool varicela = bool.Parse(tabla1.Rows[0][6].ToString());
                    lbl_varicela.Text = Clases.AcessosB.DevolverValorFicha(varicela);

                    bool otitis = bool.Parse(tabla1.Rows[0][7].ToString());
                    lbl_otitis.Text = Clases.AcessosB.DevolverValorFicha(otitis);

                    bool anginas = bool.Parse(tabla1.Rows[0][8].ToString());
                    lbl_anginas.Text = Clases.AcessosB.DevolverValorFicha(anginas);

                    bool hepatitis = bool.Parse(tabla1.Rows[0][9].ToString());
                    lbl_hrpatitis.Text = Clases.AcessosB.DevolverValorFicha(hepatitis);

                    bool urinaria = bool.Parse(tabla1.Rows[0][10].ToString());
                    lbl_urinaria.Text = Clases.AcessosB.DevolverValorFicha(urinaria);

                    bool diabetes = bool.Parse(tabla1.Rows[0][11].ToString());
                    lbl_diabetes.Text = Clases.AcessosB.DevolverValorFicha(diabetes);

                    bool epilepsia = bool.Parse(tabla1.Rows[0][12].ToString());
                    lbl_epilepsia.Text = Clases.AcessosB.DevolverValorFicha(epilepsia);

                    bool sarampion = bool.Parse(tabla1.Rows[0][13].ToString());
                    lbl_sarampion.Text = Clases.AcessosB.DevolverValorFicha(sarampion);

                    bool bronquitis = bool.Parse(tabla1.Rows[0][14].ToString());
                    lbl_bronquitis.Text = Clases.AcessosB.DevolverValorFicha(bronquitis);

                    bool gastroenteritis = bool.Parse(tabla1.Rows[0][15].ToString());
                    lbl_gastroenteritis.Text = Clases.AcessosB.DevolverValorFicha(gastroenteritis);

                    bool antitetanica = bool.Parse(tabla1.Rows[0][16].ToString());
                    lbl_antitetanica.Text = Clases.AcessosB.DevolverValorFicha(antitetanica);

                    bool completa = bool.Parse(tabla1.Rows[0][17].ToString());
                    lbl_completa.Text = Clases.AcessosB.DevolverValorFicha(completa);

                    bool celiaquia = bool.Parse(tabla1.Rows[0][19].ToString());
                    lbl_celiaquia.Text = Clases.AcessosB.DevolverValorFicha(celiaquia);

                    bool convulsiones= bool.Parse(tabla1.Rows[0][20].ToString());
                    lbl_convulsiones.Text = Clases.AcessosB.DevolverValorFicha(convulsiones);
                }
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void Frm_buscarFichaMedica_Load(object sender, EventArgs e)
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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btt_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
