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
    public partial class AltaUsuario : Form
    {
        public AltaUsuario()
        {
            InitializeComponent();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            string nombre = txb_nombre.Text;

            string apellido = txb_apellido.Text;

            int dni = int.Parse(txb_dni.Text);

            string telefono = txb_telefono.Text;

            string direccion = txb_direccion.Text;

            Usuario usuarioNuevo = new Usuario(nombre, apellido, dni, telefono, direccion);
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
