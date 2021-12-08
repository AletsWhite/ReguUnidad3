using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWSs
{
    public class User
    {
        public string UsuarioRegistro { get; set; }
        public string Contrasenia { get; set; }

        public User()
        {

        }

        public User(string Usuario, string Contrasenia)
        {
            this.UsuarioRegistro = Usuario;
            this.Contrasenia = Contrasenia;

        }
    }
}
