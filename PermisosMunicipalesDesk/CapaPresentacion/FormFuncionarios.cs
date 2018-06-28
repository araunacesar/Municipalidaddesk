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
using CapaNegocio;
using System.Runtime.InteropServices;
using System.Data.OracleClient;

namespace CapaPresentacion
{
    public partial class FormFuncionarios : Form
    {
        CDconexion Conn = new CDconexion();
        OracleCommand cmd;
        public FuncionarioHelper fh = new FuncionarioHelper();
        private OracleConnection Ora = new OracleConnection();
        public FormFuncionarios()
        {
            InitializeComponent();
        }
        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e){}

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e){}

        private void FormFuncionarios_Load(object sender, EventArgs e){}

        public void DGVListarPersonal_CellContentClick(object sender, DataGridViewCellEventArgs e){}

        private void BtnAgregar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtrut.Text))
            {
                MessageBox.Show("Debes ingresar a lo menos un Rut");
            }
            else
            {
                try
                {
                    Ora = Conn.AbrirConexion();
                    cmd = new OracleCommand("SP_InsertarPersonal", Ora);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add("rut", OracleType.VarChar).Value = txtrut.Text;
                    cmd.Parameters.Add("nom", OracleType.VarChar).Value = txtnom.Text;
                    cmd.Parameters.Add("apelp", OracleType.VarChar).Value = txtapp.Text;
                    cmd.Parameters.Add("apelm", OracleType.VarChar).Value = txtapm.Text;
                    cmd.Parameters.Add("contr", OracleType.DateTime).Value = dtpFecha_Contrato.Text;
                    cmd.Parameters.Add("mail", OracleType.VarChar).Value = txtmail.Text;
                    cmd.Parameters.Add("sex", OracleType.Char).Value = cbsex.Text;
                    cmd.Parameters.Add("usu", OracleType.VarChar).Value = txtuser.Text;
                    cmd.Parameters.Add("pass", OracleType.VarChar).Value = txtpass.Text;
                    cmd.Parameters.Add("codUser", OracleType.Number).Value = cbtipouser.SelectedIndex;
                    cmd.Parameters.Add("codCargo", OracleType.Number).Value = cbcargo.SelectedIndex;
                    cmd.Parameters.Add("codDepto", OracleType.Number).Value = cbdepto.SelectedIndex;
                    //FALTA MAPEAR CAMPO FALTANTE
                    cmd.ExecuteNonQuery();
                    cmd = new OracleCommand("SP_ListarPersonal", Ora);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;
                    OracleDataAdapter oda = new OracleDataAdapter();
                    oda.SelectCommand = cmd;
                    DataTable lista = new DataTable();
                    oda.Fill(lista);
                    DGVListarPersonal.DataSource = lista;
                    Conn.CerrarConexion();
                    Conn.CerrarConexion();
                    MessageBox.Show("Usuario Agregado");
                    txtrut.Clear();
                    txtrut.Focus();
                }
                catch (Exception)
                {
                    //Este catch ocurre cuando algo salio mal en el try.
                    txtrut.Clear();
                    txtrut.Focus();
                    Console.WriteLine("Excepcion ocurrida en Agregar Personal");
                    Conn.CerrarConexion();
                }
            }
        }

        private void EliminarBtn_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtrut.Text))
            {
                MessageBox.Show("Debes ingresar un Rut");
            }else
            {
                try
                {
                    Ora = Conn.AbrirConexion();
                    cmd = new OracleCommand("SP_EliminarPersonal", Ora);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add("id", OracleType.VarChar).Value = txtrut.Text;
                    cmd.ExecuteNonQuery();
                    cmd = new OracleCommand("SP_ListarPersonal", Ora);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;
                    OracleDataAdapter oda = new OracleDataAdapter();
                    oda.SelectCommand = cmd;
                    DataTable lista = new DataTable();
                    oda.Fill(lista);
                    DGVListarPersonal.DataSource = lista;
                    Conn.CerrarConexion();
                    Conn.CerrarConexion();
                    MessageBox.Show("Usuario Eliminado");
                    txtrut.Clear();
                    txtrut.Focus();
                }
                catch (Exception)
                {
                    //Este catch ocurre cuando algo salio mal en el try.
                    //MessageBox.Show("El rut ingresado es erroneo o no pertenece a la base de datos");
                    txtrut.Clear();
                    txtrut.Focus();
                    Console.WriteLine("Excepcion ocurrida en Eliminar Personal");
                }
            }
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtrut.Text))
            {
                MessageBox.Show("Debes ingresar un Rut");
            }
            else
            {
                try
                {
                    string[] resultado = fh.traerFuncionario(txtrut.Text);
                    if (resultado[0].Length < 5)
                    {
                        MessageBox.Show("El rut ingresado no existe en la base de datos");

                    }
                    else
                    {
                        txtrut.Text = resultado[0];
                        txtnom.Text = resultado[1];
                        txtapp.Text = resultado[2];
                        txtapm.Text = resultado[3];
                        dtpFecha_Contrato.Text = resultado[4];
                        txtmail.Text = resultado[5];
                        cbsex.Text = resultado[6];
                        txtuser.Text = resultado[7];
                        txtpass.Text = resultado[8];
                        cbtipouser.SelectedIndex = Convert.ToInt32(resultado[9]);
                        cbcargo.SelectedIndex = Convert.ToInt32(resultado[10]);
                        cbdepto.SelectedIndex = Convert.ToInt32(resultado[11]);
                        //FALTA UN CAMPO PARA MAPEAR SEGUN EL SCRIPT DE DAMIAN
                    }
                }
                catch (Exception)
                {
                    txtrut.Clear();
                    txtrut.Focus();
                    Console.WriteLine("Excepcion ocurrida en Buscar Personal");
                }
            }


            Ora = Conn.AbrirConexion();

            Console.WriteLine("Status: " + Conn.CerrarConexion());
        }


        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtrut.Text))
            {
                MessageBox.Show("Debes ingresar un Rut, y luego apretar Buscar");
            }
            else
            {
                try
                {
                    Ora = Conn.AbrirConexion();
                    cmd = new OracleCommand("SP_ActualizarPersonal", Ora);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add("rut", OracleType.VarChar).Value = txtrut.Text;
                    cmd.Parameters.Add("nom", OracleType.VarChar).Value = txtnom.Text;
                    cmd.Parameters.Add("apelp", OracleType.VarChar).Value = txtapp.Text;
                    cmd.Parameters.Add("apelm", OracleType.VarChar).Value = txtapm.Text;
                    cmd.Parameters.Add("contr", OracleType.DateTime).Value = dtpFecha_Contrato.Text;
                    cmd.Parameters.Add("mail", OracleType.VarChar).Value = txtmail.Text;
                    cmd.Parameters.Add("sex", OracleType.Char).Value = cbsex.Text;
                    cmd.Parameters.Add("usu", OracleType.VarChar).Value = txtuser.Text;
                    cmd.Parameters.Add("pass", OracleType.VarChar).Value = txtpass.Text;
                    cmd.Parameters.Add("codUser", OracleType.Number).Value = cbtipouser.SelectedIndex;
                    cmd.Parameters.Add("codCargo", OracleType.Number).Value = cbcargo.SelectedIndex;
                    cmd.Parameters.Add("codDepto", OracleType.Number).Value = cbdepto.SelectedIndex;
                    //FALTA MAPEAR CAMPO FALTANTE
                    cmd.ExecuteNonQuery();
                    cmd = new OracleCommand("SP_ListarPersonal", Ora);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;
                    OracleDataAdapter oda = new OracleDataAdapter();
                    oda.SelectCommand = cmd;
                    DataTable lista = new DataTable();
                    oda.Fill(lista);
                    DGVListarPersonal.DataSource = lista;
                    Conn.CerrarConexion();
                    MessageBox.Show("Usuario Actualizado");
                    txtrut.Clear();
                    txtrut.Focus();
                }
                catch (Exception)
                {
                    txtrut.Clear();
                    txtrut.Focus();
                    Console.WriteLine("Excepcion ocurrida en Actualizar Personal");
                }
            }


            Ora = Conn.AbrirConexion();
            
            Console.WriteLine("Status: " + Conn.CerrarConexion());
        }
    }
}
