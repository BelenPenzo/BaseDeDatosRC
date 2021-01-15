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
    public partial class Frm_barrio : Form
    {
        public Frm_barrio()
        {
            InitializeComponent();
        }

        private void bt_confirmar_Click(object sender, EventArgs e)
        {
            string barrio = txt_barrio.Text;
            bool resultado = Clases.AcessosR.InsertarBarrio(barrio);


            if (resultado == true)
            {
                MessageBox.Show("Se pudo guardar con exito");
                txt_barrio.Text = "";

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
