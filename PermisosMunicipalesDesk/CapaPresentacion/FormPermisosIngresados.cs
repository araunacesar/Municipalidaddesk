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
    public partial class FormPermisosIngresados : Form
    {
        private CDconexion conn { get; }
        private OracleConnection Ora = new OracleConnection();
        public FormPermisosIngresados()
        {
            InitializeComponent();
        }

        public void DGVPermisos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvPermisos_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
