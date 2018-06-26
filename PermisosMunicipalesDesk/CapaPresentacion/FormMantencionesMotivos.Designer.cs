namespace CapaPresentacion
{
    partial class FormMantencionesMotivos
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMotivos = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtRutMotivos = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnGuardarMotivo = new System.Windows.Forms.Button();
            this.btnEliminarMotivo = new System.Windows.Forms.Button();
            this.btnActualizarMotivo = new System.Windows.Forms.Button();
            this.txtMotivos = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMotivos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // dgvMotivos
            // 
            this.dgvMotivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMotivos.Location = new System.Drawing.Point(16, 20);
            this.dgvMotivos.Name = "dgvMotivos";
            this.dgvMotivos.Size = new System.Drawing.Size(573, 200);
            this.dgvMotivos.TabIndex = 3;
            this.dgvMotivos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMotivos_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlText;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtRutMotivos);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Location = new System.Drawing.Point(17, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 91);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingresa el rut a buscar";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMotivos);
            this.groupBox2.Controls.Add(this.btnGuardarMotivo);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox2.Location = new System.Drawing.Point(15, 109);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(276, 218);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ingresa el Tipo de Motivo";
            // 
            // txtRutMotivos
            // 
            this.txtRutMotivos.Location = new System.Drawing.Point(22, 40);
            this.txtRutMotivos.Name = "txtRutMotivos";
            this.txtRutMotivos.Size = new System.Drawing.Size(100, 21);
            this.txtRutMotivos.TabIndex = 4;
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
            this.button1.TabIndex = 16;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvMotivos);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox3.Location = new System.Drawing.Point(298, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(602, 232);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Motivos Disponibles";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnEliminarMotivo);
            this.groupBox4.Controls.Add(this.btnActualizarMotivo);
            this.groupBox4.Location = new System.Drawing.Point(297, 251);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(603, 76);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            // 
            // btnGuardarMotivo
            // 
            this.btnGuardarMotivo.BackColor = System.Drawing.Color.DimGray;
            this.btnGuardarMotivo.FlatAppearance.BorderSize = 0;
            this.btnGuardarMotivo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnGuardarMotivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarMotivo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarMotivo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGuardarMotivo.Location = new System.Drawing.Point(147, 172);
            this.btnGuardarMotivo.Name = "btnGuardarMotivo";
            this.btnGuardarMotivo.Size = new System.Drawing.Size(114, 27);
            this.btnGuardarMotivo.TabIndex = 16;
            this.btnGuardarMotivo.Text = "Guardar";
            this.btnGuardarMotivo.UseVisualStyleBackColor = false;
            this.btnGuardarMotivo.Click += new System.EventHandler(this.btnGuardarMotivo_Click);
            // 
            // btnEliminarMotivo
            // 
            this.btnEliminarMotivo.BackColor = System.Drawing.Color.DimGray;
            this.btnEliminarMotivo.FlatAppearance.BorderSize = 0;
            this.btnEliminarMotivo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnEliminarMotivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarMotivo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarMotivo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEliminarMotivo.Location = new System.Drawing.Point(315, 30);
            this.btnEliminarMotivo.Name = "btnEliminarMotivo";
            this.btnEliminarMotivo.Size = new System.Drawing.Size(171, 27);
            this.btnEliminarMotivo.TabIndex = 19;
            this.btnEliminarMotivo.Text = "Eliminar";
            this.btnEliminarMotivo.UseVisualStyleBackColor = false;
            // 
            // btnActualizarMotivo
            // 
            this.btnActualizarMotivo.BackColor = System.Drawing.Color.DimGray;
            this.btnActualizarMotivo.FlatAppearance.BorderSize = 0;
            this.btnActualizarMotivo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnActualizarMotivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarMotivo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarMotivo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnActualizarMotivo.Location = new System.Drawing.Point(112, 30);
            this.btnActualizarMotivo.Name = "btnActualizarMotivo";
            this.btnActualizarMotivo.Size = new System.Drawing.Size(171, 27);
            this.btnActualizarMotivo.TabIndex = 18;
            this.btnActualizarMotivo.Text = "Actualizar";
            this.btnActualizarMotivo.UseVisualStyleBackColor = false;
            // 
            // txtMotivos
            // 
            this.txtMotivos.Location = new System.Drawing.Point(24, 30);
            this.txtMotivos.Multiline = true;
            this.txtMotivos.Name = "txtMotivos";
            this.txtMotivos.Size = new System.Drawing.Size(237, 94);
            this.txtMotivos.TabIndex = 17;
            // 
            // FormMantencionesMotivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(936, 364);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(0, 40);
            this.Name = "FormMantencionesMotivos";
            this.Text = "FormMantencionesMotivos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMotivos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dgvMotivos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtRutMotivos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnGuardarMotivo;
        private System.Windows.Forms.Button btnEliminarMotivo;
        private System.Windows.Forms.Button btnActualizarMotivo;
        private System.Windows.Forms.TextBox txtMotivos;
    }
}