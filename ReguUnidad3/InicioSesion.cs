using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AWSs
{
    public partial class InicioSesion : Form
    {
        public InicioSesion()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (UserDAO.validarUsuario(txtContra.Text, txtUser.Text))
            {
                MessageBox.Show("BIENVENIDO");
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
                
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            
            DatosRegistro registrar = new DatosRegistro();
            registrar.ShowDialog();
            
        }

        private void InicioSesion_Load(object sender, EventArgs e)
        {

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
