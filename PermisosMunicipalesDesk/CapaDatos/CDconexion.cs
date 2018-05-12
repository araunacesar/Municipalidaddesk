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
    public class CDconexion
    {
        

    public OracleConnection Ora { get; set; }
        

        public CDconexion()
        {
            Ora = new OracleConnection("DATA SOURCE = GESTION_PERMISO; PASSWORD = gestion; USER ID = gestion_permiso;");
            
        }
        public OracleConnection AbrirConexion()
        {
            if (Ora.State == ConnectionState.Closed)
            {
                Ora.Open();
                return Ora;
            }
            return Ora;
        }

        public bool obtenerUsuario(String nombre)
        {

            return false;
        }

        public OracleConnection CerrarConexion()
        {
            if (Ora.State == ConnectionState.Open)
            {
                Ora.Close();
                return Ora;
            }
            return Ora;
        }

    }
}
