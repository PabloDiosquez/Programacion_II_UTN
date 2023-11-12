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
    /// <summary>
    /// Clase parcial que representa un bloc de notas simple.
    /// </summary>
    public partial class frm_Notepad : Form
    {
        private string ultimoArchivoAbierto; // Ruta del último archivo abierto.

        public frm_Notepad()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Propiedad que almacena la ruta del último archivo abierto.
        /// </summary>
        public string UltimoArchivoAbierto { get => ultimoArchivoAbierto; set => ultimoArchivoAbierto = value; }

        /// <summary>
        /// Manejador del evento Click del menú "Abrir".
        /// Abre un OpenFileDialog para seleccionar y cargar un archivo de texto.
        /// </summary>
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

                    this.UltimoArchivoAbierto = nombreArchivo;

                    // Lee el contenido del archivo seleccionado
                    string contenido = File.ReadAllText(nombreArchivo);

                    // Muestra el contenido del archivo en el richTextBox
                    this.rtb_notepad.Text = contenido;
                }
                catch (Exception ex)
                {
                    // Maneja cualquier excepción que pueda ocurrir al trabajar con el archivo
                    throw new Exception($"Error al abrir el archivo: {ex.Message}", ex);
                }
            }
        }

        /// <summary>
        /// Manejador del evento Click del menú "Guardar como".
        /// Abre un SaveFileDialog para guardar el contenido del richTextBox en un archivo de texto.
        /// </summary>
        private void mstrip_guardar_como_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt";
            saveFileDialog.Title = "Guardar como... ☂";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string nombreArchivo = saveFileDialog.FileName;

                    this.UltimoArchivoAbierto = nombreArchivo;

                    // Guarda el contenido del richTextBox en el archivo seleccionado
                    File.WriteAllText(nombreArchivo, this.rtb_notepad.Text);
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error al guardar el archivo: {ex.Message}", ex);
                }
            }
        }

        /// <summary>
        /// Manejador del evento Click del menú "Guardar".
        /// Guarda el contenido del richTextBox en el archivo seleccionado previamente o abre un SaveFileDialog si no hay uno seleccionado.
        /// </summary>
        private void mstrip_guardar_Click(object sender, EventArgs e)
        {
            if (UltimoArchivoAbierto is null)
            {
                // Si no hay un último archivo seleccionado, abre un SaveFileDialog
                SaveFileDialog saveFileDialog = new SaveFileDialog();

                saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt";
                saveFileDialog.Title = "Guardar 📚";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string nombreArchivo = saveFileDialog.FileName;

                        this.UltimoArchivoAbierto = nombreArchivo;

                        // Guarda el contenido del richTextBox en el archivo seleccionado
                        File.WriteAllText(nombreArchivo, rtb_notepad.Text);
                    }
                    catch (Exception ex)
                    {
                        throw new Exception($"Error al guardar el archivo: {ex.Message}", ex);
                    }
                }
            }
            else
            {
                // Si hay un archivo seleccionado, guarda directamente en ese archivo
                File.WriteAllText(UltimoArchivoAbierto, this.rtb_notepad.Text);
            }
        }
    }
}
