using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_mensaje_Click(object sender, EventArgs e)
        {
            // TODO: 1 - Detectar el texto en el textbox. 
            string usuario = this.tbx_usuario.Text;

            // TODO: 2 - Enviar un mensaje a través de un MessageBox con el texto detectado.
            if (string.IsNullOrEmpty(usuario))
                MessageBox.Show("No ingresaste un nombre de usuario válido 🤔");
            else
                MessageBox.Show($"Hola {usuario}! Este es un mensaje envíado a través del espacio-tiempo 🚀");
        }

        private void btn_mensaje_MouseHover(object sender, EventArgs e)
        {
            this.btn_mensaje.BackColor = Color.LightBlue;
        }

        private void btn_mensaje_MouseLeave(object sender, EventArgs e)
        {
            this.btn_mensaje.BackColor= SystemColors.Control;   
        }
    }
}
