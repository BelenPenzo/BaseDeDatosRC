namespace BaseDeDatosRuca.Reportes
{
    partial class Frm_RHobby
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_RHobby));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_hobby = new System.Windows.Forms.ComboBox();
            this.bt_buscar = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.MilicianosHobbyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RucaChampaquiDataSet = new BaseDeDatosRuca.Reportes.RucaChampaquiDataSet();
            this.MilicianosHobbyTableAdapter = new BaseDeDatosRuca.Reportes.RucaChampaquiDataSetTableAdapters.MilicianosHobbyTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MilicianosHobbyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RucaChampaquiDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_buscar);
            this.groupBox1.Controls.Add(this.cmb_hobby);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(669, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccionar hobby";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hobby";
            // 
            // cmb_hobby
            // 
            this.cmb_hobby.FormattingEnabled = true;
            this.cmb_hobby.Location = new System.Drawing.Point(183, 45);
            this.cmb_hobby.Name = "cmb_hobby";
            this.cmb_hobby.Size = new System.Drawing.Size(176, 21);
            this.cmb_hobby.TabIndex = 1;
            // 
            // bt_buscar
            // 
            this.bt_buscar.Location = new System.Drawing.Point(583, 71);
            this.bt_buscar.Name = "bt_buscar";
            this.bt_buscar.Size = new System.Drawing.Size(75, 23);
            this.bt_buscar.TabIndex = 2;
            this.bt_buscar.Text = "Buscar";
            this.bt_buscar.UseVisualStyleBackColor = true;
            this.bt_buscar.Click += new System.EventHandler(this.bt_buscar_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "HobbyMilicianos";
            reportDataSource1.Value = this.MilicianosHobbyBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BaseDeDatosRuca.Reportes.R_hobby.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 129);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(691, 336);
            this.reportViewer1.TabIndex = 1;
            // 
            // MilicianosHobbyBindingSource
            // 
            this.MilicianosHobbyBindingSource.DataMember = "MilicianosHobby";
            this.MilicianosHobbyBindingSource.DataSource = this.RucaChampaquiDataSet;
            // 
            // RucaChampaquiDataSet
            // 
            this.RucaChampaquiDataSet.DataSetName = "RucaChampaquiDataSet";
            this.RucaChampaquiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MilicianosHobbyTableAdapter
            // 
            this.MilicianosHobbyTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_RHobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 477);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_RHobby";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado Milicianos";
            this.Load += new System.EventHandler(this.Frm_RHobby_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MilicianosHobbyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RucaChampaquiDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_buscar;
        private System.Windows.Forms.ComboBox cmb_hobby;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource MilicianosHobbyBindingSource;
        private RucaChampaquiDataSet RucaChampaquiDataSet;
        private RucaChampaquiDataSetTableAdapters.MilicianosHobbyTableAdapter MilicianosHobbyTableAdapter;
    }
}