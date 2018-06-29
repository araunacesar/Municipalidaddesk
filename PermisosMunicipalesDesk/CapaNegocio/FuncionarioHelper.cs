using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OracleClient;
using CapaDatos;

namespace CapaNegocio
{
    public class FuncionarioHelper
    {

        public CDconexion Conn = new CDconexion();
        //private OracleConnection Ora = new OracleConnection("DATA SOURCE = xe; PASSWORD = gestion; USER ID = gestion_permiso;");


        public string[] traerFuncionario(string rut) {
            Conn.AbrirConexion();
            string queryString = "Select * from PERSONAL where rut='" + rut + "';";
            
            OracleCommand command = new OracleCommand(queryString, Conn.Ora);
            string[] resultado = new string[13];
            OracleDataReader reader;
            reader = command.ExecuteReader();
            reader.Read();
            for (int i = 0; i < 13; i++)
            {
                resultado[i] = reader.GetValue(i).ToString();
            }
            Conn.CerrarConexion();
            reader.Close();

        return resultado;
        }
    }
}
