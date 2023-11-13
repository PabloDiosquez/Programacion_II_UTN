using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_I01
{
    public partial class FrmAltaModificacion : Form
    {
        public FrmAltaModificacion(string titulo, string contenidoTextBox, string btnConfirmarTexto)
        {
            InitializeComponent();

            this.Text = titulo;

            this.textObjeto.Text = contenidoTextBox;

            this.btnConfirmar.Text = btnConfirmarTexto;
        }
        public string Objeto { get { return this.textObjeto.Text; } }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Validar_Y_Confirmar();
        }
        private void textObjeto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) // 13 es el código ASCII que representa a ENTER.
            {
                Validar_Y_Confirmar();
            }

            else if (e.KeyChar == (char)27) // 27 es el código ASCII que representa a ESC.
            {
                Cancelar();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }

        // Métodos auxiliares 

        private void Validar_Y_Confirmar()
        {
            if (!string.IsNullOrEmpty(this.textObjeto.Text))
            {
                DialogResult = DialogResult.OK;

                this.Close();
            }
            else
            {
                MessageBox.Show("La caja de texto no puede quedar vacía 🥴", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cancelar()
        {
            DialogResult= DialogResult.Cancel;

            this.Close();
        }
    }
}
