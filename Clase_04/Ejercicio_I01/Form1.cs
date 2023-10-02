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
    public partial class Ingreso_Datos : Form
    {
        public Ingreso_Datos()
        {
            InitializeComponent();
        }

        private void btn_saludar_Click(object sender, EventArgs e)
        {
            string nombre = this.tbx_nombre.Text;   

            string apellido = this.tbx_apellido.Text;

            if (!(string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido)))
            {
                Saludo frm_saludo = new Saludo(nombre, apellido);

                frm_saludo.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos solicitados 🤔");
            }
        }
    }
}
