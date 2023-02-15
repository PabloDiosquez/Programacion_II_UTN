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
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            string nombre = txb_nombre.Text;

            if (string.IsNullOrEmpty(nombre))
            {
                throw new Exception("El nombre no puede ser nulo");
            }

            int edad;

            if (!int.TryParse(txb_edad.Text, out edad) || edad < 0)
            {
                throw new Exception("Algo salió mal...");
            }

            Usuario usuario = new Usuario(nombre, edad);

            MessageBox.Show(usuario.ToString());
        }
    }
}
