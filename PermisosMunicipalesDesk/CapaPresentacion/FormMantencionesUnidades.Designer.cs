namespace CapaPresentacion
{
    partial class FormMantencionesUnidades
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtidUnidad = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNomCargo = new System.Windows.Forms.TextBox();
            this.btnGuardarUnidad = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvUnidad = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnEliminarUnidad = new System.Windows.Forms.Button();
            this.btnActualizarUnidad = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnidad)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtidUnidad);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Location = new System.Drawing.Point(17, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 91);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingresa el id a buscar";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(145, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 27);
            this.button1.TabIndex = 24;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtidUnidad
            // 
            this.txtidUnidad.Location = new System.Drawing.Point(22, 40);
            this.txtidUnidad.Name = "txtidUnidad";
            this.txtidUnidad.Size = new System.Drawing.Size(100, 21);
            this.txtidUnidad.TabIndex = 20;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtNomCargo);
            this.groupBox2.Controls.Add(this.btnGuardarUnidad);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox2.Location = new System.Drawing.Point(15, 109);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(276, 136);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ingresa la Unidad";
            // 
            // txtNomCargo
            // 
            this.txtNomCargo.Location = new System.Drawing.Point(24, 64);
            this.txtNomCargo.Name = "txtNomCargo";
            this.txtNomCargo.Size = new System.Drawing.Size(100, 21);
            this.txtNomCargo.TabIndex = 24;
            // 
            // btnGuardarUnidad
            // 
            this.btnGuardarUnidad.BackColor = System.Drawing.Color.DimGray;
            this.btnGuardarUnidad.FlatAppearance.BorderSize = 0;
            this.btnGuardarUnidad.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnGuardarUnidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarUnidad.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarUnidad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGuardarUnidad.Location = new System.Drawing.Point(147, 64);
            this.btnGuardarUnidad.Name = "btnGuardarUnidad";
            this.btnGuardarUnidad.Size = new System.Drawing.Size(114, 27);
            this.btnGuardarUnidad.TabIndex = 23;
            this.btnGuardarUnidad.Text = "Guardar";
            this.btnGuardarUnidad.UseVisualStyleBackColor = false;
            this.btnGuardarUnidad.Click += new System.EventHandler(this.btnGuardarUnidad_Click_1);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvUnidad);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox3.Location = new System.Drawing.Point(298, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(602, 232);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Unidades Disponibles";
            // 
            // dgvUnidad
            // 
            this.dgvUnidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnidad.Location = new System.Drawing.Point(16, 20);
            this.dgvUnidad.Name = "dgvUnidad";
            this.dgvUnidad.Size = new System.Drawing.Size(573, 200);
            this.dgvUnidad.TabIndex = 21;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnEliminarUnidad);
            this.groupBox4.Controls.Add(this.btnActualizarUnidad);
            this.groupBox4.Location = new System.Drawing.Point(15, 251);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(885, 76);
            this.groupBox4.TabIndex = 27;
            this.groupBox4.TabStop = false;
            // 
            // btnEliminarUnidad
            // 
            this.btnEliminarUnidad.BackColor = System.Drawing.Color.DimGray;
            this.btnEliminarUnidad.FlatAppearance.BorderSize = 0;
            this.btnEliminarUnidad.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnEliminarUnidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarUnidad.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarUnidad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEliminarUnidad.Location = new System.Drawing.Point(441, 27);
            this.btnEliminarUnidad.Name = "btnEliminarUnidad";
            this.btnEliminarUnidad.Size = new System.Drawing.Size(171, 27);
            this.btnEliminarUnidad.TabIndex = 26;
            this.btnEliminarUnidad.Text = "Eliminar";
            this.btnEliminarUnidad.UseVisualStyleBackColor = false;
            this.btnEliminarUnidad.Click += new System.EventHandler(this.btnEliminarUnidad_Click);
            // 
            // btnActualizarUnidad
            // 
            this.btnActualizarUnidad.BackColor = System.Drawing.Color.DimGray;
            this.btnActualizarUnidad.FlatAppearance.BorderSize = 0;
            this.btnActualizarUnidad.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnActualizarUnidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarUnidad.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarUnidad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnActualizarUnidad.Location = new System.Drawing.Point(238, 27);
            this.btnActualizarUnidad.Name = "btnActualizarUnidad";
            this.btnActualizarUnidad.Size = new System.Drawing.Size(171, 27);
            this.btnActualizarUnidad.TabIndex = 25;
            this.btnActualizarUnidad.Text = "Actualizar";
            this.btnActualizarUnidad.UseVisualStyleBackColor = false;
            // 
            // FormMantencionesUnidades
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
            this.Name = "FormMantencionesUnidades";
            this.Text = "FormMantencionesUnidades";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnidad)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtidUnidad;
        private System.Windows.Forms.Button btnGuardarUnidad;
        public System.Windows.Forms.DataGridView dgvUnidad;
        private System.Windows.Forms.Button btnEliminarUnidad;
        private System.Windows.Forms.Button btnActualizarUnidad;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNomCargo;
    }
}