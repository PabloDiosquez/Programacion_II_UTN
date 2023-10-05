using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Ejercicio_3BIS.Helper;

namespace Ejercicio_3BIS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            string texto = rtb_contador.Text;

            MessageBox.Show(MostrarDatos(ContadorDePalabras(texto)));

            this.Close();
        }
    }
}
