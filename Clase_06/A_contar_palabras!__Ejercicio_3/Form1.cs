using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_contar_palabras___Ejercicio_3
{
    public partial class frm_principal : Form
    {
        public frm_principal()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            string texto = rtb_contenedor.Text;

            string[] palabras = texto.Split(' ');

            Dictionary<string, int> dicc = new Dictionary<string, int>();

            foreach (string palabra in palabras)
            {
                if (dicc.ContainsKey(palabra))
                {
                    dicc[palabra]++;
                }
                else 
                {
                    dicc.Add(palabra, 1);
                }
            }
            

        }
    }
}
