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
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdMotivos = new System.Windows.Forms.TextBox();
            this.dgvMotivos = new System.Windows.Forms.DataGridView();
            this.btnGuardarMotivo = new System.Windows.Forms.Button();
            this.btnActualizarMotivo = new System.Windows.Forms.Button();
            this.btnEliminarMotivo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMotivos)).BeginInit();
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlText;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingresa el ID que buscas";
            // 
            // txtIdMotivos
            // 
            this.txtIdMotivos.Location = new System.Drawing.Point(15, 51);
            this.txtIdMotivos.Name = "txtIdMotivos";
            this.txtIdMotivos.Size = new System.Drawing.Size(100, 20);
            this.txtIdMotivos.TabIndex = 2;
            // 
            // dgvMotivos
            // 
            this.dgvMotivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMotivos.Location = new System.Drawing.Point(297, 12);
            this.dgvMotivos.Name = "dgvMotivos";
            this.dgvMotivos.Size = new System.Drawing.Size(603, 313);
            this.dgvMotivos.TabIndex = 3;
            this.dgvMotivos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMotivos_CellContentClick);
            // 
            // btnGuardarMotivo
            // 
            this.btnGuardarMotivo.BackColor = System.Drawing.Color.DimGray;
            this.btnGuardarMotivo.FlatAppearance.BorderSize = 0;
            this.btnGuardarMotivo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnGuardarMotivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarMotivo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarMotivo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGuardarMotivo.Location = new System.Drawing.Point(297, 331);
            this.btnGuardarMotivo.Name = "btnGuardarMotivo";
            this.btnGuardarMotivo.Size = new System.Drawing.Size(197, 27);
            this.btnGuardarMotivo.TabIndex = 15;
            this.btnGuardarMotivo.Text = "Guardar";
            this.btnGuardarMotivo.UseVisualStyleBackColor = false;
            // 
            // btnActualizarMotivo
            // 
            this.btnActualizarMotivo.BackColor = System.Drawing.Color.DimGray;
            this.btnActualizarMotivo.FlatAppearance.BorderSize = 0;
            this.btnActualizarMotivo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnActualizarMotivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarMotivo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarMotivo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnActualizarMotivo.Location = new System.Drawing.Point(500, 331);
            this.btnActualizarMotivo.Name = "btnActualizarMotivo";
            this.btnActualizarMotivo.Size = new System.Drawing.Size(197, 27);
            this.btnActualizarMotivo.TabIndex = 16;
            this.btnActualizarMotivo.Text = "Actualizar";
            this.btnActualizarMotivo.UseVisualStyleBackColor = false;
            // 
            // btnEliminarMotivo
            // 
            this.btnEliminarMotivo.BackColor = System.Drawing.Color.DimGray;
            this.btnEliminarMotivo.FlatAppearance.BorderSize = 0;
            this.btnEliminarMotivo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnEliminarMotivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarMotivo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarMotivo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEliminarMotivo.Location = new System.Drawing.Point(703, 331);
            this.btnEliminarMotivo.Name = "btnEliminarMotivo";
            this.btnEliminarMotivo.Size = new System.Drawing.Size(197, 27);
            this.btnEliminarMotivo.TabIndex = 17;
            this.btnEliminarMotivo.Text = "Eliminar";
            this.btnEliminarMotivo.UseVisualStyleBackColor = false;
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
            // FormMantencionesMotivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(912, 370);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEliminarMotivo);
            this.Controls.Add(this.btnActualizarMotivo);
            this.Controls.Add(this.btnGuardarMotivo);
            this.Controls.Add(this.dgvMotivos);
            this.Controls.Add(this.txtIdMotivos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(12, 118);
            this.Name = "FormMantencionesMotivos";
            this.Text = "FormMantencionesMotivos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMotivos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdMotivos;
        public System.Windows.Forms.DataGridView dgvMotivos;
        private System.Windows.Forms.Button btnGuardarMotivo;
        private System.Windows.Forms.Button btnActualizarMotivo;
        private System.Windows.Forms.Button btnEliminarMotivo;
        private System.Windows.Forms.Label label3;
    }
}