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
    public partial class Frm_compania : Form
    {
        public Frm_compania()
        {
            InitializeComponent();
        }

        private void Frm_compania_Load(object sender, EventArgs e)
        {

        }

        private void bt_confirmar_Click(object sender, EventArgs e)
        {
            string compania = txt_compania.Text;
            bool resultado = Clases.AcessosR.InsertarCompania(compania);


            if (resultado == true)
            {
                MessageBox.Show("Se pudo guardar con exito");
                txt_compania.Text = "";

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
