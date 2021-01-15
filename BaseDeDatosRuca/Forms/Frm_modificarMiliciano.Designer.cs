namespace BaseDeDatosRuca.Forms
{
    partial class Frm_modificarMiliciano
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_modificarMiliciano));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bttt_confirmar = new System.Windows.Forms.Button();
            this.btt_cancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_tipoDoc = new System.Windows.Forms.ComboBox();
            this.txt_documento = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_compania = new System.Windows.Forms.ComboBox();
            this.cmb_hobby = new System.Windows.Forms.ComboBox();
            this.cmb_colegio = new System.Windows.Forms.ComboBox();
            this.cmb_barrio = new System.Windows.Forms.ComboBox();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.txt_nro = new System.Windows.Forms.TextBox();
            this.txt_calle = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_gmail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.bt_seccion = new System.Windows.Forms.Button();
            this.cmb_seccion = new System.Windows.Forms.ComboBox();
            this.Seccion = new System.Windows.Forms.Label();
            this.cmb_agrupacion = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar Documento ";
            // 
            // bttt_confirmar
            // 
            this.bttt_confirmar.Location = new System.Drawing.Point(505, 94);
            this.bttt_confirmar.Name = "bttt_confirmar";
            this.bttt_confirmar.Size = new System.Drawing.Size(100, 25);
            this.bttt_confirmar.TabIndex = 2;
            this.bttt_confirmar.Text = "Confirmar";
            this.bttt_confirmar.UseVisualStyleBackColor = true;
            this.bttt_confirmar.Click += new System.EventHandler(this.bttt_confirmar_Click);
            // 
            // btt_cancelar
            // 
            this.btt_cancelar.Location = new System.Drawing.Point(256, 94);
            this.btt_cancelar.Name = "btt_cancelar";
            this.btt_cancelar.Size = new System.Drawing.Size(100, 25);
            this.btt_cancelar.TabIndex = 3;
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
            this.label2.TabIndex = 19;
            this.label2.Text = "Tipo de documento";
            // 
            // cmb_tipoDoc
            // 
            this.cmb_tipoDoc.FormattingEnabled = true;
            this.cmb_tipoDoc.Location = new System.Drawing.Point(256, 30);
            this.cmb_tipoDoc.Name = "cmb_tipoDoc";
            this.cmb_tipoDoc.Size = new System.Drawing.Size(56, 21);
            this.cmb_tipoDoc.TabIndex = 0;
            // 
            // txt_documento
            // 
            this.txt_documento.Location = new System.Drawing.Point(505, 30);
            this.txt_documento.Mask = "00000000";
            this.txt_documento.Name = "txt_documento";
            this.txt_documento.Size = new System.Drawing.Size(56, 20);
            this.txt_documento.TabIndex = 1;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_compania);
            this.groupBox1.Controls.Add(this.cmb_hobby);
            this.groupBox1.Controls.Add(this.cmb_colegio);
            this.groupBox1.Controls.Add(this.cmb_barrio);
            this.groupBox1.Controls.Add(this.txt_telefono);
            this.groupBox1.Controls.Add(this.txt_nro);
            this.groupBox1.Controls.Add(this.txt_calle);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txt_gmail);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.bt_seccion);
            this.groupBox1.Controls.Add(this.cmb_seccion);
            this.groupBox1.Controls.Add(this.Seccion);
            this.groupBox1.Controls.Add(this.cmb_agrupacion);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_apellido);
            this.groupBox1.Controls.Add(this.txt_nombre);
            this.groupBox1.Location = new System.Drawing.Point(13, 148);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(852, 262);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modificas Datos";
            // 
            // cmb_compania
            // 
            this.cmb_compania.FormattingEnabled = true;
            this.cmb_compania.Location = new System.Drawing.Point(604, 231);
            this.cmb_compania.Name = "cmb_compania";
            this.cmb_compania.Size = new System.Drawing.Size(199, 21);
            this.cmb_compania.TabIndex = 13;
            // 
            // cmb_hobby
            // 
            this.cmb_hobby.FormattingEnabled = true;
            this.cmb_hobby.Location = new System.Drawing.Point(603, 166);
            this.cmb_hobby.Name = "cmb_hobby";
            this.cmb_hobby.Size = new System.Drawing.Size(199, 21);
            this.cmb_hobby.TabIndex = 11;
            // 
            // cmb_colegio
            // 
            this.cmb_colegio.FormattingEnabled = true;
            this.cmb_colegio.Location = new System.Drawing.Point(604, 134);
            this.cmb_colegio.Name = "cmb_colegio";
            this.cmb_colegio.Size = new System.Drawing.Size(199, 21);
            this.cmb_colegio.TabIndex = 10;
            // 
            // cmb_barrio
            // 
            this.cmb_barrio.FormattingEnabled = true;
            this.cmb_barrio.Location = new System.Drawing.Point(604, 24);
            this.cmb_barrio.Name = "cmb_barrio";
            this.cmb_barrio.Size = new System.Drawing.Size(199, 21);
            this.cmb_barrio.TabIndex = 7;
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(604, 199);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(199, 20);
            this.txt_telefono.TabIndex = 12;
            // 
            // txt_nro
            // 
            this.txt_nro.Location = new System.Drawing.Point(603, 99);
            this.txt_nro.Name = "txt_nro";
            this.txt_nro.Size = new System.Drawing.Size(199, 20);
            this.txt_nro.TabIndex = 9;
            // 
            // txt_calle
            // 
            this.txt_calle.Location = new System.Drawing.Point(603, 58);
            this.txt_calle.Name = "txt_calle";
            this.txt_calle.Size = new System.Drawing.Size(199, 20);
            this.txt_calle.TabIndex = 8;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(474, 235);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(118, 16);
            this.label15.TabIndex = 54;
            this.label15.Text = "Tipo de compañia";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(88, 219);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(118, 16);
            this.label14.TabIndex = 52;
            this.label14.Text = "Correo electronico";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(474, 129);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 16);
            this.label13.TabIndex = 50;
            this.label13.Text = "Colegio";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(474, 195);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 16);
            this.label12.TabIndex = 48;
            this.label12.Text = "Telefono";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(474, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 16);
            this.label11.TabIndex = 46;
            this.label11.Text = "Calle";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(474, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 16);
            this.label10.TabIndex = 44;
            this.label10.Text = "Nro calle";
            // 
            // txt_gmail
            // 
            this.txt_gmail.Location = new System.Drawing.Point(245, 219);
            this.txt_gmail.Name = "txt_gmail";
            this.txt_gmail.Size = new System.Drawing.Size(199, 20);
            this.txt_gmail.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(474, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 16);
            this.label9.TabIndex = 43;
            this.label9.Text = "Hobby";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(474, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 16);
            this.label8.TabIndex = 42;
            this.label8.Text = "Barrio";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(245, 90);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(199, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // bt_seccion
            // 
            this.bt_seccion.Location = new System.Drawing.Point(42, 176);
            this.bt_seccion.Name = "bt_seccion";
            this.bt_seccion.Size = new System.Drawing.Size(172, 23);
            this.bt_seccion.TabIndex = 4;
            this.bt_seccion.Text = "Cargar Seccion / Generacion ";
            this.bt_seccion.UseVisualStyleBackColor = true;
            this.bt_seccion.Click += new System.EventHandler(this.bt_seccion_Click);
            // 
            // cmb_seccion
            // 
            this.cmb_seccion.FormattingEnabled = true;
            this.cmb_seccion.Location = new System.Drawing.Point(245, 176);
            this.cmb_seccion.Name = "cmb_seccion";
            this.cmb_seccion.Size = new System.Drawing.Size(199, 21);
            this.cmb_seccion.TabIndex = 5;
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
            // cmb_agrupacion
            // 
            this.cmb_agrupacion.FormattingEnabled = true;
            this.cmb_agrupacion.Location = new System.Drawing.Point(245, 134);
            this.cmb_agrupacion.Name = "cmb_agrupacion";
            this.cmb_agrupacion.Size = new System.Drawing.Size(199, 21);
            this.cmb_agrupacion.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(88, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 31;
            this.label4.Text = "Apellido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(88, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 33;
            this.label5.Text = "Nombre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(88, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 16);
            this.label6.TabIndex = 36;
            this.label6.Text = "Fecha de nacimiento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(88, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 16);
            this.label7.TabIndex = 38;
            this.label7.Text = "Agrupacion";
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(617, 416);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 25);
            this.button1.TabIndex = 1;
            this.button1.Text = "Confirmar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(258, 416);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 25);
            this.button2.TabIndex = 2;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Frm_modificarMiliciano
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 453);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_modificarMiliciano";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Miliciano";
            this.Load += new System.EventHandler(this.Frm_modificarMiliciano_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bttt_confirmar;
        private System.Windows.Forms.Button btt_cancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_tipoDoc;
        private System.Windows.Forms.MaskedTextBox txt_documento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button bt_seccion;
        private System.Windows.Forms.ComboBox cmb_seccion;
        private System.Windows.Forms.Label Seccion;
        private System.Windows.Forms.ComboBox cmb_agrupacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.ComboBox cmb_compania;
        private System.Windows.Forms.ComboBox cmb_hobby;
        private System.Windows.Forms.ComboBox cmb_colegio;
        private System.Windows.Forms.ComboBox cmb_barrio;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.TextBox txt_nro;
        private System.Windows.Forms.TextBox txt_calle;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_gmail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}