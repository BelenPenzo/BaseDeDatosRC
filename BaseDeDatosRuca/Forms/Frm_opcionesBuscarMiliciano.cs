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
    public partial class Frm_opcionesBuscarMiliciano : Form
    {
        public Frm_opcionesBuscarMiliciano()
        {
            InitializeComponent();
        }

        private void Frm_opcionesBuscarMiliciano_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Reportes.FrmR_Colegio agru = new Reportes.FrmR_Colegio();
            agru.ShowDialog();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Frm_buscarDocumento documento = new Frm_buscarDocumento();
            documento.ShowDialog();
            
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Reportes.FrmR_agrupacion agru = new Reportes.FrmR_agrupacion();
            agru.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Reportes.Frm_RHobby hobby = new Reportes.Frm_RHobby();
            hobby.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Reportes.FrmR_Barrio barrio = new Reportes.FrmR_Barrio();
            barrio.ShowDialog();
        }
    }
}
