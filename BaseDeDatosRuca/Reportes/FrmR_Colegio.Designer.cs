namespace BaseDeDatosRuca.Reportes
{
    partial class FrmR_Colegio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmR_Colegio));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_buscar = new System.Windows.Forms.Button();
            this.cmb_colegio = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.RucaChampaquiDataSet = new BaseDeDatosRuca.Reportes.RucaChampaquiDataSet();
            this.MilicianoColegioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MilicianoColegioTableAdapter = new BaseDeDatosRuca.Reportes.RucaChampaquiDataSetTableAdapters.MilicianoColegioTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RucaChampaquiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MilicianoColegioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_buscar);
            this.groupBox1.Controls.Add(this.cmb_colegio);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(33, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(620, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecionar Colegio";
            // 
            // bt_buscar
            // 
            this.bt_buscar.Location = new System.Drawing.Point(517, 60);
            this.bt_buscar.Name = "bt_buscar";
            this.bt_buscar.Size = new System.Drawing.Size(75, 23);
            this.bt_buscar.TabIndex = 2;
            this.bt_buscar.Text = "Buscar";
            this.bt_buscar.UseVisualStyleBackColor = true;
            this.bt_buscar.Click += new System.EventHandler(this.bt_buscar_Click);
            // 
            // cmb_colegio
            // 
            this.cmb_colegio.FormattingEnabled = true;
            this.cmb_colegio.Location = new System.Drawing.Point(172, 44);
            this.cmb_colegio.Name = "cmb_colegio";
            this.cmb_colegio.Size = new System.Drawing.Size(258, 21);
            this.cmb_colegio.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Colegio";
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "ColegiosMiliciano";
            reportDataSource1.Value = this.MilicianoColegioBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BaseDeDatosRuca.Reportes.R_Colegio.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 136);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(673, 447);
            this.reportViewer1.TabIndex = 1;
            // 
            // RucaChampaquiDataSet
            // 
            this.RucaChampaquiDataSet.DataSetName = "RucaChampaquiDataSet";
            this.RucaChampaquiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MilicianoColegioBindingSource
            // 
            this.MilicianoColegioBindingSource.DataMember = "MilicianoColegio";
            this.MilicianoColegioBindingSource.DataSource = this.RucaChampaquiDataSet;
            // 
            // MilicianoColegioTableAdapter
            // 
            this.MilicianoColegioTableAdapter.ClearBeforeFill = true;
            // 
            // FrmR_Colegio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 595);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmR_Colegio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado Milicianos";
            this.Load += new System.EventHandler(this.FrmR_Colegio_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RucaChampaquiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MilicianoColegioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_buscar;
        private System.Windows.Forms.ComboBox cmb_colegio;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource MilicianoColegioBindingSource;
        private RucaChampaquiDataSet RucaChampaquiDataSet;
        private RucaChampaquiDataSetTableAdapters.MilicianoColegioTableAdapter MilicianoColegioTableAdapter;
    }
}