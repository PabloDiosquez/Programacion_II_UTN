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
    public partial class MenuPrincipal : Form
    {
        // Atributos

        private string nombreUsuario;
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        public MenuPrincipal(string nombreUsuario): this()
        {
            this.nombreUsuario = nombreUsuario;
        }

        private void MenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); 
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            this.lb_bienvenido.Text += $" {nombreUsuario}";
        }
    }
}
