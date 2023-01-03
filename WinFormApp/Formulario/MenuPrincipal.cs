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

            usuarios = new Usuario[10];

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

            for (int i = 0; i < usuarios.Length; i++)
            {
                if (usuarios[i] is not null)
                {
                    rtb_datos.Text += $"{usuarios[i].MostrarInfo()}\n";
                }
            }
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            AltaUsuario frmAltaUsuario = new AltaUsuario();

            if (frmAltaUsuario.ShowDialog() == DialogResult.OK)
            {
                int posLibre = PosLibre();
                if (posLibre != -1)
                {
                    usuarios[posLibre] = frmAltaUsuario.ObtenerUsuario();

                    rtb_datos.Text += usuarios[posLibre].MostrarInfo();
                }
                else 
                {
                    MessageBox.Show("No hay más lugar");
                }
            }
            else 
            {
                MessageBox.Show("Carga cancelada");
            }
        }

        private int PosLibre() 
        {
            for (int i = 0; i < usuarios.Length; i++)
            {
                if (usuarios[i] is null) 
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
