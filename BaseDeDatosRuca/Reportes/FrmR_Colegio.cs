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
    public partial class FrmR_Colegio : Form
    {
        public FrmR_Colegio()
        {
            InitializeComponent();
        }

        private void FrmR_Colegio_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'RucaChampaquiDataSet.MilicianoColegio' Puede moverla o quitarla según sea necesario.
            //this.MilicianoColegioTableAdapter.Fill(this.RucaChampaquiDataSet.MilicianoColegio);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.Clear();
            CargarColegio(ref cmb_colegio, "tipoColegio", "nombre");
            cmb_colegio.SelectedIndex = -1;
        }

        public void CargarColegio(ref ComboBox cmb_colegio, string tipoColegio, string nombre)
        {
            cmb_colegio.Items.Clear();
            cmb_colegio.DataSource = Clases.AccesosV.llenarComboColegio();
            cmb_colegio.DisplayMember = nombre;
            cmb_colegio.ValueMember = tipoColegio;

        }

        private void bt_buscar_Click(object sender, EventArgs e)
        {

            if (cmb_colegio.SelectedIndex == -1)
            {
                MessageBox.Show("Falta completar campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {

                RucaChampaquiDataSetTableAdapters.MilicianoColegioTableAdapter adapter = new RucaChampaquiDataSetTableAdapters.MilicianoColegioTableAdapter();
            RucaChampaquiDataSet.MilicianoColegioDataTable tabla = new RucaChampaquiDataSet.MilicianoColegioDataTable();

            adapter.Fill(tabla, int.Parse(cmb_colegio.SelectedValue.ToString()));

            ReportDataSource reportDataSource = new ReportDataSource("ColegiosMiliciano", (DataTable)tabla);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }
    }
}
}
