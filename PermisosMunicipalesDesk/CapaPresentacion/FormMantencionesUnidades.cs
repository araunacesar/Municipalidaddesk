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
    public partial class FormMantencionesUnidades : Form
    {
        CDconexion Conn = new CDconexion();
        OracleCommand cmd;
        private OracleConnection Ora = new OracleConnection();
        public FormMantencionesUnidades()
        {
            InitializeComponent();
        }

        public void dgvUnidad_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGuardarUnidad_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNomCargo.Text))
            {
                MessageBox.Show("Debes ingresar a lo menos una letra");
            }
            else
            {
                try
                {
                    Ora = Conn.AbrirConexion();
                    cmd = new OracleCommand("SP_INSERTAR_CARGO", Ora);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add("nom", OracleType.VarChar).Value = txtNomCargo.Text;
                    cmd.ExecuteNonQuery();
                    Conn.CerrarConexion();
                    MessageBox.Show("Unidad Guardada");
                    txtidUnidad.Clear();
                    txtidUnidad.Focus();
                }
                catch (Exception)
                {
                    //Este catch ocurre cuando algo salio mal en el try.
                    txtidUnidad.Clear();
                    txtidUnidad.Focus();
                    Console.WriteLine("Excepcion ocurrida en agregar la unidad del Permisos");
                    Conn.CerrarConexion();
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Quizas seria bueno aqui, en vez de buscar por el ID del Tipo de unidad, hacer un SP de SQL con LIKE, cosa que el administrador pueda buscar una lista de todos los que tengan, 
            //por ejemplo, la palabra "fallecimiento" asi le traera los  que contengan esapalabra, de otra manera, este boton estaria de sobra

        }

        private void btnEliminarUnidad_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtidUnidad.Text))
            {
                MessageBox.Show("Debes ingresar un id de Tipo de Unidad");
            }
            else
            {
                try
                {
                    Ora = Conn.AbrirConexion();
                    cmd = new OracleCommand("SP_ELIMINAR_TIPO_UNIDAD", Ora);  // listo el procedure
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add("id", OracleType.VarChar).Value = txtidUnidad.Text;
                    cmd.ExecuteNonQuery();
                    Conn.CerrarConexion();
                    MessageBox.Show("La unidad ha sido eliminado");
                    txtidUnidad.Clear();
                    txtidUnidad.Focus();
                }
                catch (Exception)
                {
                    //Este catch ocurre cuando algo salio mal en el try.
                    txtidUnidad.Clear();
                    txtidUnidad.Focus();
                    Console.WriteLine("Excepcion ocurrida en Eliminar Tipo Motivo");
                }
            }
        }
    }
}
