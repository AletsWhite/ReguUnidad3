using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWSs
{
    public class UserDAO
    {
        public static bool validarUsuario(string pPassword, string pUsuario)
        {
            MySqlCommand comando = new MySqlCommand(String.Format(
              "SELECT * FROM inicio  where contrasenia = sha1('{0}') and usuario = '{1}'", pPassword, pUsuario), Conexion.ObtenerConexion());
            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.Read())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static int Agregar(User pUsuario)
        {

            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("" +
                "Insert into inicio(usuario, contrasenia) values('{0}',sha1('{1}'))", pUsuario.UsuarioRegistro, 
                 pUsuario.Contrasenia), Conexion.ObtenerConexion());

            retorno = comando.ExecuteNonQuery();

            return retorno;

            
        }
    }
}
