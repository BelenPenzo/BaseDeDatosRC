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
    public partial class Frm_opcionesFichaMedica : Form
    {
        public Frm_opcionesFichaMedica()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Frm_modificarFichaMedica ficham = new Frm_modificarFichaMedica();
            ficham.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Frm_fichaMedica ficha = new Frm_fichaMedica();
            ficha.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Frm_buscarFichaMedica fichab = new Frm_buscarFichaMedica();
            fichab.ShowDialog();
        }
    }
}
