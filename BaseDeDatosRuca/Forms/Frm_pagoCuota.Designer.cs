namespace BaseDeDatosRuca.Forms
{
    partial class Frm_pagoCuota
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_pagoCuota));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bttt_confirmar = new System.Windows.Forms.Button();
            this.btt_cancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_tipoDoc = new System.Windows.Forms.ComboBox();
            this.txt_documento = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.msk_segunda = new System.Windows.Forms.MaskedTextBox();
            this.msk_primera = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_masInf = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ch_Segunda = new System.Windows.Forms.CheckBox();
            this.ch_primera = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_pago = new System.Windows.Forms.Button();
            this.btt_registrarPago = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            this.groupBox2.Location = new System.Drawing.Point(12, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(583, 129);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar Documento ";
            // 
            // bttt_confirmar
            // 
            this.bttt_confirmar.Location = new System.Drawing.Point(441, 98);
            this.bttt_confirmar.Name = "bttt_confirmar";
            this.bttt_confirmar.Size = new System.Drawing.Size(100, 25);
            this.bttt_confirmar.TabIndex = 2;
            this.bttt_confirmar.Text = "Confirmar";
            this.bttt_confirmar.UseVisualStyleBackColor = true;
            this.bttt_confirmar.Click += new System.EventHandler(this.bttt_confirmar_Click);
            // 
            // btt_cancelar
            // 
            this.btt_cancelar.Location = new System.Drawing.Point(192, 98);
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
            this.label2.Location = new System.Drawing.Point(53, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Tipo de documento";
            // 
            // cmb_tipoDoc
            // 
            this.cmb_tipoDoc.FormattingEnabled = true;
            this.cmb_tipoDoc.Location = new System.Drawing.Point(192, 34);
            this.cmb_tipoDoc.Name = "cmb_tipoDoc";
            this.cmb_tipoDoc.Size = new System.Drawing.Size(56, 21);
            this.cmb_tipoDoc.TabIndex = 0;
            // 
            // txt_documento
            // 
            this.txt_documento.Location = new System.Drawing.Point(441, 34);
            this.txt_documento.Mask = "00000000";
            this.txt_documento.Name = "txt_documento";
            this.txt_documento.Size = new System.Drawing.Size(56, 20);
            this.txt_documento.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(290, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Numero de documento";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.msk_segunda);
            this.groupBox1.Controls.Add(this.msk_primera);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_masInf);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lbl_nombre);
            this.groupBox1.Controls.Add(this.lbl_apellido);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.ch_Segunda);
            this.groupBox1.Controls.Add(this.ch_primera);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 161);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(582, 317);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion de pagos";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // msk_segunda
            // 
            this.msk_segunda.Location = new System.Drawing.Point(308, 157);
            this.msk_segunda.Mask = "00/00/0000";
            this.msk_segunda.Name = "msk_segunda";
            this.msk_segunda.Size = new System.Drawing.Size(68, 20);
            this.msk_segunda.TabIndex = 5;
            // 
            // msk_primera
            // 
            this.msk_primera.Location = new System.Drawing.Point(308, 112);
            this.msk_primera.Mask = "00/00/0000";
            this.msk_primera.Name = "msk_primera";
            this.msk_primera.Size = new System.Drawing.Size(68, 20);
            this.msk_primera.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(210, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 16);
            this.label9.TabIndex = 64;
            this.label9.Text = "Fecha pago";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(210, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 16);
            this.label8.TabIndex = 63;
            this.label8.Text = "Fecha pago";
            // 
            // txt_masInf
            // 
            this.txt_masInf.Location = new System.Drawing.Point(236, 213);
            this.txt_masInf.Multiline = true;
            this.txt_masInf.Name = "txt_masInf";
            this.txt_masInf.Size = new System.Drawing.Size(260, 81);
            this.txt_masInf.TabIndex = 6;
            this.txt_masInf.TextChanged += new System.EventHandler(this.txt_masInf_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(52, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 16);
            this.label7.TabIndex = 60;
            this.label7.Text = "Otras especificaciones";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.Location = new System.Drawing.Point(376, 49);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(0, 16);
            this.lbl_nombre.TabIndex = 59;
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_apellido.Location = new System.Drawing.Point(171, 49);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(0, 16);
            this.lbl_apellido.TabIndex = 58;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(52, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 56;
            this.label5.Text = "Apellido";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(289, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 57;
            this.label6.Text = "Nombre";
            // 
            // ch_Segunda
            // 
            this.ch_Segunda.AutoSize = true;
            this.ch_Segunda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ch_Segunda.Location = new System.Drawing.Point(174, 164);
            this.ch_Segunda.Name = "ch_Segunda";
            this.ch_Segunda.Size = new System.Drawing.Size(15, 14);
            this.ch_Segunda.TabIndex = 4;
            this.ch_Segunda.UseVisualStyleBackColor = true;
            // 
            // ch_primera
            // 
            this.ch_primera.AutoSize = true;
            this.ch_primera.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ch_primera.Location = new System.Drawing.Point(174, 117);
            this.ch_primera.Name = "ch_primera";
            this.ch_primera.Size = new System.Drawing.Size(15, 14);
            this.ch_primera.TabIndex = 2;
            this.ch_primera.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Segunda cuota";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Primera cuota";
            // 
            // bt_pago
            // 
            this.bt_pago.Location = new System.Drawing.Point(453, 484);
            this.bt_pago.Name = "bt_pago";
            this.bt_pago.Size = new System.Drawing.Size(131, 23);
            this.bt_pago.TabIndex = 3;
            this.bt_pago.Text = "Actualizar pago";
            this.bt_pago.UseVisualStyleBackColor = true;
            this.bt_pago.Click += new System.EventHandler(this.bt_pago_Click);
            // 
            // btt_registrarPago
            // 
            this.btt_registrarPago.Location = new System.Drawing.Point(299, 484);
            this.btt_registrarPago.Name = "btt_registrarPago";
            this.btt_registrarPago.Size = new System.Drawing.Size(131, 23);
            this.btt_registrarPago.TabIndex = 2;
            this.btt_registrarPago.Text = "Registrar pago";
            this.btt_registrarPago.UseVisualStyleBackColor = true;
            this.btt_registrarPago.Click += new System.EventHandler(this.btt_registrarPago_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 484);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Frm_pagoCuota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 519);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btt_registrarPago);
            this.Controls.Add(this.bt_pago);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "Frm_pagoCuota";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pago Cuota";
            this.Load += new System.EventHandler(this.Frm_pagoCuota_Load);
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
        private System.Windows.Forms.CheckBox ch_Segunda;
        private System.Windows.Forms.CheckBox ch_primera;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_pago;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_apellido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_masInf;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btt_registrarPago;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox msk_segunda;
        private System.Windows.Forms.MaskedTextBox msk_primera;
    }
}