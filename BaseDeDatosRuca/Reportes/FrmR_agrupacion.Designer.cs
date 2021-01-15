namespace BaseDeDatosRuca.Reportes
{
    partial class FrmR_agrupacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmR_agrupacion));
            this.MilicianoAgrupacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RucaChampaquiDataSet = new BaseDeDatosRuca.Reportes.RucaChampaquiDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.MilicianoAgrupacionTableAdapter = new BaseDeDatosRuca.Reportes.RucaChampaquiDataSetTableAdapters.MilicianoAgrupacionTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_buscar = new System.Windows.Forms.Button();
            this.cmb_agrupacion = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MilicianoAgrupacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RucaChampaquiDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MilicianoAgrupacionBindingSource
            // 
            this.MilicianoAgrupacionBindingSource.DataMember = "MilicianoAgrupacion";
            this.MilicianoAgrupacionBindingSource.DataSource = this.RucaChampaquiDataSet;
            // 
            // RucaChampaquiDataSet
            // 
            this.RucaChampaquiDataSet.DataSetName = "RucaChampaquiDataSet";
            this.RucaChampaquiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "MilicianosAgrupacion";
            reportDataSource1.Value = this.MilicianoAgrupacionBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BaseDeDatosRuca.Reportes.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 135);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(714, 427);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // MilicianoAgrupacionTableAdapter
            // 
            this.MilicianoAgrupacionTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_buscar);
            this.groupBox1.Controls.Add(this.cmb_agrupacion);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(26, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(700, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccionar Agrupacion";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // bt_buscar
            // 
            this.bt_buscar.Location = new System.Drawing.Point(609, 71);
            this.bt_buscar.Name = "bt_buscar";
            this.bt_buscar.Size = new System.Drawing.Size(75, 23);
            this.bt_buscar.TabIndex = 2;
            this.bt_buscar.Text = "Buscar";
            this.bt_buscar.UseVisualStyleBackColor = true;
            this.bt_buscar.Click += new System.EventHandler(this.bt_buscar_Click);
            // 
            // cmb_agrupacion
            // 
            this.cmb_agrupacion.FormattingEnabled = true;
            this.cmb_agrupacion.Location = new System.Drawing.Point(337, 44);
            this.cmb_agrupacion.Name = "cmb_agrupacion";
            this.cmb_agrupacion.Size = new System.Drawing.Size(121, 21);
            this.cmb_agrupacion.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(233, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agrupacion";
            // 
            // FrmR_agrupacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 593);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "FrmR_agrupacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado  Milicianos";
            this.Load += new System.EventHandler(this.FrmR_agrupacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MilicianoAgrupacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RucaChampaquiDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource MilicianoAgrupacionBindingSource;
        private RucaChampaquiDataSet RucaChampaquiDataSet;
        private RucaChampaquiDataSetTableAdapters.MilicianoAgrupacionTableAdapter MilicianoAgrupacionTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_buscar;
        private System.Windows.Forms.ComboBox cmb_agrupacion;
        private System.Windows.Forms.Label label1;
    }
}