using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;

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
            try
            {
                string nombre = txb_nombre.Text;

                int edad = int.Parse(txb_edad.Text);

                Usuario usuario = new Usuario(nombre, edad);

                MessageBox.Show(usuario.ToString());

            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("Validar los datos ingresados");
            }
            





        }
    }
}
