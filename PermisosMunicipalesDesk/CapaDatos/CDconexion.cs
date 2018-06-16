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
                Console.WriteLine(reader.GetValue(0));
                resultado = resultado + reader.GetValue(0);
            }
            return resultado;
        }
        public string obtenerDatosUser(string user)
        {
            cmd.Connection = Ora;
            string resultado = "";
            int i = 0;
            cmd.CommandText = "Select * from PERSONAL where usuario='" + user+"'";
            cmd.CommandType = CommandType.Text;
            OracleDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader.GetValue(i));
                resultado = resultado +","+ reader.GetValue(0);
                i = i+1;
            }
            reader.Close();
            return resultado;
        }

        public string obtenerNombreUser(string user)
        {
            string queryString = "Select * from PERSONAL where usuario='" + user + "'";
            
                OracleCommand command = new OracleCommand(queryString, Ora);
                string resultado = "";
               // int i = 0;
                OracleDataReader reader;
                reader = command.ExecuteReader();

                // Always call Read before accessing data.
                while (reader.Read())
                {
                    //Console.WriteLine(reader.GetValue(i));
                    resultado = reader.GetValue(1)+" "+reader.GetValue(2)+" "+reader.GetValue(3);
                }

                // Always call Close when done reading.
                reader.Close();
                cmd.Connection = Ora;
                reader.Close();

            
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
