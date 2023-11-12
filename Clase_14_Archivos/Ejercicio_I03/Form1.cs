using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_I03
{
    public partial class frm_Notepad : Form
    {
        public frm_Notepad()
        {
            InitializeComponent();
        }

        private void mstrip_abrir_Click(object sender, EventArgs e)
        {
            // Inicializa el OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Establece propiedades del OpenFileDialog

            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt";

            openFileDialog.Title = "Selecciona un archivo";

            // Muestra el diálogo y verifica si el usuario ha elegido un archivo

            if (openFileDialog.ShowDialog() == DialogResult.OK) 
            {
                try
                {
                    // Obtiene la ruta del archivo seleccionado
                    string nombreArchivo = openFileDialog.FileName;

                    // Aquí se puede trabajar con el archivo. Por ejemplo, leerlo.

                    string contenido = File.ReadAllText(nombreArchivo);

                    // Mostrar el contenido del archivo en el richTextBox

                    this.rtb_notepad.Text = contenido;
                }
                catch (Exception ex)
                {
                    // Maneja cualquier excepción que pueda ocurrir al trabajar con el archivo

                    throw new Exception($"Error al abrir el archivo: {ex.Message}");
                }
            }

        }
    }
}
