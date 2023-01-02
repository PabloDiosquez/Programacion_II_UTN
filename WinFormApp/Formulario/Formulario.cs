using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario
{
    public partial class frm_principal : Form
    {
        public frm_principal()
        {
            InitializeComponent();
        }

        private void btn_loguear_Click(object sender, EventArgs e)
        {
            string usuario = txb_usuario.Text;

            string pass = txb_password.Text;

            if (usuario == "LioMessi".Trim() && pass == "ABC123".Trim())
            {
                this.BackColor = Color.AliceBlue;

                //MessageBox.Show("Usuario logueado");

                MenuPrincipal frmMenuPrincipal = new MenuPrincipal(usuario);

                this.Hide();

                frmMenuPrincipal.ShowDialog(this);

            }
            else
            {
                this.BackColor = Color.Teal;

                MessageBox.Show("Usuario incorrecto");
            }
        }

        private void btn_completar_Click(object sender, EventArgs e)
        {
            txb_usuario.Text = "LioMessi";

            txb_password.Text = "ABC123";
        }
    }
}
