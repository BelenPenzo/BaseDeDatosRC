using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaseDeDatosRuca.Forms;

namespace BaseDeDatosRuca.Forms
{
    public partial class Form_Menu : Form
    {
        public Form_Menu()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form_Menu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Frm_miliciano nuevo_miliciano = new Frm_miliciano();
            nuevo_miliciano.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Frm_modificarMiliciano buscarM = new Frm_modificarMiliciano();
            buscarM.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Frm_opcionesBuscarMiliciano buscar = new Frm_opcionesBuscarMiliciano();
            buscar.ShowDialog();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Frm_opcionesAdministracion administracion = new Frm_opcionesAdministracion();
            administracion.ShowDialog();
            
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Frm_opcionesFichaMedica ficha= new Frm_opcionesFichaMedica();
            ficha.ShowDialog();

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Frm_buscarPariente parienteB = new Frm_buscarPariente();
            parienteB.ShowDialog();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Frm_registrarPariente pariente = new Frm_registrarPariente();
            pariente.ShowDialog();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Frm_modificarPariente parienteM = new Frm_modificarPariente();
            parienteM.ShowDialog();
        }

        
    }
}
