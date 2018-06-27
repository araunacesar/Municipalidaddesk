namespace CapaPresentacion
{
    partial class FormMantencionesTipos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGuardarTipos = new System.Windows.Forms.Button();
            this.txtTiposPermiso = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBuscarTipos = new System.Windows.Forms.Button();
            this.txtIdTipos = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvTipos = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnEliminarTipos = new System.Windows.Forms.Button();
            this.btnActualizarTipos = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipos)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGuardarTipos);
            this.groupBox1.Controls.Add(this.txtTiposPermiso);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Location = new System.Drawing.Point(15, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 136);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingresa un tipo de Permisos";
            // 
            // btnGuardarTipos
            // 
            this.btnGuardarTipos.BackColor = System.Drawing.Color.DimGray;
            this.btnGuardarTipos.FlatAppearance.BorderSize = 0;
            this.btnGuardarTipos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnGuardarTipos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarTipos.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarTipos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGuardarTipos.Location = new System.Drawing.Point(147, 64);
            this.btnGuardarTipos.Name = "btnGuardarTipos";
            this.btnGuardarTipos.Size = new System.Drawing.Size(114, 27);
            this.btnGuardarTipos.TabIndex = 26;
            this.btnGuardarTipos.Text = "Guardar";
            this.btnGuardarTipos.UseVisualStyleBackColor = false;
            this.btnGuardarTipos.Click += new System.EventHandler(this.btnGuardarTipos_Click_1);
            // 
            // txtTiposPermiso
            // 
            this.txtTiposPermiso.Location = new System.Drawing.Point(24, 64);
            this.txtTiposPermiso.Name = "txtTiposPermiso";
            this.txtTiposPermiso.Size = new System.Drawing.Size(100, 21);
            this.txtTiposPermiso.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBuscarTipos);
            this.groupBox2.Controls.Add(this.txtIdTipos);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox2.Location = new System.Drawing.Point(17, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(274, 91);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ingresa el id a buscar";
            // 
            // btnBuscarTipos
            // 
            this.btnBuscarTipos.BackColor = System.Drawing.Color.DimGray;
            this.btnBuscarTipos.FlatAppearance.BorderSize = 0;
            this.btnBuscarTipos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnBuscarTipos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarTipos.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarTipos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuscarTipos.Location = new System.Drawing.Point(145, 40);
            this.btnBuscarTipos.Name = "btnBuscarTipos";
            this.btnBuscarTipos.Size = new System.Drawing.Size(114, 27);
            this.btnBuscarTipos.TabIndex = 23;
            this.btnBuscarTipos.Text = "Buscar";
            this.btnBuscarTipos.UseVisualStyleBackColor = false;
            this.btnBuscarTipos.Click += new System.EventHandler(this.btnBuscarTipos_Click);
            // 
            // txtIdTipos
            // 
            this.txtIdTipos.Location = new System.Drawing.Point(22, 40);
            this.txtIdTipos.Name = "txtIdTipos";
            this.txtIdTipos.Size = new System.Drawing.Size(100, 21);
            this.txtIdTipos.TabIndex = 20;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvTipos);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox3.Location = new System.Drawing.Point(298, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(602, 232);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tipos de permisos disponibles";
            // 
            // dgvTipos
            // 
            this.dgvTipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipos.Location = new System.Drawing.Point(16, 20);
            this.dgvTipos.Name = "dgvTipos";
            this.dgvTipos.Size = new System.Drawing.Size(573, 200);
            this.dgvTipos.TabIndex = 21;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnEliminarTipos);
            this.groupBox4.Controls.Add(this.btnActualizarTipos);
            this.groupBox4.Location = new System.Drawing.Point(15, 251);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(885, 76);
            this.groupBox4.TabIndex = 28;
            this.groupBox4.TabStop = false;
            // 
            // btnEliminarTipos
            // 
            this.btnEliminarTipos.BackColor = System.Drawing.Color.DimGray;
            this.btnEliminarTipos.FlatAppearance.BorderSize = 0;
            this.btnEliminarTipos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnEliminarTipos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarTipos.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarTipos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEliminarTipos.Location = new System.Drawing.Point(441, 27);
            this.btnEliminarTipos.Name = "btnEliminarTipos";
            this.btnEliminarTipos.Size = new System.Drawing.Size(171, 27);
            this.btnEliminarTipos.TabIndex = 27;
            this.btnEliminarTipos.Text = "Eliminar";
            this.btnEliminarTipos.UseVisualStyleBackColor = false;
            this.btnEliminarTipos.Click += new System.EventHandler(this.btnEliminarTipos_Click);
            // 
            // btnActualizarTipos
            // 
            this.btnActualizarTipos.BackColor = System.Drawing.Color.DimGray;
            this.btnActualizarTipos.FlatAppearance.BorderSize = 0;
            this.btnActualizarTipos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnActualizarTipos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarTipos.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarTipos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnActualizarTipos.Location = new System.Drawing.Point(238, 27);
            this.btnActualizarTipos.Name = "btnActualizarTipos";
            this.btnActualizarTipos.Size = new System.Drawing.Size(171, 27);
            this.btnActualizarTipos.TabIndex = 26;
            this.btnActualizarTipos.Text = "Actualizar";
            this.btnActualizarTipos.UseVisualStyleBackColor = false;
            this.btnActualizarTipos.Click += new System.EventHandler(this.btnActualizarTipos_Click);
            // 
            // FormMantencionesTipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(936, 364);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(12, 118);
            this.Name = "FormMantencionesTipos";
            this.Text = "FormMantencionesTipos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipos)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTiposPermiso;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtIdTipos;
        private System.Windows.Forms.Button btnBuscarTipos;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.DataGridView dgvTipos;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnEliminarTipos;
        private System.Windows.Forms.Button btnActualizarTipos;
        private System.Windows.Forms.Button btnGuardarTipos;
    }
}