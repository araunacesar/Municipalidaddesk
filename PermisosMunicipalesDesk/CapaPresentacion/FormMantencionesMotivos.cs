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
    public partial class FormMantencionesMotivos : Form
    {
        CDconexion Conn = new CDconexion();
        OracleCommand cmd;
        private OracleConnection Ora = new OracleConnection();

        public FormMantencionesMotivos()
        {
            InitializeComponent();
        }

        public void dgvMotivos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGuardarMotivo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRutMotivos.Text))
            {
                MessageBox.Show("Debes ingresar a lo menos un Rut"); //esto no deberia de estar o se debe de cambiar
            }
            else
            {
                try
                {
                    Ora = Conn.AbrirConexion();
                    cmd = new OracleCommand("SP_INSERTAR_MOTIVO", Ora);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add("motivo_solicitud", OracleType.VarChar).Value = txtMotivos.Text;
                    cmd.ExecuteNonQuery();
                    Conn.CerrarConexion();
                    MessageBox.Show("Se ha agregado un nuevo motivo a la tabla !!");
                    txtRutMotivos.Clear();
                    txtRutMotivos.Focus();
                }
                catch (Exception)
                {
                    //Este catch ocurre cuando algo salio mal en el try.
                    txtRutMotivos.Clear();
                    txtRutMotivos.Focus();
                    Console.WriteLine("Excepcion ocurrida en Agregar el Motivo de Permisos");
                    Conn.CerrarConexion();
                }
            }
        }
    }
}
