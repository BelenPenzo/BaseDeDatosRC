using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace BaseDeDatosRuca.Reportes
{
    public partial class Frm_RHobby : Form
    {
        public Frm_RHobby()
        {
            InitializeComponent();
        }

        private void Frm_RHobby_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'RucaChampaquiDataSet.MilicianosHobby' Puede moverla o quitarla según sea necesario.
            //this.MilicianosHobbyTableAdapter.Fill(this.RucaChampaquiDataSet.MilicianosHobby);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.Clear();
            CargarHobby(ref cmb_hobby, "tipoHobby", "nombre");
            cmb_hobby.SelectedIndex = -1;
        }

        public void CargarHobby(ref ComboBox cmb_hobby, string tipoHobby, string nombre)
        {
            cmb_hobby.Items.Clear();
            cmb_hobby.DataSource = Clases.AccesosV.llenarComboHobby();
            cmb_hobby.DisplayMember = nombre;
            cmb_hobby.ValueMember = tipoHobby;

        }

        private void bt_buscar_Click(object sender, EventArgs e)
        {
            if ( cmb_hobby.SelectedIndex == -1)
            {
                MessageBox.Show("Falta completar campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmb_hobby.Focus();
            }

           else
                {

            RucaChampaquiDataSetTableAdapters.MilicianosHobbyTableAdapter adapter = new RucaChampaquiDataSetTableAdapters.MilicianosHobbyTableAdapter();
            RucaChampaquiDataSet.MilicianosHobbyDataTable tabla = new RucaChampaquiDataSet.MilicianosHobbyDataTable();

            adapter.FillBy(tabla, int.Parse(cmb_hobby.SelectedValue.ToString()));

            ReportDataSource reportDataSource = new ReportDataSource("HobbyMilicianos", (DataTable)tabla);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        
                }
    
            }

        }
    }
