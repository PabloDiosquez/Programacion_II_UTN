using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola
{
    /// <summary>
    /// Clase para gestionar operaciones de lectura y escritura de archivos en una carpeta específica en el escritorio.
    /// </summary>
    public static class ArchivoBis
    {
        static string ruta;         // Ruta base del escritorio
        static string rutaCarpeta;  // Ruta completa de la carpeta de archivos

        /// <summary>
        /// Constructor estático de la clase ArchivoBis que inicializa las rutas.
        /// </summary>
        static ArchivoBis()
        {
            ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            rutaCarpeta = $"{ruta}/Archivos";
        }

        /// <summary>
        /// Escribe el contenido de un archivo en la carpeta específica.
        /// </summary>
        /// <param name="texto">El texto que se escribirá en el archivo.</param>
        public static void Escribir(string texto)
        {
            try
            {
                string rutaCompleta = $"{rutaCarpeta}/segundaPrueba.txt";

                // Verifica si la carpeta de archivos no existe y la crea si es necesario
                if (!Directory.Exists(rutaCarpeta))
                {
                    Directory.CreateDirectory(rutaCarpeta);
                }

                // Escribe el contenido en el archivo
                File.WriteAllText(rutaCompleta, texto);
            }
            catch (Exception ex)
            {
                throw new Exception($"Algo salió mal con el archivo: {ex.Message}");
            }
        }

        /// <summary>
        /// Lee el contenido de un archivo específico en la carpeta de archivos.
        /// </summary>
        /// <param name="pathArchivo">El nombre del archivo a leer.</param>
        /// <returns>El contenido del archivo leído.</returns>
        public static string Leer(string pathArchivo)
        {
            string rutaCompleta = $"{ruta}/{pathArchivo}";

            try
            {
                // Lee y devuelve el contenido del archivo
                return File.ReadAllText(rutaCompleta);
            }
            catch (Exception ex)
            {
                throw new Exception($"Algo salió mal con la lectura del archivo: {ex.Message}");
            }
        }
    }
}
