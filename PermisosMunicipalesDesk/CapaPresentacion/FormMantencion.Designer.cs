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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtRutTipos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscarTipos = new System.Windows.Forms.Button();
            this.btnActualizarTipos = new System.Windows.Forms.Button();
            this.btnEliminarTipos = new System.Windows.Forms.Button();
            this.btnGuardarTipo = new System.Windows.Forms.Button();
            this.dgvTipos = new System.Windows.Forms.DataGridView();
            this.dgvMotivos = new System.Windows.Forms.DataGridView();
            this.btnGuardarMotivo = new System.Windows.Forms.Button();
            this.btnEliminarMotivo = new System.Windows.Forms.Button();
            this.btnActualizarMotivo = new System.Windows.Forms.Button();
            this.btnBuscarMotivo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRutMotivos = new System.Windows.Forms.TextBox();
            this.dgvUnidades = new System.Windows.Forms.DataGridView();
            this.btnGuardarUnidad = new System.Windows.Forms.Button();
            this.btnEliminarUnidad = new System.Windows.Forms.Button();
            this.btnActualizarUnidad = new System.Windows.Forms.Button();
            this.btnBuscarUnidad = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRutUnidades = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMotivos)).BeginInit();
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(16, 57);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(908, 250);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DimGray;
            this.tabPage1.Controls.Add(this.dgvTipos);
            this.tabPage1.Controls.Add(this.btnGuardarTipo);
            this.tabPage1.Controls.Add(this.btnEliminarTipos);
            this.tabPage1.Controls.Add(this.btnActualizarTipos);
            this.tabPage1.Controls.Add(this.btnBuscarTipos);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtRutTipos);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(900, 224);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tipos";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DimGray;
            this.tabPage2.Controls.Add(this.dgvMotivos);
            this.tabPage2.Controls.Add(this.btnGuardarMotivo);
            this.tabPage2.Controls.Add(this.btnEliminarMotivo);
            this.tabPage2.Controls.Add(this.btnActualizarMotivo);
            this.tabPage2.Controls.Add(this.btnBuscarMotivo);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txtRutMotivos);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(900, 224);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Motivos";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.DimGray;
            this.tabPage3.Controls.Add(this.dgvUnidades);
            this.tabPage3.Controls.Add(this.btnGuardarUnidad);
            this.tabPage3.Controls.Add(this.btnEliminarUnidad);
            this.tabPage3.Controls.Add(this.btnActualizarUnidad);
            this.tabPage3.Controls.Add(this.btnBuscarUnidad);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.txtRutUnidades);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(900, 224);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Unidades";
            // 
            // txtRutTipos
            // 
            this.txtRutTipos.Location = new System.Drawing.Point(56, 40);
            this.txtRutTipos.Name = "txtRutTipos";
            this.txtRutTipos.Size = new System.Drawing.Size(100, 20);
            this.txtRutTipos.TabIndex = 0;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ingresa el Rut que necesitas buscar ";
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
            // dgvTipos
            // 
            this.dgvTipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipos.Location = new System.Drawing.Point(257, 40);
            this.dgvTipos.Name = "dgvTipos";
            this.dgvTipos.Size = new System.Drawing.Size(605, 158);
            this.dgvTipos.TabIndex = 7;
            // 
            // dgvMotivos
            // 
            this.dgvMotivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMotivos.Location = new System.Drawing.Point(257, 40);
            this.dgvMotivos.Name = "dgvMotivos";
            this.dgvMotivos.Size = new System.Drawing.Size(605, 158);
            this.dgvMotivos.TabIndex = 15;
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
            // dgvUnidades
            // 
            this.dgvUnidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnidades.Location = new System.Drawing.Point(257, 40);
            this.dgvUnidades.Name = "dgvUnidades";
            this.dgvUnidades.Size = new System.Drawing.Size(605, 158);
            this.dgvUnidades.TabIndex = 23;
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
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMantencion";
            this.Text = "FormMantencion";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMotivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnidades)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvTipos;
        private System.Windows.Forms.Button btnGuardarTipo;
        private System.Windows.Forms.Button btnEliminarTipos;
        private System.Windows.Forms.Button btnActualizarTipos;
        private System.Windows.Forms.Button btnBuscarTipos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRutTipos;
        private System.Windows.Forms.DataGridView dgvMotivos;
        private System.Windows.Forms.Button btnGuardarMotivo;
        private System.Windows.Forms.Button btnEliminarMotivo;
        private System.Windows.Forms.Button btnActualizarMotivo;
        private System.Windows.Forms.Button btnBuscarMotivo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRutMotivos;
        private System.Windows.Forms.DataGridView dgvUnidades;
        private System.Windows.Forms.Button btnGuardarUnidad;
        private System.Windows.Forms.Button btnEliminarUnidad;
        private System.Windows.Forms.Button btnActualizarUnidad;
        private System.Windows.Forms.Button btnBuscarUnidad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRutUnidades;
    }
}