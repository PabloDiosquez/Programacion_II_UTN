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

        Usuario[] usuarios;
        private MenuPrincipal()
        {         
            InitializeComponent();

            usuarios = new Usuario[3];

            CargaUsuarios();
        }

        public MenuPrincipal(string usuario): this()
        {
            this.usuario = usuario;
        }

        /// <summary>
        /// Carga de usuarios por defecto.
        /// </summary>
        private void CargaUsuarios() 
        {
            usuarios[0] = new Usuario("Lio", "Messi", 30123456);

            usuarios[1] = new Usuario("Julián", "Álvarez", 40123456);

            usuarios[2] = new Usuario("Emiliano", "Martínez", 20123456);

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
