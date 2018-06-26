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
                MessageBox.Show("Debes ingresar a lo menos un Rut");
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
                    txtRutUnidad.Clear();
                    txtRutUnidad.Focus();
                }
                catch (Exception)
                {
                    //Este catch ocurre cuando algo salio mal en el try.
                    txtRutUnidad.Clear();
                    txtRutUnidad.Focus();
                    Console.WriteLine("Excepcion ocurrida en agregar la unidad del Permisos");
                    Conn.CerrarConexion();
                }

            }
        }

        
    }
}
