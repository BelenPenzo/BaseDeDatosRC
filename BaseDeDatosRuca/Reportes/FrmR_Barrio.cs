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
    public partial class FrmR_Barrio : Form
    {
        public FrmR_Barrio()
        {
            InitializeComponent();
        }

        private void FrmR_Barrio_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'RucaChampaquiDataSet.MilicianoBarrio' Puede moverla o quitarla según sea necesario.
            //this.MilicianoBarrioTableAdapter.Fill(this.RucaChampaquiDataSet.MilicianoBarrio);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.Clear();
            CargarBarrio(ref cmb_barrio, "tipoBarrio", "nombre");
            cmb_barrio.SelectedIndex = -1;
        }

        public void CargarBarrio(ref ComboBox cmb_barrio, string tipoBarrio, string nombre)
        {
            cmb_barrio.Items.Clear();
            cmb_barrio.DataSource = Clases.AccesosV.llenarComboBarrio();
            cmb_barrio.DisplayMember = nombre;
            cmb_barrio.ValueMember = tipoBarrio;

        }

        private void bt_buscar_Click(object sender, EventArgs e)
        {
            if (cmb_barrio.SelectedIndex == -1)
            {
                MessageBox.Show("Falta completar campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                RucaChampaquiDataSetTableAdapters.MilicianoBarrioTableAdapter adapter = new RucaChampaquiDataSetTableAdapters.MilicianoBarrioTableAdapter();
            RucaChampaquiDataSet.MilicianoBarrioDataTable tabla = new RucaChampaquiDataSet.MilicianoBarrioDataTable();

            adapter.FillBy(tabla, int.Parse(cmb_barrio.SelectedValue.ToString()));

            ReportDataSource reportDataSource = new ReportDataSource("BarriosMilicianos", (DataTable)tabla);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }
    }
}
}

