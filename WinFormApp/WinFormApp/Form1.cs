using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrarTexto_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("### Primer mensaje 💣 ###");

            //TODO: 1 👉🏼 Capturar el texto del TextBox.

            //TODO: 2 👉🏼 Reemplazar el texto en el Label.

            //string mensaje = txb_Texto.Text;

            //lblTexto.Text = mensaje;

            // En una única linea 👌🏼

            lblTexto.Text = txb_Texto.Text;
            
        }
    }
}
