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
    public partial class DatosRegistro : Form
    {
        public DatosRegistro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User pUsuario = new User();
            pUsuario.UsuarioRegistro = txtUsuario.Text.Trim();
            pUsuario.Contrasenia = txtContrasenia.Text.Trim();
            

            int resultado = UserDAO.Agregar(pUsuario);

            if (resultado > 0)
            {
                MessageBox.Show("Cliente Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DatosRegistro form = new DatosRegistro();
                this.Close();
                
            }

            else

            {
                MessageBox.Show("No se pudo guardar el cliente", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

            

        }
    }
}
