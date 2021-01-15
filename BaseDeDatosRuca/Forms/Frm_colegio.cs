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
    public partial class Frm_colegio : Form
    {
        public Frm_colegio()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Frm_colegio_Load(object sender, EventArgs e)
        {

        }

        private void bt_confirmar_Click(object sender, EventArgs e)
        {
            string colegio = txt_colegio.Text;
            bool resultado = Clases.AcessosR.InsertarColegio(colegio);


            if (resultado == true)
            {
                MessageBox.Show("Se pudo guardar con exito");
                txt_colegio.Text = "";
                
            }
            else
            {
                MessageBox.Show("Error");
            }

        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
    

