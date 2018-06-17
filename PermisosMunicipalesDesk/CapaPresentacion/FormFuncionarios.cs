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
using Administrador_Municipalidad;
using System.Data.OracleClient;
using CapaPresentacion;

namespace CapaPresentacion
{
    public partial class FormFuncionarios : Form
    {
        private CDconexion conn { get; set; }
        OracleConnection Ora = new OracleConnection();

        public FormFuncionarios()
        {
            InitializeComponent();
            CDconexion Conn = new CDconexion();
            Ora = Conn.AbrirConexion();
            OracleCommand cmd = new OracleCommand("P_LISTAR_PERSONAL", Ora);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            OracleDataAdapter oda = new OracleDataAdapter();
            oda.SelectCommand = cmd;
            Console.WriteLine("tostring: " + cmd.ToString());
            DataTable lista = new DataTable();

            oda.Fill(lista);
            //DGVListarPersonal.DataSource = lista;
            Console.WriteLine("lista: " + lista);
            DGVListarPersonal.DataSource = "HOLAAAAA";
            Conn.CerrarConexion();


        }
        

        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        public void FormFuncionarios_Load(object sender, EventArgs e)
        {

        }

        public void DGVListarPersonal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        public void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
