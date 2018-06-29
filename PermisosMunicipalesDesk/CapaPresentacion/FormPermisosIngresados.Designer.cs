namespace CapaPresentacion
{
    partial class FormPermisosIngresados
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
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_rut_permisos = new System.Windows.Forms.TextBox();
            this.BtnConsultarPermisos = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvPermisos = new System.Windows.Forms.DataGridView();
            this.panelTitulo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermisos)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitulo
            // 
            this.panelTitulo.Controls.Add(this.label1);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(936, 40);
            this.panelTitulo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consulta de Permisos";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_rut_permisos);
            this.groupBox1.Controls.Add(this.BtnConsultarPermisos);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Location = new System.Drawing.Point(12, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(904, 130);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingresa el rut a consultar";
            // 
            // txt_rut_permisos
            // 
            this.txt_rut_permisos.Location = new System.Drawing.Point(15, 55);
            this.txt_rut_permisos.Name = "txt_rut_permisos";
            this.txt_rut_permisos.Size = new System.Drawing.Size(100, 21);
            this.txt_rut_permisos.TabIndex = 10;
            // 
            // BtnConsultarPermisos
            // 
            this.BtnConsultarPermisos.BackColor = System.Drawing.Color.DimGray;
            this.BtnConsultarPermisos.FlatAppearance.BorderSize = 0;
            this.BtnConsultarPermisos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BtnConsultarPermisos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConsultarPermisos.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConsultarPermisos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnConsultarPermisos.Location = new System.Drawing.Point(690, 55);
            this.BtnConsultarPermisos.Name = "BtnConsultarPermisos";
            this.BtnConsultarPermisos.Size = new System.Drawing.Size(197, 40);
            this.BtnConsultarPermisos.TabIndex = 9;
            this.BtnConsultarPermisos.Text = "Consultar";
            this.BtnConsultarPermisos.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvPermisos);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.DarkGray;
            this.groupBox2.Location = new System.Drawing.Point(12, 190);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(904, 304);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Permisos solicitados";
            // 
            // dgvPermisos
            // 
            this.dgvPermisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPermisos.Location = new System.Drawing.Point(15, 34);
            this.dgvPermisos.Name = "dgvPermisos";
            this.dgvPermisos.Size = new System.Drawing.Size(872, 165);
            this.dgvPermisos.TabIndex = 10;
            this.dgvPermisos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPermisos_CellContentClick_1);
            // 
            // FormPermisosIngresados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(936, 506);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPermisosIngresados";
            this.Text = "FormPermisosIngresados";
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermisos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_rut_permisos;
        private System.Windows.Forms.Button BtnConsultarPermisos;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.DataGridView dgvPermisos;
    }
}