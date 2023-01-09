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
            Dictionary<string, int> contadorPalabras = ObtenerContadorPalabras();

            // Lista de pares 👉🏼 Clave: Valor

            List<KeyValuePair<string, int>> podio = contadorPalabras.ToList();

            podio.Sort(OrdenDecreciente);

            MostrarPodio(podio);
        }
        private Dictionary<string, int> ObtenerContadorPalabras()
        {
            string texto = rtb_contenedor.Text;

            char[] separador = new char[] {' ', ',', '.', ':', '\t', '\n'};

            string[] palabras = texto.Split(separador, StringSplitOptions.RemoveEmptyEntries);

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

            return dicc;
        }

        private int OrdenDecreciente(KeyValuePair<string, int> a, KeyValuePair<string, int> b) 
        {
            return b.Value - a.Value;
        }

        private void MostrarPodio(List<KeyValuePair<string, int>> podio) 
        {
            StringBuilder sb = new StringBuilder(); 

            foreach (KeyValuePair<string, int> item in podio) 
            {
                sb.AppendLine($"Palabra: {item.Key} 👉🏼 Cantidad: {item.Value}");
            }

            MessageBox.Show(sb.ToString());
        }
    }
}
