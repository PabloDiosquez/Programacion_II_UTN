using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola
{
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

        /// <summary>
        /// Esta función crea un archivo de texto en el escritorio del usuario y escribe tres líneas de texto en él.
        /// </summary>
        public static void Escribir()
        {
            // Define el nombre del archivo a crear.
            string nombreArchivo = "prueba.txt";

            string rutaCarpeta = $"{ruta}/Archivos";

            // Crea la ruta completa del archivo utilizando la ruta del escritorio y el nombre del archivo.
            string rutaCompleta = $"{ruta}/Archivos/{nombreArchivo}";

            if (!Directory.Exists(rutaCarpeta))
            {
                Directory.CreateDirectory(rutaCarpeta);
            }

            try
            {
                // Abre un StreamWriter y escribe en el archivo.
                using (StreamWriter sw = new StreamWriter(rutaCompleta))
                {
                    // Escribe tres líneas de texto en el archivo.
                    sw.WriteLine("Línea de prueba 1");
                    sw.WriteLine("Línea de prueba 2");
                    sw.WriteLine("Línea de prueba 3");
                    sw.WriteLine("Línea de prueba 4");
                }
            }
            catch (Exception ex)
            {
                // Captura cualquier excepción y lanza una excepción personalizada.
                throw new Exception($"Error en el archivo {ruta}/{nombreArchivo}: {ex.Message}");
            }

            // Muestra un mensaje de éxito en la consola.
            Console.WriteLine("Archivo creado con éxito.");
        }

        public static string Leer(string rutaArchivo)
        {
            string rutaCompleta = $"{ruta}/{rutaArchivo}";

            try
            {
                string texto = string.Empty;

                StreamReader sr = new StreamReader(rutaCompleta);

                string linea;

                while ((linea = sr.ReadLine()) is not null)
                {
                    texto += $"{linea}\n";
                }

                return texto;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error en el archivo {rutaCompleta}: {ex.Message}");
            }
        }
    }
}
