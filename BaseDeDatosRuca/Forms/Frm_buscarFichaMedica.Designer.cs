namespace BaseDeDatosRuca.Forms
{
    partial class Frm_buscarFichaMedica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_buscarFichaMedica));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bttt_confirmar = new System.Windows.Forms.Button();
            this.btt_cancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_tipoDoc = new System.Windows.Forms.ComboBox();
            this.txt_documento = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbl_completa = new System.Windows.Forms.Label();
            this.lbl_antitetanica = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbl_alergia = new System.Windows.Forms.Label();
            this.lbl_varicela = new System.Windows.Forms.Label();
            this.lbl_rubeola = new System.Windows.Forms.Label();
            this.lbl_sarampion = new System.Windows.Forms.Label();
            this.lbl_otitis = new System.Windows.Forms.Label();
            this.lbl_hrpatitis = new System.Windows.Forms.Label();
            this.lbl_gastroenteritis = new System.Windows.Forms.Label();
            this.lbl_celiaquia = new System.Windows.Forms.Label();
            this.lbl_epilepsia = new System.Windows.Forms.Label();
            this.lbl_urinaria = new System.Windows.Forms.Label();
            this.lbl_diabetes = new System.Windows.Forms.Label();
            this.lbl_convulsiones = new System.Windows.Forms.Label();
            this.lbl_bronquitis = new System.Windows.Forms.Label();
            this.lbl_anginas = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_nroAfiliado = new System.Windows.Forms.Label();
            this.lbl_grupoSanguineo = new System.Windows.Forms.Label();
            this.lbl_obraSocial = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.groupBox2.Size = new System.Drawing.Size(590, 129);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar Documento ";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // bttt_confirmar
            // 
            this.bttt_confirmar.Location = new System.Drawing.Point(441, 98);
            this.bttt_confirmar.Name = "bttt_confirmar";
            this.bttt_confirmar.Size = new System.Drawing.Size(100, 25);
            this.bttt_confirmar.TabIndex = 22;
            this.bttt_confirmar.Text = "Confirmar";
            this.bttt_confirmar.UseVisualStyleBackColor = true;
            this.bttt_confirmar.Click += new System.EventHandler(this.bttt_confirmar_Click);
            // 
            // btt_cancelar
            // 
            this.btt_cancelar.Location = new System.Drawing.Point(192, 98);
            this.btt_cancelar.Name = "btt_cancelar";
            this.btt_cancelar.Size = new System.Drawing.Size(100, 25);
            this.btt_cancelar.TabIndex = 23;
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
            this.cmb_tipoDoc.TabIndex = 18;
            // 
            // txt_documento
            // 
            this.txt_documento.Location = new System.Drawing.Point(441, 34);
            this.txt_documento.Mask = "00000000";
            this.txt_documento.Name = "txt_documento";
            this.txt_documento.Size = new System.Drawing.Size(56, 20);
            this.txt_documento.TabIndex = 20;
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
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbl_completa);
            this.groupBox4.Controls.Add(this.lbl_antitetanica);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Location = new System.Drawing.Point(13, 554);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(590, 85);
            this.groupBox4.TabIndex = 31;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Datos de Vacunacion";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // lbl_completa
            // 
            this.lbl_completa.AutoSize = true;
            this.lbl_completa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_completa.Location = new System.Drawing.Point(292, 34);
            this.lbl_completa.Name = "lbl_completa";
            this.lbl_completa.Size = new System.Drawing.Size(0, 16);
            this.lbl_completa.TabIndex = 18;
            // 
            // lbl_antitetanica
            // 
            this.lbl_antitetanica.AutoSize = true;
            this.lbl_antitetanica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_antitetanica.Location = new System.Drawing.Point(292, 62);
            this.lbl_antitetanica.Name = "lbl_antitetanica";
            this.lbl_antitetanica.Size = new System.Drawing.Size(0, 16);
            this.lbl_antitetanica.TabIndex = 17;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(50, 60);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 16);
            this.label15.TabIndex = 16;
            this.label15.Text = "Antitetanica";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(50, 34);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(228, 16);
            this.label21.TabIndex = 15;
            this.label21.Text = "Carnet de vacunacion Completo";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbl_alergia);
            this.groupBox3.Controls.Add(this.lbl_varicela);
            this.groupBox3.Controls.Add(this.lbl_rubeola);
            this.groupBox3.Controls.Add(this.lbl_sarampion);
            this.groupBox3.Controls.Add(this.lbl_otitis);
            this.groupBox3.Controls.Add(this.lbl_hrpatitis);
            this.groupBox3.Controls.Add(this.lbl_gastroenteritis);
            this.groupBox3.Controls.Add(this.lbl_celiaquia);
            this.groupBox3.Controls.Add(this.lbl_epilepsia);
            this.groupBox3.Controls.Add(this.lbl_urinaria);
            this.groupBox3.Controls.Add(this.lbl_diabetes);
            this.groupBox3.Controls.Add(this.lbl_convulsiones);
            this.groupBox3.Controls.Add(this.lbl_bronquitis);
            this.groupBox3.Controls.Add(this.lbl_anginas);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(13, 288);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(590, 251);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Antecedentes Medicos";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // lbl_alergia
            // 
            this.lbl_alergia.AutoSize = true;
            this.lbl_alergia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_alergia.Location = new System.Drawing.Point(507, 192);
            this.lbl_alergia.Name = "lbl_alergia";
            this.lbl_alergia.Size = new System.Drawing.Size(0, 16);
            this.lbl_alergia.TabIndex = 41;
            // 
            // lbl_varicela
            // 
            this.lbl_varicela.AutoSize = true;
            this.lbl_varicela.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_varicela.Location = new System.Drawing.Point(507, 170);
            this.lbl_varicela.Name = "lbl_varicela";
            this.lbl_varicela.Size = new System.Drawing.Size(0, 16);
            this.lbl_varicela.TabIndex = 40;
            // 
            // lbl_rubeola
            // 
            this.lbl_rubeola.AutoSize = true;
            this.lbl_rubeola.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rubeola.Location = new System.Drawing.Point(509, 127);
            this.lbl_rubeola.Name = "lbl_rubeola";
            this.lbl_rubeola.Size = new System.Drawing.Size(0, 16);
            this.lbl_rubeola.TabIndex = 39;
            // 
            // lbl_sarampion
            // 
            this.lbl_sarampion.AutoSize = true;
            this.lbl_sarampion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sarampion.Location = new System.Drawing.Point(509, 148);
            this.lbl_sarampion.Name = "lbl_sarampion";
            this.lbl_sarampion.Size = new System.Drawing.Size(0, 16);
            this.lbl_sarampion.TabIndex = 38;
            // 
            // lbl_otitis
            // 
            this.lbl_otitis.AutoSize = true;
            this.lbl_otitis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_otitis.Location = new System.Drawing.Point(509, 101);
            this.lbl_otitis.Name = "lbl_otitis";
            this.lbl_otitis.Size = new System.Drawing.Size(0, 16);
            this.lbl_otitis.TabIndex = 37;
            // 
            // lbl_hrpatitis
            // 
            this.lbl_hrpatitis.AutoSize = true;
            this.lbl_hrpatitis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hrpatitis.Location = new System.Drawing.Point(509, 77);
            this.lbl_hrpatitis.Name = "lbl_hrpatitis";
            this.lbl_hrpatitis.Size = new System.Drawing.Size(0, 16);
            this.lbl_hrpatitis.TabIndex = 36;
            // 
            // lbl_gastroenteritis
            // 
            this.lbl_gastroenteritis.AutoSize = true;
            this.lbl_gastroenteritis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gastroenteritis.Location = new System.Drawing.Point(509, 49);
            this.lbl_gastroenteritis.Name = "lbl_gastroenteritis";
            this.lbl_gastroenteritis.Size = new System.Drawing.Size(0, 16);
            this.lbl_gastroenteritis.TabIndex = 35;
            // 
            // lbl_celiaquia
            // 
            this.lbl_celiaquia.AutoSize = true;
            this.lbl_celiaquia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_celiaquia.Location = new System.Drawing.Point(237, 99);
            this.lbl_celiaquia.Name = "lbl_celiaquia";
            this.lbl_celiaquia.Size = new System.Drawing.Size(0, 16);
            this.lbl_celiaquia.TabIndex = 34;
            // 
            // lbl_epilepsia
            // 
            this.lbl_epilepsia.AutoSize = true;
            this.lbl_epilepsia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_epilepsia.Location = new System.Drawing.Point(237, 192);
            this.lbl_epilepsia.Name = "lbl_epilepsia";
            this.lbl_epilepsia.Size = new System.Drawing.Size(0, 16);
            this.lbl_epilepsia.TabIndex = 33;
            // 
            // lbl_urinaria
            // 
            this.lbl_urinaria.AutoSize = true;
            this.lbl_urinaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_urinaria.Location = new System.Drawing.Point(237, 170);
            this.lbl_urinaria.Name = "lbl_urinaria";
            this.lbl_urinaria.Size = new System.Drawing.Size(0, 16);
            this.lbl_urinaria.TabIndex = 32;
            // 
            // lbl_diabetes
            // 
            this.lbl_diabetes.AutoSize = true;
            this.lbl_diabetes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_diabetes.Location = new System.Drawing.Point(237, 148);
            this.lbl_diabetes.Name = "lbl_diabetes";
            this.lbl_diabetes.Size = new System.Drawing.Size(0, 16);
            this.lbl_diabetes.TabIndex = 31;
            // 
            // lbl_convulsiones
            // 
            this.lbl_convulsiones.AutoSize = true;
            this.lbl_convulsiones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_convulsiones.Location = new System.Drawing.Point(237, 123);
            this.lbl_convulsiones.Name = "lbl_convulsiones";
            this.lbl_convulsiones.Size = new System.Drawing.Size(0, 16);
            this.lbl_convulsiones.TabIndex = 30;
            // 
            // lbl_bronquitis
            // 
            this.lbl_bronquitis.AutoSize = true;
            this.lbl_bronquitis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bronquitis.Location = new System.Drawing.Point(237, 74);
            this.lbl_bronquitis.Name = "lbl_bronquitis";
            this.lbl_bronquitis.Size = new System.Drawing.Size(0, 16);
            this.lbl_bronquitis.TabIndex = 29;
            // 
            // lbl_anginas
            // 
            this.lbl_anginas.AutoSize = true;
            this.lbl_anginas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_anginas.Location = new System.Drawing.Point(237, 49);
            this.lbl_anginas.Name = "lbl_anginas";
            this.lbl_anginas.Size = new System.Drawing.Size(0, 16);
            this.lbl_anginas.TabIndex = 28;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(349, 192);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(58, 16);
            this.label23.TabIndex = 27;
            this.label23.Text = "Alergia";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(52, 99);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(74, 16);
            this.label22.TabIndex = 25;
            this.label22.Text = "Celiaquia";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(52, 76);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(77, 16);
            this.label20.TabIndex = 12;
            this.label20.Text = "Bronquitis";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(50, 148);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(71, 16);
            this.label19.TabIndex = 11;
            this.label19.Text = "Diabetes";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(49, 192);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(74, 16);
            this.label18.TabIndex = 10;
            this.label18.Text = "Epilepsia";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(349, 49);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(109, 16);
            this.label17.TabIndex = 9;
            this.label17.Text = "Gastroenteritis";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(349, 148);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(83, 16);
            this.label16.TabIndex = 8;
            this.label16.Text = "Sarampion";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(49, 170);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(151, 16);
            this.label14.TabIndex = 6;
            this.label14.Text = "Enfermedad Urinaria";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(349, 77);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 16);
            this.label13.TabIndex = 5;
            this.label13.Text = "Hepatitis";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(349, 101);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 16);
            this.label12.TabIndex = 4;
            this.label12.Text = "Otitis";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(49, 125);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 16);
            this.label11.TabIndex = 3;
            this.label11.Text = "Convulsiones";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(349, 170);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 16);
            this.label10.TabIndex = 2;
            this.label10.Text = "Varicela";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(52, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 16);
            this.label9.TabIndex = 1;
            this.label9.Text = "Anginas";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(349, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Rubeola";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_nroAfiliado);
            this.groupBox1.Controls.Add(this.lbl_grupoSanguineo);
            this.groupBox1.Controls.Add(this.lbl_obraSocial);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbl_nombre);
            this.groupBox1.Controls.Add(this.lbl_apellido);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(12, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(590, 135);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cargar datos del miliciano";
            // 
            // lbl_nroAfiliado
            // 
            this.lbl_nroAfiliado.AutoSize = true;
            this.lbl_nroAfiliado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nroAfiliado.Location = new System.Drawing.Point(151, 97);
            this.lbl_nroAfiliado.Name = "lbl_nroAfiliado";
            this.lbl_nroAfiliado.Size = new System.Drawing.Size(0, 16);
            this.lbl_nroAfiliado.TabIndex = 66;
            // 
            // lbl_grupoSanguineo
            // 
            this.lbl_grupoSanguineo.AutoSize = true;
            this.lbl_grupoSanguineo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_grupoSanguineo.Location = new System.Drawing.Point(485, 67);
            this.lbl_grupoSanguineo.Name = "lbl_grupoSanguineo";
            this.lbl_grupoSanguineo.Size = new System.Drawing.Size(0, 16);
            this.lbl_grupoSanguineo.TabIndex = 65;
            // 
            // lbl_obraSocial
            // 
            this.lbl_obraSocial.AutoSize = true;
            this.lbl_obraSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_obraSocial.Location = new System.Drawing.Point(151, 67);
            this.lbl_obraSocial.Name = "lbl_obraSocial";
            this.lbl_obraSocial.Size = new System.Drawing.Size(0, 16);
            this.lbl_obraSocial.TabIndex = 64;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(338, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 16);
            this.label7.TabIndex = 63;
            this.label7.Text = "Grupo Sanguineo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(53, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 62;
            this.label4.Text = "Nro Afiliado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 60;
            this.label1.Text = "Obra Social";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.Location = new System.Drawing.Point(435, 40);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(0, 16);
            this.lbl_nombre.TabIndex = 59;
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_apellido.Location = new System.Drawing.Point(151, 40);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(0, 16);
            this.lbl_apellido.TabIndex = 58;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(53, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 56;
            this.label5.Text = "Apellido";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(338, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 57;
            this.label6.Text = "Nombre";
            // 
            // Frm_buscarFichaMedica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 649);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_buscarFichaMedica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Ficha Medica";
            this.Load += new System.EventHandler(this.Frm_buscarFichaMedica_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_apellido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_nroAfiliado;
        private System.Windows.Forms.Label lbl_grupoSanguineo;
        private System.Windows.Forms.Label lbl_obraSocial;
        private System.Windows.Forms.Label lbl_alergia;
        private System.Windows.Forms.Label lbl_varicela;
        private System.Windows.Forms.Label lbl_rubeola;
        private System.Windows.Forms.Label lbl_sarampion;
        private System.Windows.Forms.Label lbl_otitis;
        private System.Windows.Forms.Label lbl_hrpatitis;
        private System.Windows.Forms.Label lbl_gastroenteritis;
        private System.Windows.Forms.Label lbl_celiaquia;
        private System.Windows.Forms.Label lbl_epilepsia;
        private System.Windows.Forms.Label lbl_urinaria;
        private System.Windows.Forms.Label lbl_diabetes;
        private System.Windows.Forms.Label lbl_convulsiones;
        private System.Windows.Forms.Label lbl_bronquitis;
        private System.Windows.Forms.Label lbl_anginas;
        private System.Windows.Forms.Label lbl_completa;
        private System.Windows.Forms.Label lbl_antitetanica;
    }
}