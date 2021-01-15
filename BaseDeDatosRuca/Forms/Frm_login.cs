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
    public partial class Frm_login : Form
    {
        public Frm_login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_usuario.Text == "" || txt_contraseña.Text == "" )
            {
                MessageBox.Show("Falta completar campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_usuario.Focus();
            }
            else
            {
                DataTable tabla = new DataTable();
            string contraseña= txt_contraseña.Text;
            string nombre = txt_usuario.Text;
            tabla = Clases.AccesosV.DevolverContraseña(contraseña,nombre);

            if (tabla.Rows.Count == 0)
            {
                MessageBox.Show("No existe el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_contraseña.Text = "";
                    txt_usuario.Text = "";
                    txt_usuario.Focus();
            }

            else
            {
                Form_Menu menu = new Form_Menu();
                menu.ShowDialog();
                this.Close();

            }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Frm_login_Load(object sender, EventArgs e)
        {

        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
