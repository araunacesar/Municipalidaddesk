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
            this.btnEliminarUnidad = new System.Windows.Forms.Button();
            this.btnActualizarUnidad = new System.Windows.Forms.Button();
            this.btnGuardarMotivo = new System.Windows.Forms.Button();
            this.dgvUnidad = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnidad)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminarUnidad
            // 
            this.btnEliminarUnidad.BackColor = System.Drawing.Color.DimGray;
            this.btnEliminarUnidad.FlatAppearance.BorderSize = 0;
            this.btnEliminarUnidad.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnEliminarUnidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarUnidad.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarUnidad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEliminarUnidad.Location = new System.Drawing.Point(703, 300);
            this.btnEliminarUnidad.Name = "btnEliminarUnidad";
            this.btnEliminarUnidad.Size = new System.Drawing.Size(197, 27);
            this.btnEliminarUnidad.TabIndex = 24;
            this.btnEliminarUnidad.Text = "Guardar";
            this.btnEliminarUnidad.UseVisualStyleBackColor = false;
            // 
            // btnActualizarUnidad
            // 
            this.btnActualizarUnidad.BackColor = System.Drawing.Color.DimGray;
            this.btnActualizarUnidad.FlatAppearance.BorderSize = 0;
            this.btnActualizarUnidad.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnActualizarUnidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarUnidad.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarUnidad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnActualizarUnidad.Location = new System.Drawing.Point(500, 300);
            this.btnActualizarUnidad.Name = "btnActualizarUnidad";
            this.btnActualizarUnidad.Size = new System.Drawing.Size(197, 27);
            this.btnActualizarUnidad.TabIndex = 23;
            this.btnActualizarUnidad.Text = "Actualizar";
            this.btnActualizarUnidad.UseVisualStyleBackColor = false;
            // 
            // btnGuardarMotivo
            // 
            this.btnGuardarMotivo.BackColor = System.Drawing.Color.DimGray;
            this.btnGuardarMotivo.FlatAppearance.BorderSize = 0;
            this.btnGuardarMotivo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnGuardarMotivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarMotivo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarMotivo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGuardarMotivo.Location = new System.Drawing.Point(297, 300);
            this.btnGuardarMotivo.Name = "btnGuardarMotivo";
            this.btnGuardarMotivo.Size = new System.Drawing.Size(197, 27);
            this.btnGuardarMotivo.TabIndex = 22;
            this.btnGuardarMotivo.Text = "Guardar";
            this.btnGuardarMotivo.UseVisualStyleBackColor = false;
            // 
            // dgvUnidad
            // 
            this.dgvUnidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnidad.Location = new System.Drawing.Point(297, 12);
            this.dgvUnidad.Name = "dgvUnidad";
            this.dgvUnidad.Size = new System.Drawing.Size(603, 282);
            this.dgvUnidad.TabIndex = 20;
            this.dgvUnidad.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUnidad_CellContentClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(122, 20);
            this.textBox1.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlText;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Ingresa el ID que buscas";
            // 
            // FormMantencionesUnidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(936, 364);
            this.Controls.Add(this.btnEliminarUnidad);
            this.Controls.Add(this.btnActualizarUnidad);
            this.Controls.Add(this.btnGuardarMotivo);
            this.Controls.Add(this.dgvUnidad);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(12, 118);
            this.Name = "FormMantencionesUnidades";
            this.Text = "FormMantencionesUnidades";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminarUnidad;
        private System.Windows.Forms.Button btnActualizarUnidad;
        private System.Windows.Forms.Button btnGuardarMotivo;
        public System.Windows.Forms.DataGridView dgvUnidad;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
    }
}