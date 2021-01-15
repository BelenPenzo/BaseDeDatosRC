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
    public partial class Frm_ocupacion : Form
    {
        public Frm_ocupacion()
        {
            InitializeComponent();
        }

        private void bt_confirmar_Click(object sender, EventArgs e)
        {
            string ocupacion = txt_ocupacion.Text;
            bool resultado = Clases.AcessosR.InsertarOcupacion(ocupacion);


            if (resultado == true)
            {
                MessageBox.Show("Se pudo guardar con exito");
                txt_ocupacion.Text = "";

            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void Frm_ocupacion_Load(object sender, EventArgs e)
        {

        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
