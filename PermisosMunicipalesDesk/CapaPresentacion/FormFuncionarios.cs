using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaPresentacion;
using System.Runtime.InteropServices;
using System.Data.OracleClient;

namespace CapaPresentacion
{
    public partial class FormFuncionarios : Form
    {
        CDconexion Conn = new CDconexion();
        OracleCommand cmd;
        private OracleConnection Ora = new OracleConnection();
        public FormFuncionarios()
        {
            InitializeComponent();
        }
        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e){}

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e){}

        private void FormFuncionarios_Load(object sender, EventArgs e){}

        public void DGVListarPersonal_CellContentClick(object sender, DataGridViewCellEventArgs e){}

        private void button1_Click(object sender, EventArgs e)
        {
            
            Ora = Conn.AbrirConexion();
            cmd = new OracleCommand("SP_ListarPersonal", Ora);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;
            OracleDataAdapter oda = new OracleDataAdapter();
            oda.SelectCommand = cmd;
            DataTable lista = new DataTable();
            oda.Fill(lista);
            DGVListarPersonal.DataSource = lista;
            Console.WriteLine("Status: " + Conn.CerrarConexion());
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            
        }

        private void EliminarBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtrut.Text))
            {
                MessageBox.Show("Debes ingresar un Rut");
            }else
            {
                Ora = Conn.AbrirConexion();
                cmd = new OracleCommand("SP_EliminarPersonal", Ora);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("id", OracleType.VarChar).Value = txtrut.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Usuario Eliminado");
            }
        }
    }
}
