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
            CDconexion Conm = new CDconexion();
            Ora = Conm.AbrirConexion();
            OracleCommand cmdm = new OracleCommand("SP_ListarTipoPermiso ", Ora); //crear este procedimiento
            cmdm.CommandType = System.Data.CommandType.StoredProcedure;
            cmdm.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;
            OracleDataAdapter odam = new OracleDataAdapter();
            odam.SelectCommand = cmdm;
            DataTable listam = new DataTable();
            odam.Fill(listam);
            dgvMotivos.DataSource = listam;
            Console.WriteLine("Status: " + Conm.CerrarConexion());
        }

        public void dgvUnidades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CDconexion Conu = new CDconexion();
            Ora = Conu.AbrirConexion();
            OracleCommand cmdu = new OracleCommand("SP_ListarTipoPermiso ", Ora); //crear este procedimiento
            cmdu.CommandType = System.Data.CommandType.StoredProcedure;
            cmdu.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;
            OracleDataAdapter odau = new OracleDataAdapter();
            odau.SelectCommand = cmdu;
            DataTable listau = new DataTable();
            odau.Fill(listau);
            dgvUnidades.DataSource = listau;
            Console.WriteLine("Status: " + Conu.CerrarConexion());
        }

        public void TabPageTipos_Click(object sender, EventArgs e)
        {

        }

        public void TabPageMotivos_Click(object sender, EventArgs e)
        {
            // Mantencion de Motivos
            
            //FormMantencion FMM = new FormMantencion();
            //AbrirFormInPanel(FMM);
            
                    }

        public void TabPageUnidades_Click(object sender, EventArgs e)
        {
            //Mantencion de Unidades
            
            //FormMantencion FMU = new FormMantencion();
            //AbrirFormInPanel(FMU);
           
           
        }
    }
}
