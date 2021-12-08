using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AWSs
{
    public class Conexion
    {
        public static MySqlConnection ObtenerConexion()
        {


            MySqlConnection conectar = new MySqlConnection
                ("server = 127.0.0.1; database = inisioSesion; Uid = root; pwd = reptiles12;");

            conectar.Open();

            return conectar;
        }
    }
}
