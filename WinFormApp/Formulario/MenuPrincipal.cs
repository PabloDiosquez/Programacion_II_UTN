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
    public partial class MenuPrincipal : Form
    {

        private string usuario;
        private MenuPrincipal()
        {         
            InitializeComponent();
        }

        public MenuPrincipal(string usuario): this()
        {
            this.usuario = usuario;
        }

        private void MenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            string mensaje = "¿Desea cerrar la app?";

            string titulo = "Cierre de ventana";

            MessageBoxButtons buttons = MessageBoxButtons.YesNo;

            DialogResult resultado = MessageBox.Show(mensaje, titulo, buttons);

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                //TODO: 3 👉🏼 ???

            }
            
            //Application.Exit();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            lbl_bienvenida.Text = $"Bienvenido {usuario}";
        }
    }
}
