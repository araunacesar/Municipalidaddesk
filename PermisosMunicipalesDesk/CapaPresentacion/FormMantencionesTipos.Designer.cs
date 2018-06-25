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
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgvTipos = new System.Windows.Forms.DataGridView();
            this.btnEliminarTipos = new System.Windows.Forms.Button();
            this.btnGuardarTipos = new System.Windows.Forms.Button();
            this.btnActualizarTipos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipos)).BeginInit();
            this.SuspendLayout();
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 19;
            // 
            // dgvTipos
            // 
            this.dgvTipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipos.Location = new System.Drawing.Point(297, 12);
            this.dgvTipos.Name = "dgvTipos";
            this.dgvTipos.Size = new System.Drawing.Size(603, 313);
            this.dgvTipos.TabIndex = 20;
            this.dgvTipos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTipos_CellContentClick);
            // 
            // btnEliminarTipos
            // 
            this.btnEliminarTipos.BackColor = System.Drawing.Color.DimGray;
            this.btnEliminarTipos.FlatAppearance.BorderSize = 0;
            this.btnEliminarTipos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnEliminarTipos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarTipos.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarTipos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEliminarTipos.Location = new System.Drawing.Point(703, 331);
            this.btnEliminarTipos.Name = "btnEliminarTipos";
            this.btnEliminarTipos.Size = new System.Drawing.Size(197, 27);
            this.btnEliminarTipos.TabIndex = 24;
            this.btnEliminarTipos.Text = "Eliminar";
            this.btnEliminarTipos.UseVisualStyleBackColor = false;
            // 
            // btnGuardarTipos
            // 
            this.btnGuardarTipos.BackColor = System.Drawing.Color.DimGray;
            this.btnGuardarTipos.FlatAppearance.BorderSize = 0;
            this.btnGuardarTipos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnGuardarTipos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarTipos.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarTipos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGuardarTipos.Location = new System.Drawing.Point(297, 331);
            this.btnGuardarTipos.Name = "btnGuardarTipos";
            this.btnGuardarTipos.Size = new System.Drawing.Size(197, 27);
            this.btnGuardarTipos.TabIndex = 22;
            this.btnGuardarTipos.Text = "Guardar";
            this.btnGuardarTipos.UseVisualStyleBackColor = false;
            // 
            // btnActualizarTipos
            // 
            this.btnActualizarTipos.BackColor = System.Drawing.Color.DimGray;
            this.btnActualizarTipos.FlatAppearance.BorderSize = 0;
            this.btnActualizarTipos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnActualizarTipos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarTipos.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarTipos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnActualizarTipos.Location = new System.Drawing.Point(500, 331);
            this.btnActualizarTipos.Name = "btnActualizarTipos";
            this.btnActualizarTipos.Size = new System.Drawing.Size(197, 27);
            this.btnActualizarTipos.TabIndex = 23;
            this.btnActualizarTipos.Text = "Actualizar";
            this.btnActualizarTipos.UseVisualStyleBackColor = false;
            // 
            // FormMantencionesTipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(912, 370);
            this.Controls.Add(this.btnEliminarTipos);
            this.Controls.Add(this.btnActualizarTipos);
            this.Controls.Add(this.btnGuardarTipos);
            this.Controls.Add(this.dgvTipos);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(12, 118);
            this.Name = "FormMantencionesTipos";
            this.Text = "FormMantencionesTipos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.DataGridView dgvTipos;
        private System.Windows.Forms.Button btnEliminarTipos;
        private System.Windows.Forms.Button btnGuardarTipos;
        private System.Windows.Forms.Button btnActualizarTipos;
    }
}