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

namespace CapaPresentacion
{
    public partial class FormMantencion : Form

    {
        private CDconexion conn { get; }
        private OracleConnection Ora = new OracleConnection();
        
        public FormMantencion()
        {
            InitializeComponent();
        }

        public void dgvTipos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void dgvMotivos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        public void dgvUnidades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        public void TabPageTipos_Click(object sender, EventArgs e)
        {
        }

        public void TabPageMotivos_Click(object sender, EventArgs e)
        {
        }

        public void TabPageUnidades_Click(object sender, EventArgs e)
        {
        }

        private void AbrirSubFormInPanel(object Formhijohijo)
        {
            if (this.panel2.Controls.Count > 0)
                this.panel2.Controls.RemoveAt(0);
            Form ff = Formhijohijo as Form;
            ff.TopLevel = false;
            ff.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(ff);
            this.panel2.Tag = ff;
            ff.Show();

        }
        //desde aqui hacia abajo, las funciones correctas  
        private void btnTipos_Click_1(object sender, EventArgs e) //llamar al formulario de tipos
        {

            
            FormMantencionesTipos MT = new FormMantencionesTipos();
            AbrirSubFormInPanel(MT);
            CDconexion Cont = new CDconexion();
            Ora = Cont.AbrirConexion();
            OracleCommand cmdt = new OracleCommand("SP_CARGAR_TIPO_PERMISO", Ora); 
            cmdt.CommandType = System.Data.CommandType.StoredProcedure;
            cmdt.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;
            OracleDataAdapter odat = new OracleDataAdapter();
            odat.SelectCommand = cmdt;
            DataTable listat = new DataTable();
            odat.Fill(listat);
            MT.dgvTipos.DataSource = listat;
            Console.WriteLine("Status: " + Cont.CerrarConexion());
        }

        private void btnMotivos_Click_1(object sender, EventArgs e)//llamar al formulario de Motivos
        {
            FormMantencionesMotivos MM = new FormMantencionesMotivos();
            AbrirSubFormInPanel(MM);
            CDconexion Conm = new CDconexion();
            Ora = Conm.AbrirConexion();
            OracleCommand cmdm = new OracleCommand("SP_CARGAR_MOTIVOS", Ora); 
            cmdm.CommandType = System.Data.CommandType.StoredProcedure;
            cmdm.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;
            OracleDataAdapter odam = new OracleDataAdapter();
            odam.SelectCommand = cmdm;
            DataTable listam = new DataTable();
            odam.Fill(listam);
            MM.dgvMotivos.DataSource = listam;
            Console.WriteLine("Status: " + Conm.CerrarConexion());
        }

        private void btnUnidades_Click(object sender, EventArgs e)//llamar al formulario de Unidades
        {
            FormMantencionesUnidades MU = new FormMantencionesUnidades();
            AbrirSubFormInPanel(MU);
            CDconexion Conu = new CDconexion();
            Ora = Conu.AbrirConexion();
            OracleCommand cmdu = new OracleCommand("SP_CARGAR_UNIDADES", Ora); 
            cmdu.CommandType = System.Data.CommandType.StoredProcedure;
            cmdu.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;
            OracleDataAdapter odau = new OracleDataAdapter();
            odau.SelectCommand = cmdu;
            DataTable listau = new DataTable();
            odau.Fill(listau);
            MU.dgvUnidad.DataSource = listau;
            Console.WriteLine("Status: " + Conu.CerrarConexion());
        }

        public void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
