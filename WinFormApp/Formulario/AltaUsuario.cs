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
        Usuario nuevoUsuario;
        public AltaUsuario()
        {
            InitializeComponent();
        }

        public Usuario ObtenerUsuario()
        {
            return nuevoUsuario;
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            string nombre = txb_nombre.Text;

            string apellido = txb_apellido.Text;

            int.TryParse(txb_dni.Text, out int dni);

            string telefono = txb_telefono.Text;

            string direccion = txb_direccion.Text;

            if (string.IsNullOrEmpty(telefono) || string.IsNullOrEmpty(direccion))
            {
                nuevoUsuario = new Usuario(nombre, apellido, dni);
            }
            else 
            {
                nuevoUsuario = new Usuario(nombre, apellido, dni, telefono, direccion);
            }

            this.DialogResult = DialogResult.OK;

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
