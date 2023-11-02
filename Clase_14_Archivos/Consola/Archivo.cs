using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola
{
    public class Archivo
    {
        /// <summary>
        /// Esta función crea un archivo de texto en el escritorio del usuario y escribe cuatro líneas de texto en él.
        /// </summary>
        public static void Escribir()
        {
            // Obtiene la ruta del escritorio del usuario.
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            // Obtiene la ruta del directorio en el que se encuentra la aplicación.
            string rutaProyecto = AppDomain.CurrentDomain.BaseDirectory;

            // Define el nombre del archivo a crear.
            string nombreArchivo = "prueba.txt";

            // Crea un StreamWriter para escribir en el archivo de texto.
            StreamWriter sw = new StreamWriter($"{ruta}/{nombreArchivo}");

            // Escribe cuatro líneas de texto en el archivo.
            sw.WriteLine("Línea 1");
            sw.WriteLine("Línea 2");
            sw.WriteLine("Línea 3");
            sw.WriteLine("Línea 4");

            // Cierra el StreamWriter para liberar los recursos.
            sw.Close();
        }
    }
}
