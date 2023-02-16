using Logica;
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
            try
            {
                string nombre = txb_nombre.Text;

                int edad = int.Parse(txb_edad.Text);

                string res = LogicaNegocio.CargarUsuario(nombre, edad);

                MessageBox.Show(res);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            





        }
    }
}
