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

        /// <summary>
        /// Maneja el evento Click del botón "Calcular". Este método procesa el texto ingresado en el cuadro de texto
        /// para contar las palabras y muestra un cuadro de diálogo con el recuento de palabras ordenado.
        /// </summary>
        /// <param name="sender">El objeto que desencadenó el evento (el botón).</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void btn_calcular_Click(object sender, EventArgs e)
        {
            // Obtiene el texto ingresado en el cuadro de texto.
            string texto = rtb_contador.Text;

            // Verifica si el texto no está vacío.
            if (!string.IsNullOrEmpty(texto))
            {
                // Llama a la función ContadorDePalabras para contar las palabras y las ordena en orden descendente por cantidad.
                var listaDeParesClaveValorOrdenada = ContadorDePalabras(texto).OrderByDescending(x => x.Value);

                // Inicializa una cadena para almacenar las palabras y sus conteos.
                string palabras = string.Empty;

                // Recorre la lista de pares clave-valor y construye la cadena de palabras.
                foreach (var parClaveValor in listaDeParesClaveValorOrdenada)
                {
                    palabras += $"{parClaveValor.Key}: {parClaveValor.Value}\n";
                }

                // Muestra un cuadro de diálogo con las palabras y sus conteos ordenados.
                MessageBox.Show(palabras, "Diccionario de palabras", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Muestra un cuadro de diálogo de error si el cuadro de texto está vacío.
                MessageBox.Show("Por favor, ingrese texto en la caja de texto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
