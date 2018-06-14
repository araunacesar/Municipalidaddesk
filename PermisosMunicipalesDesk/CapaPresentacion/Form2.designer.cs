namespace Administrador_Municipalidad
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.MenuVertical = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.btnSlide = new System.Windows.Forms.PictureBox();
            this.PicCerrar = new System.Windows.Forms.PictureBox();
            this.PicMaximizar = new System.Windows.Forms.PictureBox();
            this.PicMinimizar = new System.Windows.Forms.PictureBox();
            this.PicRestaurar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSlide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicRestaurar)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.DarkGreen;
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MenuVertical.Location = new System.Drawing.Point(0, 0);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(200, 546);
            this.MenuVertical.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1117, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(18, 17);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1093, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(18, 17);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnSalir.Location = new System.Drawing.Point(933, 484);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(191, 50);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.DarkGreen;
            this.BarraTitulo.Controls.Add(this.PicRestaurar);
            this.BarraTitulo.Controls.Add(this.PicMinimizar);
            this.BarraTitulo.Controls.Add(this.PicMaximizar);
            this.BarraTitulo.Controls.Add(this.PicCerrar);
            this.BarraTitulo.Controls.Add(this.btnSlide);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(200, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(936, 50);
            this.BarraTitulo.TabIndex = 4;
            this.BarraTitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedor.Location = new System.Drawing.Point(200, 50);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(936, 496);
            this.PanelContenedor.TabIndex = 5;
            // 
            // btnSlide
            // 
            this.btnSlide.Image = ((System.Drawing.Image)(resources.GetObject("btnSlide.Image")));
            this.btnSlide.Location = new System.Drawing.Point(6, 3);
            this.btnSlide.Name = "btnSlide";
            this.btnSlide.Size = new System.Drawing.Size(54, 41);
            this.btnSlide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSlide.TabIndex = 0;
            this.btnSlide.TabStop = false;
            this.btnSlide.Click += new System.EventHandler(this.btnSlide_Click);
            // 
            // PicCerrar
            // 
            this.PicCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PicCerrar.Image = ((System.Drawing.Image)(resources.GetObject("PicCerrar.Image")));
            this.PicCerrar.Location = new System.Drawing.Point(912, 3);
            this.PicCerrar.Name = "PicCerrar";
            this.PicCerrar.Size = new System.Drawing.Size(21, 17);
            this.PicCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicCerrar.TabIndex = 1;
            this.PicCerrar.TabStop = false;
            this.PicCerrar.Click += new System.EventHandler(this.PicCerrar_Click);
            // 
            // PicMaximizar
            // 
            this.PicMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PicMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("PicMaximizar.Image")));
            this.PicMaximizar.Location = new System.Drawing.Point(885, 3);
            this.PicMaximizar.Name = "PicMaximizar";
            this.PicMaximizar.Size = new System.Drawing.Size(21, 17);
            this.PicMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicMaximizar.TabIndex = 2;
            this.PicMaximizar.TabStop = false;
            this.PicMaximizar.Click += new System.EventHandler(this.PicMaximizar_Click);
            // 
            // PicMinimizar
            // 
            this.PicMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PicMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("PicMinimizar.Image")));
            this.PicMinimizar.Location = new System.Drawing.Point(858, 3);
            this.PicMinimizar.Name = "PicMinimizar";
            this.PicMinimizar.Size = new System.Drawing.Size(21, 17);
            this.PicMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicMinimizar.TabIndex = 3;
            this.PicMinimizar.TabStop = false;
            this.PicMinimizar.Click += new System.EventHandler(this.PicMinimizar_Click);
            // 
            // PicRestaurar
            // 
            this.PicRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PicRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("PicRestaurar.Image")));
            this.PicRestaurar.Location = new System.Drawing.Point(885, 3);
            this.PicRestaurar.Name = "PicRestaurar";
            this.PicRestaurar.Size = new System.Drawing.Size(21, 17);
            this.PicRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicRestaurar.TabIndex = 4;
            this.PicRestaurar.TabStop = false;
            this.PicRestaurar.Click += new System.EventHandler(this.PicRestaurar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(1136, 546);
            this.Controls.Add(this.PanelContenedor);
            this.Controls.Add(this.BarraTitulo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.MenuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnSlide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicRestaurar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel MenuVertical;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.PictureBox btnSlide;
        private System.Windows.Forms.Panel PanelContenedor;
        private System.Windows.Forms.PictureBox PicMinimizar;
        private System.Windows.Forms.PictureBox PicMaximizar;
        private System.Windows.Forms.PictureBox PicCerrar;
        private System.Windows.Forms.PictureBox PicRestaurar;
    }
}