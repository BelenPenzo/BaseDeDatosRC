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
    public partial class Frm_pagoCuota : Form
    {
        public Frm_pagoCuota()
        {
            InitializeComponent();
        }

        private void bttt_confirmar_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            DataTable tabla2 = new DataTable();
            bool primeraCarga = false;

            if (txt_documento.Text == "" || cmb_tipoDoc.SelectedIndex == -1)
            {
                MessageBox.Show("Falta completar campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmb_tipoDoc.Focus();

            }
         else
            {
            int documento = int.Parse(txt_documento.Text);
            int tipoDocumento = int.Parse(cmb_tipoDoc.SelectedValue.ToString());
            
            
            
            tabla = Clases.AcessosB.ObtenerMilicianoDocumento(tipoDocumento, documento);
           
            tabla2 = Clases.AcessosB.ObtenerMilicianoCuota(tipoDocumento, documento);

           
            if (tabla.Rows.Count == 0)
            {
                txt_documento.Text = "";
                MessageBox.Show("No existe miliciano", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmb_tipoDoc.Focus();
                    ch_primera.Checked = false;
                    ch_Segunda.Checked = false;
                    lbl_apellido.Text = "";
                    lbl_nombre.Text = "";
                    txt_masInf.Text = "";
                    cmb_tipoDoc.SelectedIndex = -1;
                    txt_documento.Text = "";
                    msk_primera.Text = "";
                    msk_segunda.Text = "";
                    cmb_tipoDoc.Focus();
                }
            else
                {
                    lbl_apellido.Text = tabla.Rows[0][2].ToString();
                    lbl_nombre.Text = tabla.Rows[0][3].ToString();
                    
                }

                if (tabla2.Rows.Count == 0)
              {
                ch_primera.Focus();
                    
              }
            else
                {
                    txt_masInf.Text = tabla2.Rows[0][2].ToString();
                    msk_primera.Text = tabla2.Rows[0][3].ToString();
                    msk_segunda.Text = tabla2.Rows[0][4].ToString();
                    if (tabla2.Rows[0][0].ToString() == "False")
                {
                    ch_primera.Checked = false;  
                }
                if (tabla2.Rows[0][0].ToString() == "True")
                {
                    ch_primera.Checked = true;   
                }

                if(tabla2.Rows[0][1].ToString() == "False")
                {
                    ch_Segunda.Checked = false;
                    
                }
                if (tabla2.Rows[0][1].ToString() == "True")
                {
                    ch_Segunda.Checked = true;
                }

                
                }
         }
    }

        private void Frm_pagoCuota_Load(object sender, EventArgs e)
        {
           CargarTipoDoc(ref cmb_tipoDoc, "tipoDocumento", "nombre");
            cmb_tipoDoc.SelectedIndex = -1;
        }

        public void CargarTipoDoc(ref ComboBox cmb_tipoDoc, string tipoDocumento, string nombre)
        {

            cmb_tipoDoc.DataSource = Clases.AccesosV.llenarComboTipoDoc();
            cmb_tipoDoc.DisplayMember = nombre;
            cmb_tipoDoc.ValueMember = tipoDocumento;
            cmb_tipoDoc.SelectedIndex = -1;

        }

        private void bt_pago_Click(object sender, EventArgs e)
        {

            if (txt_documento.Text == "" || cmb_tipoDoc.SelectedIndex == -1)
            {
                MessageBox.Show("Falta completar campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmb_tipoDoc.Focus();

            }
            else
            {
                int tipoDocumento = int.Parse(cmb_tipoDoc.SelectedValue.ToString());
                int documento = int.Parse(txt_documento.Text);
                if (txt_documento.Text == "" || cmb_tipoDoc.SelectedIndex == -1)
                {
                    MessageBox.Show("Falta completar campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmb_tipoDoc.Focus();

                }
                else
                {
                    DataTable tabla2 = new DataTable();
                    tabla2 = Clases.AcessosB.ObtenerMilicianoCuota(tipoDocumento, documento);

                    if (tabla2.Rows.Count == 0)
                    {

                        MessageBox.Show("No existe el pago", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cmb_tipoDoc.Focus();
                        ch_primera.Checked = false;
                        ch_Segunda.Checked = false;
                        lbl_apellido.Text = "";
                        lbl_nombre.Text = "";
                        txt_masInf.Text = "";
                        cmb_tipoDoc.SelectedIndex = -1;
                        txt_documento.Text = "";
                        msk_primera.Text = "";
                        msk_segunda.Text = "";
                    }
                    else
                    {
                        string formas = txt_masInf.Text;

                        string fechaP = msk_primera.Text;
                        string fechaS = msk_segunda.Text;
                        int primera = -1;
                        int segunda = -1;
                        if (ch_primera.Checked.ToString() == "False")
                        {

                            primera = 0;
                        }
                        if (ch_primera.Checked.ToString() == "True")
                        {
                            primera = 1;
                        }
                        if (ch_Segunda.Checked.ToString() == "False")
                        {

                            segunda = 0;

                        }
                        if (ch_Segunda.Checked.ToString() == "True")
                        {
                            segunda = 1;
                        }


                        bool resultado = Clases.AcessosR.ActualizarCuota(tipoDocumento, documento, primera, segunda, formas, fechaP, fechaS);


                        if (resultado == true)
                        {
                            MessageBox.Show("Se pudo guardar el pago");
                            ch_primera.Checked = false;
                            ch_Segunda.Checked = false;
                            lbl_apellido.Text = "";
                            lbl_nombre.Text = "";
                            txt_masInf.Text = "";
                            cmb_tipoDoc.SelectedIndex = -1;
                            txt_documento.Text = "";
                            msk_primera.Text = "";
                            msk_segunda.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Error");

                        }

                    }

                }
            }
    }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btt_registrarPago_Click(object sender, EventArgs e)
        {
            if (txt_documento.Text == "" || cmb_tipoDoc.SelectedIndex == -1)
            {
                MessageBox.Show("Falta completar campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmb_tipoDoc.Focus();

            }
            else
            {
            DataTable tabla2 = new DataTable();
            int tipoDocumento = int.Parse(cmb_tipoDoc.SelectedValue.ToString());
            int documento = int.Parse(txt_documento.Text);
            string fechaP = msk_primera.Text;
            string fechaS = msk_segunda.Text;
            tabla2 = Clases.AcessosB.ObtenerMilicianoCuota(tipoDocumento, documento);

            if (tabla2.Rows.Count != 0)
            {
              
                MessageBox.Show("Ya existe el pago", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmb_tipoDoc.Focus();
                    ch_primera.Checked = false;
                    ch_Segunda.Checked = false;
                    lbl_apellido.Text = "";
                    lbl_nombre.Text = "";
                    txt_masInf.Text = "";
                    cmb_tipoDoc.SelectedIndex = -1;
                    txt_documento.Text = "";
                    msk_primera.Text = "";
                    msk_segunda.Text = "";
                    cmb_tipoDoc.Focus();
            }

            else
            {
            string formas = txt_masInf.Text;
            int primera = -1;
            int segunda = -1;
            if (ch_primera.Checked.ToString() == "False")
            {

                primera = 0;
            }
            if (ch_primera.Checked.ToString() == "True")
            {
                primera = 1;
            }

            if (ch_Segunda.Checked.ToString() == "False")
            {

                segunda = 0;

            }
            if (ch_Segunda.Checked.ToString() == "True")
            {
                segunda = 1;
            }


            bool resultado = Clases.AcessosR.InsertarCuota(tipoDocumento, documento, primera, segunda, formas, fechaP, fechaS);


            if (resultado == true)
            {
                MessageBox.Show("Se pudo guardar con exito");
                ch_primera.Checked = false;
                ch_Segunda.Checked = false;
                lbl_apellido.Text = "";
                lbl_nombre.Text = "";
                txt_masInf.Text = "";
                cmb_tipoDoc.SelectedIndex = -1;
                txt_documento.Text = "";
                msk_primera.Text = "";
                msk_segunda.Text = "";

                    }
            else
            {
                MessageBox.Show("Error");
            }

            }
        }
     }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txt_masInf_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btt_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
   
}
