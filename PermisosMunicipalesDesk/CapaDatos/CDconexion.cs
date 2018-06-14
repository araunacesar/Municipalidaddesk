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
    public OracleCommand cmd { get; set; }
    

        public CDconexion()
        {
            Ora = new OracleConnection("DATA SOURCE = xe; PASSWORD = gestion; USER ID = gestion_permiso;");
            cmd = new OracleCommand();
        }
        public OracleConnection AbrirConexion()
        {
            if (Ora.State == ConnectionState.Closed)
            {
                Ora.Open();
                return Ora;
            }
            Console.WriteLine("Estado: " +Ora.State);
            return Ora;
        }

        public string obtenerCodUser(string nombre, string pw)
        {
            cmd.Connection = Ora;
            string resultado="";
            cmd.CommandText = "Select tipo_user_cod_user from PERSONAL where usuario='"+nombre+"' and password='"+pw+"'";
            cmd.CommandType = CommandType.Text;
            OracleDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine("CodUser: "+reader.GetValue(0));
                resultado = resultado + reader.GetValue(0);
            }
            return resultado;
        }

        public string CerrarConexion()
        {
            if (Ora.State == ConnectionState.Open)
            {
                Ora.Close();
                return Ora.State.ToString();
            }
            else
            {
                Ora.Close();
            }
            return Ora.State.ToString();
        }

    }
}
