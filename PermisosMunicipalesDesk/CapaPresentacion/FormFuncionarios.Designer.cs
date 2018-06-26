namespace CapaPresentacion
{
    partial class FormFuncionarios
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbdepto = new System.Windows.Forms.ComboBox();
            this.cbcargo = new System.Windows.Forms.ComboBox();
            this.cbtipouser = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.cbsex = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmail = new System.Windows.Forms.TextBox();
            this.dtpFecha_Contrato = new System.Windows.Forms.DateTimePicker();
            this.txtapm = new System.Windows.Forms.TextBox();
            this.txtapp = new System.Windows.Forms.TextBox();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtrut = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DGVListarPersonal = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.EliminarBtn = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListarPersonal)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(936, 40);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Funcionarios";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cbdepto);
            this.groupBox1.Controls.Add(this.cbcargo);
            this.groupBox1.Controls.Add(this.cbtipouser);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtpass);
            this.groupBox1.Controls.Add(this.txtuser);
            this.groupBox1.Controls.Add(this.cbsex);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtmail);
            this.groupBox1.Controls.Add(this.dtpFecha_Contrato);
            this.groupBox1.Controls.Add(this.txtapm);
            this.groupBox1.Controls.Add(this.txtapp);
            this.groupBox1.Controls.Add(this.txtnom);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtrut);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Location = new System.Drawing.Point(12, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(904, 130);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Funcionario";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label13.Location = new System.Drawing.Point(764, 70);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 15);
            this.label13.TabIndex = 55;
            this.label13.Text = "Departamento";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label12.Location = new System.Drawing.Point(644, 71);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 15);
            this.label12.TabIndex = 54;
            this.label12.Text = "Cargo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.Location = new System.Drawing.Point(517, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 15);
            this.label11.TabIndex = 53;
            this.label11.Text = "Tipo de Usuario";
            // 
            // cbdepto
            // 
            this.cbdepto.FormattingEnabled = true;
            this.cbdepto.Items.AddRange(new object[] {
            "Administración",
            "Finanzas",
            "Alcaldia",
            "Transito"});
            this.cbdepto.Location = new System.Drawing.Point(767, 88);
            this.cbdepto.Name = "cbdepto";
            this.cbdepto.Size = new System.Drawing.Size(117, 23);
            this.cbdepto.TabIndex = 52;
            // 
            // cbcargo
            // 
            this.cbcargo.FormattingEnabled = true;
            this.cbcargo.Items.AddRange(new object[] {
            "Alcalde",
            "Administrador",
            "Funcionario",
            "Jefe Unidad Superior",
            "Jefe Unidad Interna"});
            this.cbcargo.Location = new System.Drawing.Point(644, 88);
            this.cbcargo.Name = "cbcargo";
            this.cbcargo.Size = new System.Drawing.Size(117, 23);
            this.cbcargo.TabIndex = 51;
            // 
            // cbtipouser
            // 
            this.cbtipouser.FormattingEnabled = true;
            this.cbtipouser.Items.AddRange(new object[] {
            "Alcalde",
            "Administrador",
            "Funcionario",
            "Jefe Unidad Superior",
            "Jefe Unidad Interna"});
            this.cbtipouser.Location = new System.Drawing.Point(520, 88);
            this.cbtipouser.Name = "cbtipouser";
            this.cbtipouser.Size = new System.Drawing.Size(118, 23);
            this.cbtipouser.TabIndex = 50;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(393, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 15);
            this.label10.TabIndex = 49;
            this.label10.Text = "Clave";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(249, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 15);
            this.label9.TabIndex = 48;
            this.label9.Text = "Usuario";
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(393, 90);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(113, 21);
            this.txtpass.TabIndex = 47;
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(252, 90);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(135, 21);
            this.txtuser.TabIndex = 46;
            // 
            // cbsex
            // 
            this.cbsex.FormattingEnabled = true;
            this.cbsex.Location = new System.Drawing.Point(188, 89);
            this.cbsex.Name = "cbsex";
            this.cbsex.Size = new System.Drawing.Size(58, 23);
            this.cbsex.TabIndex = 45;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(185, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 15);
            this.label8.TabIndex = 44;
            this.label8.Text = "Sexo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(14, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 15);
            this.label7.TabIndex = 43;
            this.label7.Text = "Correo Electronico";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(552, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 15);
            this.label6.TabIndex = 42;
            this.label6.Text = "Fecha de Contratación";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(422, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 15);
            this.label5.TabIndex = 41;
            this.label5.Text = "Ap Materno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(293, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 15);
            this.label4.TabIndex = 40;
            this.label4.Text = "Ap. Paterno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(128, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 39;
            this.label3.Text = "Nombre";
            // 
            // txtmail
            // 
            this.txtmail.Location = new System.Drawing.Point(17, 90);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(164, 21);
            this.txtmail.TabIndex = 38;
            // 
            // dtpFecha_Contrato
            // 
            this.dtpFecha_Contrato.Location = new System.Drawing.Point(555, 40);
            this.dtpFecha_Contrato.Name = "dtpFecha_Contrato";
            this.dtpFecha_Contrato.Size = new System.Drawing.Size(214, 21);
            this.dtpFecha_Contrato.TabIndex = 37;
            // 
            // txtapm
            // 
            this.txtapm.Location = new System.Drawing.Point(425, 40);
            this.txtapm.Name = "txtapm";
            this.txtapm.Size = new System.Drawing.Size(124, 21);
            this.txtapm.TabIndex = 36;
            // 
            // txtapp
            // 
            this.txtapp.Location = new System.Drawing.Point(296, 40);
            this.txtapp.Name = "txtapp";
            this.txtapp.Size = new System.Drawing.Size(124, 21);
            this.txtapp.TabIndex = 35;
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(131, 40);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(159, 21);
            this.txtnom.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(14, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 15);
            this.label2.TabIndex = 33;
            this.label2.Text = "Rut";
            // 
            // txtrut
            // 
            this.txtrut.Location = new System.Drawing.Point(17, 40);
            this.txtrut.Name = "txtrut";
            this.txtrut.Size = new System.Drawing.Size(108, 21);
            this.txtrut.TabIndex = 32;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DGVListarPersonal);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox2.Location = new System.Drawing.Point(12, 190);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(904, 198);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Funcionarios ";
            // 
            // DGVListarPersonal
            // 
            this.DGVListarPersonal.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.DGVListarPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVListarPersonal.Location = new System.Drawing.Point(15, 34);
            this.DGVListarPersonal.Name = "DGVListarPersonal";
            this.DGVListarPersonal.Size = new System.Drawing.Size(872, 150);
            this.DGVListarPersonal.TabIndex = 33;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnBuscar);
            this.groupBox3.Controls.Add(this.EliminarBtn);
            this.groupBox3.Controls.Add(this.btnActualizar);
            this.groupBox3.Controls.Add(this.BtnAgregar);
            this.groupBox3.Location = new System.Drawing.Point(12, 394);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(904, 100);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.DimGray;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuscar.Location = new System.Drawing.Point(49, 30);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(197, 40);
            this.btnBuscar.TabIndex = 37;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // EliminarBtn
            // 
            this.EliminarBtn.BackColor = System.Drawing.Color.DimGray;
            this.EliminarBtn.FlatAppearance.BorderSize = 0;
            this.EliminarBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.EliminarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EliminarBtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.EliminarBtn.Location = new System.Drawing.Point(658, 30);
            this.EliminarBtn.Name = "EliminarBtn";
            this.EliminarBtn.Size = new System.Drawing.Size(197, 40);
            this.EliminarBtn.TabIndex = 36;
            this.EliminarBtn.Text = "Eliminar";
            this.EliminarBtn.UseVisualStyleBackColor = false;
            this.EliminarBtn.Click += new System.EventHandler(this.EliminarBtn_Click_1);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.DimGray;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnActualizar.Location = new System.Drawing.Point(455, 30);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(197, 40);
            this.btnActualizar.TabIndex = 35;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.DimGray;
            this.BtnAgregar.FlatAppearance.BorderSize = 0;
            this.BtnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnAgregar.Location = new System.Drawing.Point(252, 30);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(197, 40);
            this.BtnAgregar.TabIndex = 34;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click_1);
            // 
            // FormFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(936, 506);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormFuncionarios";
            this.Text = "FormFuncionarios";
            this.Load += new System.EventHandler(this.FormFuncionarios_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVListarPersonal)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbdepto;
        private System.Windows.Forms.ComboBox cbcargo;
        private System.Windows.Forms.ComboBox cbtipouser;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.ComboBox cbsex;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmail;
        private System.Windows.Forms.DateTimePicker dtpFecha_Contrato;
        private System.Windows.Forms.TextBox txtapm;
        private System.Windows.Forms.TextBox txtapp;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtrut;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.DataGridView DGVListarPersonal;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button EliminarBtn;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button BtnAgregar;
    }
}