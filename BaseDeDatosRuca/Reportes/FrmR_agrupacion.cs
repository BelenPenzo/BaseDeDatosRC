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
    public partial class FrmR_agrupacion : Form
    {
        public FrmR_agrupacion()
        {
            InitializeComponent();
            
        }

        private void FrmR_agrupacion_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
            this.reportViewer1.Clear();
            CargarAgrupaciones(ref cmb_agrupacion, "tipoAgrupacion", "nombre");
            cmb_agrupacion.SelectedIndex = -1;
            
;           
            // TODO: esta línea de código carga datos en la tabla 'RucaChampaquiDataSet.MilicianoAgrupacion' Puede moverla o quitarla según sea necesario.
            //this.MilicianoAgrupacionTableAdapter.Fill(this.RucaChampaquiDataSet.MilicianoAgrupacion);

            
            
        }
        public void CargarAgrupaciones(ref ComboBox cmb_agrupacion, string tipoAgrupacion, string nombre)
        {
            cmb_agrupacion.Items.Clear();
            cmb_agrupacion.DataSource = Clases.AccesosV.llenarComboAgrupacion();
            cmb_agrupacion.DisplayMember = nombre;
            cmb_agrupacion.ValueMember = tipoAgrupacion;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void bt_buscar_Click(object sender, EventArgs e)
        {
            if (cmb_agrupacion.SelectedIndex == -1)
            {
                MessageBox.Show("Falta completar campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            else
            { 
            RucaChampaquiDataSetTableAdapters.MilicianoAgrupacionTableAdapter adapter = new RucaChampaquiDataSetTableAdapters.MilicianoAgrupacionTableAdapter();
            RucaChampaquiDataSet.MilicianoAgrupacionDataTable tabla = new RucaChampaquiDataSet.MilicianoAgrupacionDataTable();

            adapter.FillBy1(tabla, int.Parse(cmb_agrupacion.SelectedValue.ToString()));

            ReportDataSource reportDataSource = new ReportDataSource("AgrupacionMilicianos", (DataTable)tabla);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        
            }
        }
        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
