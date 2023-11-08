using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola
{
    /// <summary>
    /// Clase estática para operaciones de manejo de archivos.
    /// </summary>
    public static class Archivo
    {
        // Ruta para el escritorio del usuario.
        static string ruta;

        // Ruta del directorio en el que se encuentra la aplicación.
        static string rutaProyecto;

        // Constructor estático de la clase Archivo.
        static Archivo()
        {
            // Obtiene la ruta del escritorio del usuario.
            ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            // Obtiene la ruta del directorio en el que se encuentra la aplicación.
            rutaProyecto = AppDomain.CurrentDomain.BaseDirectory;
        }

        public static void EscribirUnaLinea(string path, string texto) 
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(texto);
            }
        }

        /// <summary>
        /// Esta función crea un archivo de texto en el escritorio del usuario y escribe la fecha y hora actual en él.
        /// </summary>
        public static void Escribir()
        {
            // Define el nombre del archivo a crear.
            string nombreArchivo = "prueba.txt";

            // Define una carpeta en el escritorio donde se almacenarán los archivos.
            string rutaCarpeta = $"{ruta}/Archivos";

            // Crea la ruta completa del archivo utilizando la ruta de la carpeta y el nombre del archivo.
            string rutaCompleta = $"{rutaCarpeta}/{nombreArchivo}";

            // Verifica si la carpeta de destino existe; si no, la crea.
            if (!Directory.Exists(rutaCarpeta))
            {
                Directory.CreateDirectory(rutaCarpeta);
            }

            try
            {
                //Abre un StreamWriter y escribe la fecha y hora actual en el archivo.
                using (StreamWriter sw = new StreamWriter(rutaCompleta, true))
                {
                    sw.WriteLine(DateTime.Now.ToString());
                }

                //EscribirUnaLinea(rutaCompleta, DateTime.Now.ToString());
            }
            catch (Exception ex)
            {
                // Captura cualquier excepción y lanza una excepción personalizada.
                throw new Exception($"Error en el archivo {rutaCompleta}: {ex.Message}");
            }

            // Muestra un mensaje de éxito en la consola.
            Console.WriteLine("Archivo creado con éxito.");
        }

        /// <summary>
        /// Escribe el texto en un archivo en la ruta especificada, permitiendo la opción de agregar al archivo existente o reemplazarlo.
        /// </summary>
        /// <param name="pathArchivo">El nombre o ruta relativa del archivo donde se escribirá el texto.</param>
        /// <param name="texto">El texto que se va a escribir en el archivo.</param>
        /// <param name="appendear">Indica si se debe agregar el texto al final del archivo existente (true) o reemplazar el contenido del archivo (false).</param>
        public static void Escribir(string pathArchivo, string texto, bool appendear)
        {
            // Construye la ruta completa del archivo.
            string rutaCompleta = $"{ruta}/{pathArchivo}";

            StreamWriter sw = null;

            try
            {
                // Inicializa un StreamWriter para escribir en el archivo.
                sw = new StreamWriter(rutaCompleta, appendear);

                // Escribe el texto en el archivo
                sw.WriteLine(texto);
            }
            catch (Exception ex)
            {
                // Captura cualquier excepción y la lanza nuevamente.
                throw new Exception(ex.Message);
            }
            finally
            {
                // Asegura que se cierre el StreamWriter, si está abierto.
                if (sw is not null) sw.Close();
            }
        }

        /// <summary>
        /// Esta función lee un archivo de texto y devuelve su contenido como una cadena.
        /// </summary>
        /// <param name="rutaArchivo">La ruta relativa del archivo a leer.</param>
        /// <returns>El contenido del archivo como una cadena.</returns>
        public static string Leer(string rutaArchivo)
        {
            // Construye la ruta completa del archivo a leer.
            string rutaCompleta = $"{ruta}/{rutaArchivo}";

            try
            {
                string texto;

                // Abre un StreamReader para leer el archivo.
                using (StreamReader sr = new StreamReader(rutaCompleta))
                {
                    // Lee todo el contenido del archivo y lo almacena en una cadena.
                    texto = sr.ReadToEnd();
                }

                return texto;
            }
            catch (Exception ex)
            {
                // Captura cualquier excepción y lanza una excepción personalizada.
                throw new Exception($"Error en el archivo {rutaCompleta}: {ex.Message}");
            }
        }
    }
}
