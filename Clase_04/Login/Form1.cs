using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void btn_loguear_Click(object sender, EventArgs e)
        {
            string nombreUsuario = this.tbx_usuario_nombre.Text;

            string passUsuario   = this.tbx_usuario_pass.Text;

            if (nombreUsuario == "Lio Messi" && passUsuario == "Francia2")
            {
                MessageBox.Show($"Usuario {nombreUsuario} logueado 🖖🏼");
            }
            else 
            {
                MessageBox.Show("¡Usuario incorrecto! Intente de nuevo 🕵🏼‍.");
            }
        }

        private void btn_completar_Click(object sender, EventArgs e)
        {
            this.tbx_usuario_nombre.Text = "Lio Messi";

            this.tbx_usuario_pass.Text = "Francia2";
        }
    }
}
