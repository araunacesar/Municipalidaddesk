using CapaPresentacion;
using CapaDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.OracleClient;





namespace Administrador_Municipalidad
{
    public partial class Form2 : Form
    {
        
        
        private CDconexion conn { get; }
        private OracleConnection Ora = new OracleConnection();
        

        public Form2()
        {
            InitializeComponent();
        }

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

        private void BtnFuncionarios_Click(object sender, EventArgs e) //BOTON FUNCIONARIO
        {
            FormFuncionarios FF = new FormFuncionarios();
            AbrirFormInPanel(FF); // llamamos al formulario desde el boton funcionarios
            CDconexion Conn = new CDconexion();
            Ora = Conn.AbrirConexion();
            OracleCommand cmd = new OracleCommand("SP_ListarPersonal", Ora);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;
            OracleDataAdapter oda = new OracleDataAdapter();
            oda.SelectCommand = cmd;
            DataTable lista = new DataTable();
            oda.Fill(lista);        
            FF.DGVListarPersonal.DataSource = lista;
            Console.WriteLine("Status: " + Conn.CerrarConexion());

        }

        private void BtnMantencion_Click(object sender, EventArgs e) //BOTON MANTENCION
        {
            //Mantencion de Tipos
            FormMantencion FMT = new FormMantencion();
            AbrirFormInPanel(FMT);
            CDconexion Cont = new CDconexion();
            Ora = Cont.AbrirConexion();
            OracleCommand cmdt = new OracleCommand("SP_ListarTipoPermiso ", Ora); //crear este procedimiento
            cmdt.CommandType = System.Data.CommandType.StoredProcedure;
            cmdt.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;
            OracleDataAdapter odat = new OracleDataAdapter();
            odat.SelectCommand = cmdt;
            DataTable listat = new DataTable();
            odat.Fill(listat);
            FMT.dgvTipos.DataSource = listat;
            Console.WriteLine("Status: " + Cont.CerrarConexion());

            // Mantencion de Motivos
            /*
            FormMantencion FMM = new FormMantencion();
            AbrirFormInPanel(FMM);
            CDconexion Conm = new CDconexion();
            Ora = Conm.AbrirConexion();
            OracleCommand cmdm = new OracleCommand("SP_ListarTipoPermiso ", Ora); //crear este procedimiento
            cmdm.CommandType = System.Data.CommandType.StoredProcedure;
            cmdm.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;
            OracleDataAdapter odam = new OracleDataAdapter();
            odam.SelectCommand = cmdm;
            DataTable listam = new DataTable();
            odam.Fill(listam);
            FMM.dgvMotivos.DataSource = listam;
            Console.WriteLine("Status: " + Conm.CerrarConexion());
           
            // Mantencion de Unidades
            
            FormMantencion FMU = new FormMantencion();
            AbrirFormInPanel(FMU);
            CDconexion Conu = new CDconexion();
            Ora = Conu.AbrirConexion();
            OracleCommand cmdu = new OracleCommand("SP_ListarTipoPermiso ", Ora); //crear este procedimiento
            cmdu.CommandType = System.Data.CommandType.StoredProcedure;
            cmdu.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;
            OracleDataAdapter odau = new OracleDataAdapter();
            odau.SelectCommand = cmdu;
            DataTable listau = new DataTable();
            odau.Fill(listau);
            FMU.dgvUnidades.DataSource = listau;
            Console.WriteLine("Status: " + Conu.CerrarConexion());
            */
        }

        private void BtnPermisos_Click(object sender, EventArgs e) //BOTON PERMISOS
        {
            FormPermisosIngresados FPI = new FormPermisosIngresados();
            AbrirFormInPanel(FPI);
            CDconexion Conn = new CDconexion();
            Ora = Conn.AbrirConexion();
            OracleCommand cmd = new OracleCommand("SP_ListarSoliPermiso", Ora); //crear este procedimiento
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;
            OracleDataAdapter oda = new OracleDataAdapter();
            oda.SelectCommand = cmd;
            DataTable lista = new DataTable();
            oda.Fill(lista);
            FPI.DGVPermisos.DataSource = lista;
            Console.WriteLine("Status: " + Conn.CerrarConexion());
        }

        private void BtnVerificaciones_Click(object sender, EventArgs e) //BOTON VERIFICACIONES
        {
            FormVerificaciones FV = new FormVerificaciones();
            AbrirFormInPanel(FV);
            CDconexion Conn = new CDconexion();
            Ora = Conn.AbrirConexion();
            OracleCommand cmd = new OracleCommand("SP_ListarEstado", Ora); //crear este procedimiento
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;
            OracleDataAdapter oda = new OracleDataAdapter();
            oda.SelectCommand = cmd;
            DataTable lista = new DataTable();
            oda.Fill(lista);
            FV.DGVverificacion.DataSource = lista;
            Console.WriteLine("Status: " + Conn.CerrarConexion());
        }

        private void BtnDescargas_Click(object sender, EventArgs e) //BOTON DESCARGAS
            // **** falta realizar procedimiento para descargas y aplicarlo aqui ****
        {
            FormDescargas FD = new FormDescargas();
            AbrirFormInPanel(FD);
            CDconexion Conn = new CDconexion();
            Ora = Conn.AbrirConexion();
            OracleCommand cmd = new OracleCommand("SP_ListarEstado", Ora); //crear este procedimiento
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;
            OracleDataAdapter oda = new OracleDataAdapter();
            oda.SelectCommand = cmd;
            DataTable lista = new DataTable();
            oda.Fill(lista);
            FD.DGVDescargas.DataSource = lista;
            Console.WriteLine("Status: " + Conn.CerrarConexion());
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
