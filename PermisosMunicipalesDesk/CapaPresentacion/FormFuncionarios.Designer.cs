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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFuncionarios));
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.FFRefresh = new System.Windows.Forms.Button();
            this.EliminarBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtrut = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.txtapp = new System.Windows.Forms.TextBox();
            this.txtapm = new System.Windows.Forms.TextBox();
            this.dtpFecha_Contrato = new System.Windows.Forms.DateTimePicker();
            this.txtmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbsex = new System.Windows.Forms.ComboBox();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbtipouser = new System.Windows.Forms.ComboBox();
            this.cbcargo = new System.Windows.Forms.ComboBox();
            this.cbdepto = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.DGVListarPersonal = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListarPersonal)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.DimGray;
            this.BtnAgregar.FlatAppearance.BorderSize = 0;
            this.BtnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnAgregar.Location = new System.Drawing.Point(150, 454);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(197, 40);
            this.BtnAgregar.TabIndex = 1;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // FFRefresh
            // 
            this.FFRefresh.BackColor = System.Drawing.Color.DimGray;
            this.FFRefresh.FlatAppearance.BorderSize = 0;
            this.FFRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.FFRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FFRefresh.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FFRefresh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FFRefresh.Location = new System.Drawing.Point(366, 454);
            this.FFRefresh.Name = "FFRefresh";
            this.FFRefresh.Size = new System.Drawing.Size(197, 40);
            this.FFRefresh.TabIndex = 2;
            this.FFRefresh.Text = "Actualizar";
            this.FFRefresh.UseVisualStyleBackColor = false;
            this.FFRefresh.Click += new System.EventHandler(this.button1_Click);
            // 
            // EliminarBtn
            // 
            this.EliminarBtn.BackColor = System.Drawing.Color.DimGray;
            this.EliminarBtn.FlatAppearance.BorderSize = 0;
            this.EliminarBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.EliminarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EliminarBtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.EliminarBtn.Location = new System.Drawing.Point(581, 454);
            this.EliminarBtn.Name = "EliminarBtn";
            this.EliminarBtn.Size = new System.Drawing.Size(197, 40);
            this.EliminarBtn.TabIndex = 3;
            this.EliminarBtn.Text = "Eliminar";
            this.EliminarBtn.UseVisualStyleBackColor = false;
            this.EliminarBtn.Click += new System.EventHandler(this.EliminarBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(936, 40);
            this.panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(912, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 16);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
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
            // txtrut
            // 
            this.txtrut.Location = new System.Drawing.Point(25, 63);
            this.txtrut.Name = "txtrut";
            this.txtrut.Size = new System.Drawing.Size(97, 20);
            this.txtrut.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(22, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Rut";
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(149, 63);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(159, 20);
            this.txtnom.TabIndex = 9;
            // 
            // txtapp
            // 
            this.txtapp.Location = new System.Drawing.Point(314, 63);
            this.txtapp.Name = "txtapp";
            this.txtapp.Size = new System.Drawing.Size(124, 20);
            this.txtapp.TabIndex = 10;
            // 
            // txtapm
            // 
            this.txtapm.Location = new System.Drawing.Point(444, 63);
            this.txtapm.Name = "txtapm";
            this.txtapm.Size = new System.Drawing.Size(118, 20);
            this.txtapm.TabIndex = 11;
            // 
            // dtpFecha_Contrato
            // 
            this.dtpFecha_Contrato.Location = new System.Drawing.Point(568, 63);
            this.dtpFecha_Contrato.Name = "dtpFecha_Contrato";
            this.dtpFecha_Contrato.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha_Contrato.TabIndex = 12;
            this.dtpFecha_Contrato.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txtmail
            // 
            this.txtmail.Location = new System.Drawing.Point(25, 110);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(197, 20);
            this.txtmail.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(146, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(311, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Ap. Paterno";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(441, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "Ap Materno";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(565, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "Fecha de Contratación";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(22, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 15);
            this.label7.TabIndex = 19;
            this.label7.Text = "Correo Electronico";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(226, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 15);
            this.label8.TabIndex = 20;
            this.label8.Text = "Sexo";
            // 
            // cbsex
            // 
            this.cbsex.FormattingEnabled = true;
            this.cbsex.Location = new System.Drawing.Point(229, 109);
            this.cbsex.Name = "cbsex";
            this.cbsex.Size = new System.Drawing.Size(58, 21);
            this.cbsex.TabIndex = 21;
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(293, 110);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(197, 20);
            this.txtuser.TabIndex = 22;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(509, 110);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(197, 20);
            this.txtpass.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(290, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 15);
            this.label9.TabIndex = 24;
            this.label9.Text = "Usuario";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(506, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 15);
            this.label10.TabIndex = 25;
            this.label10.Text = "Clave";
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
            this.cbtipouser.Location = new System.Drawing.Point(712, 109);
            this.cbtipouser.Name = "cbtipouser";
            this.cbtipouser.Size = new System.Drawing.Size(118, 21);
            this.cbtipouser.TabIndex = 26;
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
            this.cbcargo.Location = new System.Drawing.Point(25, 153);
            this.cbcargo.Name = "cbcargo";
            this.cbcargo.Size = new System.Drawing.Size(117, 21);
            this.cbcargo.TabIndex = 27;
            // 
            // cbdepto
            // 
            this.cbdepto.FormattingEnabled = true;
            this.cbdepto.Items.AddRange(new object[] {
            "Administración",
            "Finanzas",
            "Alcaldia",
            "Transito"});
            this.cbdepto.Location = new System.Drawing.Point(149, 153);
            this.cbdepto.Name = "cbdepto";
            this.cbdepto.Size = new System.Drawing.Size(117, 21);
            this.cbdepto.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.Location = new System.Drawing.Point(709, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 15);
            this.label11.TabIndex = 29;
            this.label11.Text = "Tipo de Usuario";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label12.Location = new System.Drawing.Point(22, 137);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 15);
            this.label12.TabIndex = 30;
            this.label12.Text = "Cargo";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label13.Location = new System.Drawing.Point(172, 137);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 15);
            this.label13.TabIndex = 31;
            this.label13.Text = "Departamento";
            // 
            // DGVListarPersonal
            // 
            this.DGVListarPersonal.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.DGVListarPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVListarPersonal.Location = new System.Drawing.Point(16, 192);
            this.DGVListarPersonal.Name = "DGVListarPersonal";
            this.DGVListarPersonal.Size = new System.Drawing.Size(908, 248);
            this.DGVListarPersonal.TabIndex = 32;
            this.DGVListarPersonal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVListarPersonal_CellContentClick);
            // 
            // FormFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(936, 506);
            this.Controls.Add(this.DGVListarPersonal);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbdepto);
            this.Controls.Add(this.cbcargo);
            this.Controls.Add(this.cbtipouser);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.cbsex);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtmail);
            this.Controls.Add(this.dtpFecha_Contrato);
            this.Controls.Add(this.txtapm);
            this.Controls.Add(this.txtapp);
            this.Controls.Add(this.txtnom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtrut);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.EliminarBtn);
            this.Controls.Add(this.FFRefresh);
            this.Controls.Add(this.BtnAgregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormFuncionarios";
            this.Text = "FormFuncionarios";
            this.Load += new System.EventHandler(this.FormFuncionarios_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListarPersonal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button FFRefresh;
        private System.Windows.Forms.Button EliminarBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtrut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.TextBox txtapp;
        private System.Windows.Forms.TextBox txtapm;
        private System.Windows.Forms.DateTimePicker dtpFecha_Contrato;
        private System.Windows.Forms.TextBox txtmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbsex;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbtipouser;
        private System.Windows.Forms.ComboBox cbcargo;
        private System.Windows.Forms.ComboBox cbdepto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.DataGridView DGVListarPersonal;
    }
}