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

            if (usuario == "LioMessi" && pass == "ABC123")
            {
                MessageBox.Show("Usuario logueado");

            }
            else 
            {
                MessageBox.Show("Usuario incorrecto");
            }
        }
    }
}
