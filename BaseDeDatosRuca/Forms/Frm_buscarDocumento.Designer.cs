namespace BaseDeDatosRuca.Forms
{
    partial class Frm_buscarDocumento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_buscarDocumento));
            this.txt_documento = new System.Windows.Forms.MaskedTextBox();
            this.cmb_tipoDoc = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bttt_confirmar = new System.Windows.Forms.Button();
            this.btt_cancelar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.lbl_calle = new System.Windows.Forms.Label();
            this.lbl_barrio = new System.Windows.Forms.Label();
            this.lbl_gmail = new System.Windows.Forms.Label();
            this.lbl_agrupacion = new System.Windows.Forms.Label();
            this.lbl_seccion = new System.Windows.Forms.Label();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_compania = new System.Windows.Forms.Label();
            this.lbl_nro = new System.Windows.Forms.Label();
            this.lbl_colegio = new System.Windows.Forms.Label();
            this.lbl_hobby = new System.Windows.Forms.Label();
            this.lbl_telefono = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_documento
            // 
            this.txt_documento.Location = new System.Drawing.Point(553, 34);
            this.txt_documento.Mask = "00000000";
            this.txt_documento.Name = "txt_documento";
            this.txt_documento.Size = new System.Drawing.Size(56, 20);
            this.txt_documento.TabIndex = 20;
            // 
            // cmb_tipoDoc
            // 
            this.cmb_tipoDoc.FormattingEnabled = true;
            this.cmb_tipoDoc.Location = new System.Drawing.Point(304, 34);
            this.cmb_tipoDoc.Name = "cmb_tipoDoc";
            this.cmb_tipoDoc.Size = new System.Drawing.Size(56, 21);
            this.cmb_tipoDoc.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(165, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Tipo de documento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(402, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Numero de documento";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bttt_confirmar);
            this.groupBox2.Controls.Add(this.btt_cancelar);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cmb_tipoDoc);
            this.groupBox2.Controls.Add(this.txt_documento);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(25, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(829, 129);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar Documento ";
            // 
            // bttt_confirmar
            // 
            this.bttt_confirmar.Location = new System.Drawing.Point(553, 98);
            this.bttt_confirmar.Name = "bttt_confirmar";
            this.bttt_confirmar.Size = new System.Drawing.Size(100, 25);
            this.bttt_confirmar.TabIndex = 22;
            this.bttt_confirmar.Text = "Confirmar";
            this.bttt_confirmar.UseVisualStyleBackColor = true;
            this.bttt_confirmar.Click += new System.EventHandler(this.bttt_confirmar_Click);
            // 
            // btt_cancelar
            // 
            this.btt_cancelar.Location = new System.Drawing.Point(304, 98);
            this.btt_cancelar.Name = "btt_cancelar";
            this.btt_cancelar.Size = new System.Drawing.Size(100, 25);
            this.btt_cancelar.TabIndex = 23;
            this.btt_cancelar.Text = "Cancelar";
            this.btt_cancelar.UseVisualStyleBackColor = true;
            this.btt_cancelar.Click += new System.EventHandler(this.btt_cancelar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(438, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 16);
            this.label8.TabIndex = 28;
            this.label8.Text = "Barrio";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(438, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 16);
            this.label9.TabIndex = 30;
            this.label9.Text = "Hobby";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(438, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 16);
            this.label10.TabIndex = 32;
            this.label10.Text = "Nro calle";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(438, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 16);
            this.label11.TabIndex = 34;
            this.label11.Text = "Calle";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(438, 181);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 16);
            this.label12.TabIndex = 36;
            this.label12.Text = "Telefono";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(438, 124);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(165, 16);
            this.label13.TabIndex = 37;
            this.label13.Text = "Colegio - Universidad";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(18, 186);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(139, 16);
            this.label14.TabIndex = 39;
            this.label14.Text = "Correo electronico";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(438, 206);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(136, 16);
            this.label15.TabIndex = 41;
            this.label15.Text = "Tipo de compañia";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 16);
            this.label7.TabIndex = 26;
            this.label7.Text = "Agrupacion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "Fecha de nacimiento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 47;
            this.label5.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 46;
            this.label4.Text = "Apellido";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 16);
            this.label1.TabIndex = 48;
            this.label1.Text = "Seccion - Generacion";
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_apellido.Location = new System.Drawing.Point(196, 42);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(0, 16);
            this.lbl_apellido.TabIndex = 49;
            // 
            // lbl_calle
            // 
            this.lbl_calle.AutoSize = true;
            this.lbl_calle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_calle.Location = new System.Drawing.Point(619, 64);
            this.lbl_calle.Name = "lbl_calle";
            this.lbl_calle.Size = new System.Drawing.Size(0, 16);
            this.lbl_calle.TabIndex = 50;
            // 
            // lbl_barrio
            // 
            this.lbl_barrio.AutoSize = true;
            this.lbl_barrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_barrio.Location = new System.Drawing.Point(619, 35);
            this.lbl_barrio.Name = "lbl_barrio";
            this.lbl_barrio.Size = new System.Drawing.Size(0, 16);
            this.lbl_barrio.TabIndex = 51;
            // 
            // lbl_gmail
            // 
            this.lbl_gmail.AutoSize = true;
            this.lbl_gmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gmail.Location = new System.Drawing.Point(196, 186);
            this.lbl_gmail.Name = "lbl_gmail";
            this.lbl_gmail.Size = new System.Drawing.Size(0, 16);
            this.lbl_gmail.TabIndex = 52;
            // 
            // lbl_agrupacion
            // 
            this.lbl_agrupacion.AutoSize = true;
            this.lbl_agrupacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_agrupacion.Location = new System.Drawing.Point(196, 127);
            this.lbl_agrupacion.Name = "lbl_agrupacion";
            this.lbl_agrupacion.Size = new System.Drawing.Size(0, 16);
            this.lbl_agrupacion.TabIndex = 53;
            // 
            // lbl_seccion
            // 
            this.lbl_seccion.AutoSize = true;
            this.lbl_seccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_seccion.Location = new System.Drawing.Point(196, 155);
            this.lbl_seccion.Name = "lbl_seccion";
            this.lbl_seccion.Size = new System.Drawing.Size(0, 16);
            this.lbl_seccion.TabIndex = 53;
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha.Location = new System.Drawing.Point(196, 100);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(0, 16);
            this.lbl_fecha.TabIndex = 54;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.Location = new System.Drawing.Point(196, 69);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(0, 16);
            this.lbl_nombre.TabIndex = 55;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_compania);
            this.groupBox1.Controls.Add(this.lbl_nro);
            this.groupBox1.Controls.Add(this.lbl_colegio);
            this.groupBox1.Controls.Add(this.lbl_hobby);
            this.groupBox1.Controls.Add(this.lbl_telefono);
            this.groupBox1.Controls.Add(this.lbl_nombre);
            this.groupBox1.Controls.Add(this.lbl_fecha);
            this.groupBox1.Controls.Add(this.lbl_seccion);
            this.groupBox1.Controls.Add(this.lbl_agrupacion);
            this.groupBox1.Controls.Add(this.lbl_gmail);
            this.groupBox1.Controls.Add(this.lbl_barrio);
            this.groupBox1.Controls.Add(this.lbl_calle);
            this.groupBox1.Controls.Add(this.lbl_apellido);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(25, 180);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(829, 242);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del miliciano";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lbl_compania
            // 
            this.lbl_compania.AutoSize = true;
            this.lbl_compania.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_compania.Location = new System.Drawing.Point(619, 204);
            this.lbl_compania.Name = "lbl_compania";
            this.lbl_compania.Size = new System.Drawing.Size(0, 16);
            this.lbl_compania.TabIndex = 60;
            // 
            // lbl_nro
            // 
            this.lbl_nro.AutoSize = true;
            this.lbl_nro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nro.Location = new System.Drawing.Point(619, 94);
            this.lbl_nro.Name = "lbl_nro";
            this.lbl_nro.Size = new System.Drawing.Size(0, 16);
            this.lbl_nro.TabIndex = 59;
            // 
            // lbl_colegio
            // 
            this.lbl_colegio.AutoSize = true;
            this.lbl_colegio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_colegio.Location = new System.Drawing.Point(619, 124);
            this.lbl_colegio.Name = "lbl_colegio";
            this.lbl_colegio.Size = new System.Drawing.Size(0, 16);
            this.lbl_colegio.TabIndex = 58;
            // 
            // lbl_hobby
            // 
            this.lbl_hobby.AutoSize = true;
            this.lbl_hobby.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hobby.Location = new System.Drawing.Point(619, 150);
            this.lbl_hobby.Name = "lbl_hobby";
            this.lbl_hobby.Size = new System.Drawing.Size(0, 16);
            this.lbl_hobby.TabIndex = 57;
            // 
            // lbl_telefono
            // 
            this.lbl_telefono.AutoSize = true;
            this.lbl_telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telefono.Location = new System.Drawing.Point(619, 181);
            this.lbl_telefono.Name = "lbl_telefono";
            this.lbl_telefono.Size = new System.Drawing.Size(0, 16);
            this.lbl_telefono.TabIndex = 56;
            // 
            // Frm_buscarDocumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 442);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_buscarDocumento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Miliciano";
            this.Load += new System.EventHandler(this.Frm_buscarDocumento_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox txt_documento;
        private System.Windows.Forms.ComboBox cmb_tipoDoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bttt_confirmar;
        private System.Windows.Forms.Button btt_cancelar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_apellido;
        private System.Windows.Forms.Label lbl_calle;
        private System.Windows.Forms.Label lbl_barrio;
        private System.Windows.Forms.Label lbl_gmail;
        private System.Windows.Forms.Label lbl_agrupacion;
        private System.Windows.Forms.Label lbl_seccion;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_compania;
        private System.Windows.Forms.Label lbl_nro;
        private System.Windows.Forms.Label lbl_colegio;
        private System.Windows.Forms.Label lbl_hobby;
        private System.Windows.Forms.Label lbl_telefono;
    }
}