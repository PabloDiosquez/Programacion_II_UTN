using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_C03
{
    public partial class Conversor : Form
    {
        public Conversor()
        {
            InitializeComponent();
        }

        private void btn_decimal_a_binario_Click(object sender, EventArgs e)
        {
            string numeroDecimal = this.tbx_decimal_a_binario.Text;

            this.tbx_resultado_decimal_a_binario.Text = Helper.DeDecimalABinario(Convert.ToInt32(numeroDecimal));
        }

        private void btn_binario_a_decimal_Click(object sender, EventArgs e)
        {
            string numeroBinario = this.tbx_binario_a_decimal.Text;

            if (Helper.esBinario(numeroBinario))
            {
                this.txb_resultado_binario_a_decimal.Text = Helper.DeBinarioADecimal(numeroBinario).ToString();
            }
            else 
            {
                MessageBox.Show("Asegúrese de ingresar un número binario válido 🤔", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
