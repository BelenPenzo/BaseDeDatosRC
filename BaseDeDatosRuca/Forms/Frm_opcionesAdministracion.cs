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
    public partial class Frm_opcionesAdministracion : Form
    {
        public Frm_opcionesAdministracion()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Frm_pagoCuota  pago = new Frm_pagoCuota();
            pago.ShowDialog();
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Frm_barrio barrio = new Frm_barrio();
            barrio.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Frm_colegio colegio = new Frm_colegio();
            colegio.ShowDialog();
            
        }

        private void Frm_opcionesAdministracion_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Frm_compania compania = new Frm_compania();
            compania.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Frm_hobby hobby = new Frm_hobby();
            hobby.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Frm_ocupacion ocupacion = new Frm_ocupacion();
            ocupacion.ShowDialog();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Frm_obraSocial social = new Frm_obraSocial();
            social.ShowDialog();
        }
    }
}
