using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;




namespace CapaDatos
{
    class CDconexion
    {
        private OracleConnection Ora = new OracleConnection("DATA SOURCE = GESTION_PERMISO; PASSWORD = gestion; USER ID = gestion_permiso;");

        public OracleConnection AbrirConexion()
        {
            if (Ora.State == ConnectionState.Closed)
            {
                Ora.Open();
                return Ora;
            }
        }

        public OracleConnection CerrarConexion()
        {
            if (Ora.State == ConnectionState.Open)
            {
                Ora.Close();
                return Ora;
            }
        }

    }
}
