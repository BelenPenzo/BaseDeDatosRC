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
    public partial class Frm_hobby : Form
    {
        public Frm_hobby()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Frm_hobby_Load(object sender, EventArgs e)
        {

        }

        private void bt_confirmar_Click(object sender, EventArgs e)
        {
            string hobby = txt_hobby.Text;
            bool resultado = Clases.AcessosR.InsertarHobby(hobby);


            if (resultado == true)
            {
                MessageBox.Show("Se pudo guardar con exito");
                txt_hobby.Text = "";

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
