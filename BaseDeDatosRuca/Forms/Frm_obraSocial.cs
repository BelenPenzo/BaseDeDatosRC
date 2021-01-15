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
    public partial class Frm_obraSocial : Form
    {
        public Frm_obraSocial()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void bt_confirmar_Click(object sender, EventArgs e)
        {
            string obraSocial = txt_obraSocial.Text;
            bool resultado = Clases.AcessosR.InsertarObraSocial(obraSocial);


            if (resultado == true)
            {
                MessageBox.Show("Se pudo guardar con exito");
                txt_obraSocial.Text = "";

            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void Frm_obraSocial_Load(object sender, EventArgs e)
        {

        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
