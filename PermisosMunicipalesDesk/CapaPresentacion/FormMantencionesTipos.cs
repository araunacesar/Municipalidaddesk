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
    public partial class FormMantencionesTipos : Form
    {
        CDconexion Conn = new CDconexion();
        OracleCommand cmd;
        private OracleConnection Ora = new OracleConnection();
        public FormMantencionesTipos()
        {
            InitializeComponent();
        }

        public void dgvTipos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGuardarTipos_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTiposPermiso.Text))
            {
                MessageBox.Show("Debes ingresar un tipo de permiso");
            }
            else
            {
                try
                {
                    Ora = Conn.AbrirConexion();
                    cmd = new OracleCommand("SP_InsertarTipoPermiso", Ora);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add("nom", OracleType.VarChar).Value = txtTiposPermiso.Text;
                    cmd.ExecuteNonQuery();
                    Conn.CerrarConexion();
                    MessageBox.Show("Tipo de Permiso Guardado");
                    txtTiposPermiso.Clear();
                    txtTiposPermiso.Focus();
                }
                catch (Exception)
                {
                    //Este catch ocurre cuando algo salio mal en el try.
                    txtTiposPermiso.Clear();
                    txtTiposPermiso.Focus();
                    Console.WriteLine("Excepcion ocurrida en Agregar Tipo de Permisos");
                    Conn.CerrarConexion();
                }
            }
        }

        private void btnGuardarTipos_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarTipos_Click(object sender, EventArgs e)
        {

        }

        private void btnActualizarTipos_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminarTipos_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdTipos.Text))
            {
                MessageBox.Show("Debes ingresar un id de Tipo de Motivo");
            }
            else
            {
                try
                {
                    Ora = Conn.AbrirConexion();
                    cmd = new OracleCommand("SP_EliminarTipoMotivo", Ora);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add("id", OracleType.VarChar).Value = txtIdTipos.Text;
                    cmd.ExecuteNonQuery();
                    Conn.CerrarConexion();
                    MessageBox.Show("Tipo Motivo Eliminado");
                    txtIdTipos.Clear();
                    txtIdTipos.Focus();
                }
                catch (Exception)
                {
                    //Este catch ocurre cuando algo salio mal en el try.
                    txtIdTipos.Clear();
                    txtIdTipos.Focus();
                    Console.WriteLine("Excepcion ocurrida en Eliminar Tipo Motivo");
                }
            }
        }
    }
}