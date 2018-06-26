namespace CapaPresentacion
{
    partial class FormDescargas
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
            this.txtDescargarPermisos = new System.Windows.Forms.TextBox();
            this.BtnDescargarPermisos = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DGVDescargas = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDescargas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(936, 40);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descargas";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDescargarPermisos);
            this.groupBox1.Controls.Add(this.BtnDescargarPermisos);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Location = new System.Drawing.Point(12, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(904, 130);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingresa el rut a consultar";
            // 
            // txtDescargarPermisos
            // 
            this.txtDescargarPermisos.Location = new System.Drawing.Point(15, 55);
            this.txtDescargarPermisos.Name = "txtDescargarPermisos";
            this.txtDescargarPermisos.Size = new System.Drawing.Size(100, 21);
            this.txtDescargarPermisos.TabIndex = 6;
            // 
            // BtnDescargarPermisos
            // 
            this.BtnDescargarPermisos.BackColor = System.Drawing.Color.DimGray;
            this.BtnDescargarPermisos.FlatAppearance.BorderSize = 0;
            this.BtnDescargarPermisos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BtnDescargarPermisos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDescargarPermisos.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDescargarPermisos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnDescargarPermisos.Location = new System.Drawing.Point(690, 55);
            this.BtnDescargarPermisos.Name = "BtnDescargarPermisos";
            this.BtnDescargarPermisos.Size = new System.Drawing.Size(197, 40);
            this.BtnDescargarPermisos.TabIndex = 5;
            this.BtnDescargarPermisos.Text = "Descargar";
            this.BtnDescargarPermisos.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DGVDescargas);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox2.Location = new System.Drawing.Point(12, 190);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(904, 304);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Descargas Disponibles";
            // 
            // DGVDescargas
            // 
            this.DGVDescargas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVDescargas.Location = new System.Drawing.Point(15, 34);
            this.DGVDescargas.Name = "DGVDescargas";
            this.DGVDescargas.Size = new System.Drawing.Size(872, 165);
            this.DGVDescargas.TabIndex = 6;
            // 
            // FormDescargas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(936, 506);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDescargas";
            this.Text = "FormDescargas";
            this.Load += new System.EventHandler(this.FormDescargas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVDescargas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDescargarPermisos;
        private System.Windows.Forms.Button BtnDescargarPermisos;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.DataGridView DGVDescargas;
    }
}