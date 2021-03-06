﻿namespace CapaPresentacion
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
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUnidades = new System.Windows.Forms.Button();
            this.btnMotivos = new System.Windows.Forms.Button();
            this.btnTipos = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(9, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Mantencion";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUnidades);
            this.groupBox1.Controls.Add(this.btnMotivos);
            this.groupBox1.Controls.Add(this.btnTipos);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Location = new System.Drawing.Point(12, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(912, 60);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selectiona el tipo de mantención";
            // 
            // btnUnidades
            // 
            this.btnUnidades.BackColor = System.Drawing.Color.DimGray;
            this.btnUnidades.FlatAppearance.BorderSize = 0;
            this.btnUnidades.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnUnidades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnidades.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnidades.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUnidades.Location = new System.Drawing.Point(595, 19);
            this.btnUnidades.Name = "btnUnidades";
            this.btnUnidades.Size = new System.Drawing.Size(197, 27);
            this.btnUnidades.TabIndex = 15;
            this.btnUnidades.Text = "Mantención de Unidades";
            this.btnUnidades.UseVisualStyleBackColor = false;
            this.btnUnidades.Click += new System.EventHandler(this.btnUnidades_Click_1);
            // 
            // btnMotivos
            // 
            this.btnMotivos.BackColor = System.Drawing.Color.DimGray;
            this.btnMotivos.FlatAppearance.BorderSize = 0;
            this.btnMotivos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnMotivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMotivos.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMotivos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMotivos.Location = new System.Drawing.Point(358, 19);
            this.btnMotivos.Name = "btnMotivos";
            this.btnMotivos.Size = new System.Drawing.Size(197, 27);
            this.btnMotivos.TabIndex = 14;
            this.btnMotivos.Text = "Mantención de Motivos";
            this.btnMotivos.UseVisualStyleBackColor = false;
            this.btnMotivos.Click += new System.EventHandler(this.btnMotivos_Click);
            // 
            // btnTipos
            // 
            this.btnTipos.BackColor = System.Drawing.Color.DimGray;
            this.btnTipos.FlatAppearance.BorderSize = 0;
            this.btnTipos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnTipos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTipos.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTipos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTipos.Location = new System.Drawing.Point(125, 19);
            this.btnTipos.Name = "btnTipos";
            this.btnTipos.Size = new System.Drawing.Size(197, 27);
            this.btnTipos.TabIndex = 13;
            this.btnTipos.Text = "Mantención de Tipos";
            this.btnTipos.UseVisualStyleBackColor = false;
            this.btnTipos.Click += new System.EventHandler(this.btnTipos_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Location = new System.Drawing.Point(12, 131);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(912, 363);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(12, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(889, 338);
            this.panel2.TabIndex = 0;
            // 
            // FormMantencion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(936, 506);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMantencion";
            this.Text = "FormMantencion";
            this.Load += new System.EventHandler(this.FormMantencion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUnidades;
        private System.Windows.Forms.Button btnMotivos;
        private System.Windows.Forms.Button btnTipos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel2;
    }
}