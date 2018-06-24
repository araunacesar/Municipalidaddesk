namespace CapaPresentacion
{
    partial class FormMantencion
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
            this.TabMantencion = new System.Windows.Forms.TabControl();
            this.TabPageTipos = new System.Windows.Forms.TabPage();
            this.dgvTipos = new System.Windows.Forms.DataGridView();
            this.btnGuardarTipo = new System.Windows.Forms.Button();
            this.btnEliminarTipos = new System.Windows.Forms.Button();
            this.btnActualizarTipos = new System.Windows.Forms.Button();
            this.btnBuscarTipos = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRutTipos = new System.Windows.Forms.TextBox();
            this.TabPageMotivos = new System.Windows.Forms.TabPage();
            this.dgvMotivos = new System.Windows.Forms.DataGridView();
            this.btnGuardarMotivo = new System.Windows.Forms.Button();
            this.btnEliminarMotivo = new System.Windows.Forms.Button();
            this.btnActualizarMotivo = new System.Windows.Forms.Button();
            this.btnBuscarMotivo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRutMotivos = new System.Windows.Forms.TextBox();
            this.TabPageUnidades = new System.Windows.Forms.TabPage();
            this.dgvUnidades = new System.Windows.Forms.DataGridView();
            this.btnGuardarUnidad = new System.Windows.Forms.Button();
            this.btnEliminarUnidad = new System.Windows.Forms.Button();
            this.btnActualizarUnidad = new System.Windows.Forms.Button();
            this.btnBuscarUnidad = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRutUnidades = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.TabMantencion.SuspendLayout();
            this.TabPageTipos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipos)).BeginInit();
            this.TabPageMotivos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMotivos)).BeginInit();
            this.TabPageUnidades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnidades)).BeginInit();
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
            this.label1.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mantenciones";
            // 
            // TabMantencion
            // 
            this.TabMantencion.Controls.Add(this.TabPageTipos);
            this.TabMantencion.Controls.Add(this.TabPageMotivos);
            this.TabMantencion.Controls.Add(this.TabPageUnidades);
            this.TabMantencion.Location = new System.Drawing.Point(16, 57);
            this.TabMantencion.Name = "TabMantencion";
            this.TabMantencion.SelectedIndex = 0;
            this.TabMantencion.Size = new System.Drawing.Size(908, 250);
            this.TabMantencion.TabIndex = 1;
            this.TabMantencion.SelectedIndexChanged += new System.EventHandler(this.TabPageTipos_Click);
            // 
            // TabPageTipos
            // 
            this.TabPageTipos.BackColor = System.Drawing.Color.DimGray;
            this.TabPageTipos.Controls.Add(this.dgvTipos);
            this.TabPageTipos.Controls.Add(this.btnGuardarTipo);
            this.TabPageTipos.Controls.Add(this.btnEliminarTipos);
            this.TabPageTipos.Controls.Add(this.btnActualizarTipos);
            this.TabPageTipos.Controls.Add(this.btnBuscarTipos);
            this.TabPageTipos.Controls.Add(this.label3);
            this.TabPageTipos.Controls.Add(this.label2);
            this.TabPageTipos.Controls.Add(this.txtRutTipos);
            this.TabPageTipos.Location = new System.Drawing.Point(4, 22);
            this.TabPageTipos.Name = "TabPageTipos";
            this.TabPageTipos.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageTipos.Size = new System.Drawing.Size(900, 224);
            this.TabPageTipos.TabIndex = 0;
            this.TabPageTipos.Text = "Tipos";
            this.TabPageTipos.Click += new System.EventHandler(this.TabPageTipos_Click);
            // 
            // dgvTipos
            // 
            this.dgvTipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipos.Location = new System.Drawing.Point(257, 40);
            this.dgvTipos.Name = "dgvTipos";
            this.dgvTipos.Size = new System.Drawing.Size(605, 158);
            this.dgvTipos.TabIndex = 7;
            this.dgvTipos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTipos_CellContentClick);
            // 
            // btnGuardarTipo
            // 
            this.btnGuardarTipo.BackColor = System.Drawing.Color.DarkGray;
            this.btnGuardarTipo.FlatAppearance.BorderSize = 0;
            this.btnGuardarTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarTipo.Location = new System.Drawing.Point(56, 175);
            this.btnGuardarTipo.Name = "btnGuardarTipo";
            this.btnGuardarTipo.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarTipo.TabIndex = 6;
            this.btnGuardarTipo.Text = "Guardar";
            this.btnGuardarTipo.UseVisualStyleBackColor = false;
            // 
            // btnEliminarTipos
            // 
            this.btnEliminarTipos.BackColor = System.Drawing.Color.DarkGray;
            this.btnEliminarTipos.FlatAppearance.BorderSize = 0;
            this.btnEliminarTipos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarTipos.Location = new System.Drawing.Point(56, 146);
            this.btnEliminarTipos.Name = "btnEliminarTipos";
            this.btnEliminarTipos.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarTipos.TabIndex = 5;
            this.btnEliminarTipos.Text = "Eliminar";
            this.btnEliminarTipos.UseVisualStyleBackColor = false;
            // 
            // btnActualizarTipos
            // 
            this.btnActualizarTipos.BackColor = System.Drawing.Color.DarkGray;
            this.btnActualizarTipos.FlatAppearance.BorderSize = 0;
            this.btnActualizarTipos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarTipos.Location = new System.Drawing.Point(56, 117);
            this.btnActualizarTipos.Name = "btnActualizarTipos";
            this.btnActualizarTipos.Size = new System.Drawing.Size(75, 23);
            this.btnActualizarTipos.TabIndex = 4;
            this.btnActualizarTipos.Text = "Actualizar";
            this.btnActualizarTipos.UseVisualStyleBackColor = false;
            // 
            // btnBuscarTipos
            // 
            this.btnBuscarTipos.BackColor = System.Drawing.Color.DarkGray;
            this.btnBuscarTipos.FlatAppearance.BorderSize = 0;
            this.btnBuscarTipos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarTipos.Location = new System.Drawing.Point(56, 88);
            this.btnBuscarTipos.Name = "btnBuscarTipos";
            this.btnBuscarTipos.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarTipos.TabIndex = 3;
            this.btnBuscarTipos.Text = "Buscar";
            this.btnBuscarTipos.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ingresa el Rut que necesitas buscar ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rut";
            // 
            // txtRutTipos
            // 
            this.txtRutTipos.Location = new System.Drawing.Point(56, 40);
            this.txtRutTipos.Name = "txtRutTipos";
            this.txtRutTipos.Size = new System.Drawing.Size(100, 20);
            this.txtRutTipos.TabIndex = 0;
            // 
            // TabPageMotivos
            // 
            this.TabPageMotivos.BackColor = System.Drawing.Color.DimGray;
            this.TabPageMotivos.Controls.Add(this.dgvMotivos);
            this.TabPageMotivos.Controls.Add(this.btnGuardarMotivo);
            this.TabPageMotivos.Controls.Add(this.btnEliminarMotivo);
            this.TabPageMotivos.Controls.Add(this.btnActualizarMotivo);
            this.TabPageMotivos.Controls.Add(this.btnBuscarMotivo);
            this.TabPageMotivos.Controls.Add(this.label4);
            this.TabPageMotivos.Controls.Add(this.label5);
            this.TabPageMotivos.Controls.Add(this.txtRutMotivos);
            this.TabPageMotivos.Location = new System.Drawing.Point(4, 22);
            this.TabPageMotivos.Name = "TabPageMotivos";
            this.TabPageMotivos.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageMotivos.Size = new System.Drawing.Size(900, 224);
            this.TabPageMotivos.TabIndex = 1;
            this.TabPageMotivos.Text = "Motivos";
            this.TabPageMotivos.Click += new System.EventHandler(this.TabPageMotivos_Click);
            // 
            // dgvMotivos
            // 
            this.dgvMotivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMotivos.Location = new System.Drawing.Point(257, 40);
            this.dgvMotivos.Name = "dgvMotivos";
            this.dgvMotivos.Size = new System.Drawing.Size(605, 158);
            this.dgvMotivos.TabIndex = 15;
            this.dgvMotivos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMotivos_CellContentClick);
            // 
            // btnGuardarMotivo
            // 
            this.btnGuardarMotivo.BackColor = System.Drawing.Color.DarkGray;
            this.btnGuardarMotivo.FlatAppearance.BorderSize = 0;
            this.btnGuardarMotivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarMotivo.Location = new System.Drawing.Point(56, 175);
            this.btnGuardarMotivo.Name = "btnGuardarMotivo";
            this.btnGuardarMotivo.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarMotivo.TabIndex = 14;
            this.btnGuardarMotivo.Text = "Guardar";
            this.btnGuardarMotivo.UseVisualStyleBackColor = false;
            // 
            // btnEliminarMotivo
            // 
            this.btnEliminarMotivo.BackColor = System.Drawing.Color.DarkGray;
            this.btnEliminarMotivo.FlatAppearance.BorderSize = 0;
            this.btnEliminarMotivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarMotivo.Location = new System.Drawing.Point(56, 146);
            this.btnEliminarMotivo.Name = "btnEliminarMotivo";
            this.btnEliminarMotivo.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarMotivo.TabIndex = 13;
            this.btnEliminarMotivo.Text = "Eliminar";
            this.btnEliminarMotivo.UseVisualStyleBackColor = false;
            // 
            // btnActualizarMotivo
            // 
            this.btnActualizarMotivo.BackColor = System.Drawing.Color.DarkGray;
            this.btnActualizarMotivo.FlatAppearance.BorderSize = 0;
            this.btnActualizarMotivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarMotivo.Location = new System.Drawing.Point(56, 117);
            this.btnActualizarMotivo.Name = "btnActualizarMotivo";
            this.btnActualizarMotivo.Size = new System.Drawing.Size(75, 23);
            this.btnActualizarMotivo.TabIndex = 12;
            this.btnActualizarMotivo.Text = "Actualizar";
            this.btnActualizarMotivo.UseVisualStyleBackColor = false;
            // 
            // btnBuscarMotivo
            // 
            this.btnBuscarMotivo.BackColor = System.Drawing.Color.DarkGray;
            this.btnBuscarMotivo.FlatAppearance.BorderSize = 0;
            this.btnBuscarMotivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarMotivo.Location = new System.Drawing.Point(56, 88);
            this.btnBuscarMotivo.Name = "btnBuscarMotivo";
            this.btnBuscarMotivo.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarMotivo.TabIndex = 11;
            this.btnBuscarMotivo.Text = "Buscar";
            this.btnBuscarMotivo.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ingresa el Rut que necesitas buscar ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Rut";
            // 
            // txtRutMotivos
            // 
            this.txtRutMotivos.Location = new System.Drawing.Point(56, 40);
            this.txtRutMotivos.Name = "txtRutMotivos";
            this.txtRutMotivos.Size = new System.Drawing.Size(100, 20);
            this.txtRutMotivos.TabIndex = 8;
            // 
            // TabPageUnidades
            // 
            this.TabPageUnidades.BackColor = System.Drawing.Color.DimGray;
            this.TabPageUnidades.Controls.Add(this.dgvUnidades);
            this.TabPageUnidades.Controls.Add(this.btnGuardarUnidad);
            this.TabPageUnidades.Controls.Add(this.btnEliminarUnidad);
            this.TabPageUnidades.Controls.Add(this.btnActualizarUnidad);
            this.TabPageUnidades.Controls.Add(this.btnBuscarUnidad);
            this.TabPageUnidades.Controls.Add(this.label6);
            this.TabPageUnidades.Controls.Add(this.label7);
            this.TabPageUnidades.Controls.Add(this.txtRutUnidades);
            this.TabPageUnidades.Location = new System.Drawing.Point(4, 22);
            this.TabPageUnidades.Name = "TabPageUnidades";
            this.TabPageUnidades.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageUnidades.Size = new System.Drawing.Size(900, 224);
            this.TabPageUnidades.TabIndex = 2;
            this.TabPageUnidades.Text = "Unidades";
            this.TabPageUnidades.Click += new System.EventHandler(this.TabPageUnidades_Click);
            // 
            // dgvUnidades
            // 
            this.dgvUnidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnidades.Location = new System.Drawing.Point(257, 40);
            this.dgvUnidades.Name = "dgvUnidades";
            this.dgvUnidades.Size = new System.Drawing.Size(605, 158);
            this.dgvUnidades.TabIndex = 23;
            this.dgvUnidades.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUnidades_CellContentClick);
            // 
            // btnGuardarUnidad
            // 
            this.btnGuardarUnidad.BackColor = System.Drawing.Color.DarkGray;
            this.btnGuardarUnidad.FlatAppearance.BorderSize = 0;
            this.btnGuardarUnidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarUnidad.Location = new System.Drawing.Point(56, 175);
            this.btnGuardarUnidad.Name = "btnGuardarUnidad";
            this.btnGuardarUnidad.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarUnidad.TabIndex = 22;
            this.btnGuardarUnidad.Text = "Guardar";
            this.btnGuardarUnidad.UseVisualStyleBackColor = false;
            // 
            // btnEliminarUnidad
            // 
            this.btnEliminarUnidad.BackColor = System.Drawing.Color.DarkGray;
            this.btnEliminarUnidad.FlatAppearance.BorderSize = 0;
            this.btnEliminarUnidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarUnidad.Location = new System.Drawing.Point(56, 146);
            this.btnEliminarUnidad.Name = "btnEliminarUnidad";
            this.btnEliminarUnidad.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarUnidad.TabIndex = 21;
            this.btnEliminarUnidad.Text = "Eliminar";
            this.btnEliminarUnidad.UseVisualStyleBackColor = false;
            // 
            // btnActualizarUnidad
            // 
            this.btnActualizarUnidad.BackColor = System.Drawing.Color.DarkGray;
            this.btnActualizarUnidad.FlatAppearance.BorderSize = 0;
            this.btnActualizarUnidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarUnidad.Location = new System.Drawing.Point(56, 117);
            this.btnActualizarUnidad.Name = "btnActualizarUnidad";
            this.btnActualizarUnidad.Size = new System.Drawing.Size(75, 23);
            this.btnActualizarUnidad.TabIndex = 20;
            this.btnActualizarUnidad.Text = "Actualizar";
            this.btnActualizarUnidad.UseVisualStyleBackColor = false;
            // 
            // btnBuscarUnidad
            // 
            this.btnBuscarUnidad.BackColor = System.Drawing.Color.DarkGray;
            this.btnBuscarUnidad.FlatAppearance.BorderSize = 0;
            this.btnBuscarUnidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarUnidad.Location = new System.Drawing.Point(56, 88);
            this.btnBuscarUnidad.Name = "btnBuscarUnidad";
            this.btnBuscarUnidad.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarUnidad.TabIndex = 19;
            this.btnBuscarUnidad.Text = "Buscar";
            this.btnBuscarUnidad.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Ingresa el Rut que necesitas buscar ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Rut";
            // 
            // txtRutUnidades
            // 
            this.txtRutUnidades.Location = new System.Drawing.Point(56, 40);
            this.txtRutUnidades.Name = "txtRutUnidades";
            this.txtRutUnidades.Size = new System.Drawing.Size(100, 20);
            this.txtRutUnidades.TabIndex = 16;
            // 
            // FormMantencion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(936, 506);
            this.Controls.Add(this.TabMantencion);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMantencion";
            this.Text = "FormMantencion";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.TabMantencion.ResumeLayout(false);
            this.TabPageTipos.ResumeLayout(false);
            this.TabPageTipos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipos)).EndInit();
            this.TabPageMotivos.ResumeLayout(false);
            this.TabPageMotivos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMotivos)).EndInit();
            this.TabPageUnidades.ResumeLayout(false);
            this.TabPageUnidades.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnidades)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl TabMantencion;
        public System.Windows.Forms.TabPage TabPageTipos;
        public System.Windows.Forms.TabPage TabPageMotivos;
        public System.Windows.Forms.TabPage TabPageUnidades;
        public System.Windows.Forms.DataGridView dgvTipos;
        private System.Windows.Forms.Button btnGuardarTipo;
        private System.Windows.Forms.Button btnEliminarTipos;
        private System.Windows.Forms.Button btnActualizarTipos;
        private System.Windows.Forms.Button btnBuscarTipos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRutTipos;
        public System.Windows.Forms.DataGridView dgvMotivos;
        private System.Windows.Forms.Button btnGuardarMotivo;
        private System.Windows.Forms.Button btnEliminarMotivo;
        private System.Windows.Forms.Button btnActualizarMotivo;
        private System.Windows.Forms.Button btnBuscarMotivo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRutMotivos;
        public System.Windows.Forms.DataGridView dgvUnidades;
        private System.Windows.Forms.Button btnGuardarUnidad;
        private System.Windows.Forms.Button btnEliminarUnidad;
        private System.Windows.Forms.Button btnActualizarUnidad;
        private System.Windows.Forms.Button btnBuscarUnidad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRutUnidades;
    }
}