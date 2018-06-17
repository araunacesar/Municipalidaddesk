using CapaPresentacion;
using CapaDatos;
using System;
using System.Data;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.OracleClient;
using CapaPresentacion;

namespace Administrador_Municipalidad
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        
        FormFuncionarios FF = new FormFuncionarios();
        [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int Iparam);

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSlide_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 250)
            {
                MenuVertical.Width = 75;
            }
            else {
                MenuVertical.Width = 250;    
            }        
        }

        private void PicCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PicMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            PicRestaurar.Visible = true;
            PicMaximizar.Visible = false;
        }

        private void PicRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            PicRestaurar.Visible = false;
            PicMinimizar.Visible = true;
        }

        private void PicMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PanelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AbrirFormInPanel(object Formhijo)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);
            Form ff = Formhijo as Form;
            ff.TopLevel = false;
            ff.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(ff);
            this.PanelContenedor.Tag = ff;
            ff.Show();

        }

        private void BtnFuncionarios_Click(object sender, EventArgs e)
        {
            
            AbrirFormInPanel(FF);
            
        }

        private void BtnMantencion_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FormMantencion());
        }

        private void BtnPermisos_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FormPermisosIngresados());
        }

        private void BtnVerificaciones_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FormVerificaciones());
        }

        private void BtnDescargas_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FormDescargas());
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 ss = new Form1();
            ss.Show();
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }
    }
}
