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
    public partial class FormVerificaciones : Form
    {
        private CDconexion conn { get; }
        private OracleConnection Ora = new OracleConnection();
        public FormVerificaciones()
        {
            InitializeComponent();
        }

        public void DGVverificacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvverificaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
