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

        /// <summary>
        /// Maneja el evento de clic en el botón de inicio de sesión.
        /// </summary>
        /// <param name="sender">El objeto que desencadenó el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void btn_loguear_Click(object sender, EventArgs e)
        {
            // Obtiene el nombre de usuario ingresado en el cuadro de texto.
            string nombreUsuario = this.tbx_usuario_nombre.Text;

            // Obtiene la contraseña ingresada en el cuadro de texto.
            string passUsuario = this.tbx_usuario_pass.Text;

            if (string.IsNullOrEmpty(nombreUsuario) || string.IsNullOrEmpty(passUsuario))
            {
                MessageBox.Show("Asegúrese de completar todos los campos 🤔");
            }
            // Comprueba si las credenciales son válidas.
            else if(nombreUsuario == "Lio Messi" && passUsuario == "Francia2")
            {
                // Muestra un mensaje de éxito con el nombre de usuario.
                this.BackColor = Color.LightBlue;

                MessageBox.Show($"Usuario {nombreUsuario} logueado 🖖🏼");
            }
            else
            {
                // Muestra un mensaje de error y anima al usuario a intentarlo nuevamente.
                MessageBox.Show("¡Usuario incorrecto! Intente de nuevo 🕵🏼‍.");
            }
        }

        /// <summary>
        /// Maneja el evento de clic en el botón para completar datos de usuario.
        /// </summary>
        /// <param name="sender">El objeto que desencadenó el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void btn_completar_Click(object sender, EventArgs e)
        {
            // Establece el nombre de usuario en "Lio Messi".
            this.tbx_usuario_nombre.Text = "Lio Messi";

            // Establece la contraseña del usuario en "Francia2".
            this.tbx_usuario_pass.Text = "Francia2";
        }
    }
}
