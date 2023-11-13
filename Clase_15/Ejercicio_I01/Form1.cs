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
        public string Objeto { get { return this.textObjeto.Text; } }

        public FrmAltaModificacion()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.textObjeto.Text)) 
            {
                MessageBox.Show("La caja de texto no puede quedar vacía 🥴");
            }
            else 
            {
                DialogResult = DialogResult.OK;

                this.Close();
            }
        }
    }
}
