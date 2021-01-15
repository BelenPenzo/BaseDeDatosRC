namespace BaseDeDatosRuca.Forms
{
    partial class Frm_modificarPariente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_modificarPariente));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_parentesco = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_ocupacion = new System.Windows.Forms.ComboBox();
            this.cmb_compania = new System.Windows.Forms.ComboBox();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_gmail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Seccion = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bttt_confirmar = new System.Windows.Forms.Button();
            this.btt_cancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_tipoDoc = new System.Windows.Forms.ComboBox();
            this.txt_documento = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(607, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 25);
            this.button1.TabIndex = 2;
            this.button1.Text = "Confirmar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(258, 314);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 25);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_parentesco);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmb_ocupacion);
            this.groupBox1.Controls.Add(this.cmb_compania);
            this.groupBox1.Controls.Add(this.txt_telefono);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txt_gmail);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.Seccion);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_apellido);
            this.groupBox1.Controls.Add(this.txt_nombre);
            this.groupBox1.Location = new System.Drawing.Point(13, 148);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(852, 160);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modificas Datos Pariente";
            // 
            // cmb_parentesco
            // 
            this.cmb_parentesco.FormattingEnabled = true;
            this.cmb_parentesco.Location = new System.Drawing.Point(245, 115);
            this.cmb_parentesco.Name = "cmb_parentesco";
            this.cmb_parentesco.Size = new System.Drawing.Size(199, 21);
            this.cmb_parentesco.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 56;
            this.label1.Text = "Parentesco";
            // 
            // cmb_ocupacion
            // 
            this.cmb_ocupacion.FormattingEnabled = true;
            this.cmb_ocupacion.Location = new System.Drawing.Point(594, 93);
            this.cmb_ocupacion.Name = "cmb_ocupacion";
            this.cmb_ocupacion.Size = new System.Drawing.Size(199, 21);
            this.cmb_ocupacion.TabIndex = 6;
            this.cmb_ocupacion.SelectedIndexChanged += new System.EventHandler(this.cmb_ocupacion_SelectedIndexChanged);
            // 
            // cmb_compania
            // 
            this.cmb_compania.FormattingEnabled = true;
            this.cmb_compania.Location = new System.Drawing.Point(594, 60);
            this.cmb_compania.Name = "cmb_compania";
            this.cmb_compania.Size = new System.Drawing.Size(199, 21);
            this.cmb_compania.TabIndex = 5;
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(594, 28);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(199, 20);
            this.txt_telefono.TabIndex = 4;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(464, 64);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(118, 16);
            this.label15.TabIndex = 54;
            this.label15.Text = "Tipo de compañia";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(116, 89);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(118, 16);
            this.label14.TabIndex = 52;
            this.label14.Text = "Correo electronico";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(464, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 16);
            this.label12.TabIndex = 48;
            this.label12.Text = "Telefono";
            // 
            // txt_gmail
            // 
            this.txt_gmail.Location = new System.Drawing.Point(245, 89);
            this.txt_gmail.Name = "txt_gmail";
            this.txt_gmail.Size = new System.Drawing.Size(199, 20);
            this.txt_gmail.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(464, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 16);
            this.label9.TabIndex = 43;
            this.label9.Text = "Ocupacion";
            // 
            // Seccion
            // 
            this.Seccion.AutoSize = true;
            this.Seccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Seccion.Location = new System.Drawing.Point(52, 170);
            this.Seccion.Name = "Seccion";
            this.Seccion.Size = new System.Drawing.Size(0, 16);
            this.Seccion.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(116, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 31;
            this.label4.Text = "Apellido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(116, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 33;
            this.label5.Text = "Nombre";
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(245, 24);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(199, 20);
            this.txt_apellido.TabIndex = 0;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(245, 54);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(199, 20);
            this.txt_nombre.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bttt_confirmar);
            this.groupBox2.Controls.Add(this.btt_cancelar);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cmb_tipoDoc);
            this.groupBox2.Controls.Add(this.txt_documento);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(853, 129);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar Documento Miliciano";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // bttt_confirmar
            // 
            this.bttt_confirmar.Location = new System.Drawing.Point(505, 94);
            this.bttt_confirmar.Name = "bttt_confirmar";
            this.bttt_confirmar.Size = new System.Drawing.Size(100, 25);
            this.bttt_confirmar.TabIndex = 3;
            this.bttt_confirmar.Text = "Confirmar";
            this.bttt_confirmar.UseVisualStyleBackColor = true;
            this.bttt_confirmar.Click += new System.EventHandler(this.bttt_confirmar_Click);
            // 
            // btt_cancelar
            // 
            this.btt_cancelar.Location = new System.Drawing.Point(256, 94);
            this.btt_cancelar.Name = "btt_cancelar";
            this.btt_cancelar.Size = new System.Drawing.Size(100, 25);
            this.btt_cancelar.TabIndex = 4;
            this.btt_cancelar.Text = "Cancelar";
            this.btt_cancelar.UseVisualStyleBackColor = true;
            this.btt_cancelar.Click += new System.EventHandler(this.btt_cancelar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(117, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tipo de documento";
            // 
            // cmb_tipoDoc
            // 
            this.cmb_tipoDoc.FormattingEnabled = true;
            this.cmb_tipoDoc.Location = new System.Drawing.Point(256, 30);
            this.cmb_tipoDoc.Name = "cmb_tipoDoc";
            this.cmb_tipoDoc.Size = new System.Drawing.Size(56, 21);
            this.cmb_tipoDoc.TabIndex = 1;
            // 
            // txt_documento
            // 
            this.txt_documento.Location = new System.Drawing.Point(505, 30);
            this.txt_documento.Mask = "00000000";
            this.txt_documento.Name = "txt_documento";
            this.txt_documento.Size = new System.Drawing.Size(56, 20);
            this.txt_documento.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(354, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Numero de documento";
            // 
            // Frm_modificarPariente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 348);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_modificarPariente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Pariente";
            this.Load += new System.EventHandler(this.Frm_modificarPariente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmb_compania;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_gmail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Seccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bttt_confirmar;
        private System.Windows.Forms.Button btt_cancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_tipoDoc;
        private System.Windows.Forms.MaskedTextBox txt_documento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_ocupacion;
        private System.Windows.Forms.ComboBox cmb_parentesco;
        private System.Windows.Forms.Label label1;
    }
}