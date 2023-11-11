using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Clase15_SerializacionJSON
{
    /// <summary>
    /// Clase estática para serializar y deserializar objetos a/desde archivos JSON.
    /// </summary>
    public static class ClaseSerializadora<T>
    {
        // Atributos 

        /// <summary>
        /// Ruta del directorio base.
        /// </summary>
        static string ruta;

        /// <summary>
        /// Ruta completa para el directorio de archivos JSON.
        /// </summary>
        static string rutaDir;

        // Constructor 

        /// <summary>
        /// Constructor estático que inicializa la ruta base y el directorio para los archivos JSON.
        /// </summary>
        static ClaseSerializadora()
        {
            ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            rutaDir = @$"{ruta}\ArchivosJSON";
        }

        /// <summary>
        /// Método estático para escribir datos serializados en un archivo JSON.
        /// </summary>
        /// <param name="datos">Datos a ser serializados.</param>
        /// <param name="path">Ruta del archivo en la que se escribirán los datos serializados.</param>
        public static void Escribir(T datos, string path)
        {
            try
            {
                if (!Directory.Exists(rutaDir))
                {
                    // Verifica si el directorio no existe, de lo contrario lo crea
                    Directory.CreateDirectory(rutaDir);
                }

                // Obtiene la ruta completa del archivo
                string fullPath = Path.Combine(rutaDir, path);

                // Serializa el objeto a formato JSON
                string objetoJson = JsonSerializer.Serialize(datos);

                // Escribe el JSON en el archivo
                File.WriteAllText(fullPath, objetoJson);
            }
            catch (Exception ex)
            {
                // Captura cualquier excepción y la lanza como una nueva excepción con un mensaje personalizado
                throw new Exception($"Algo salió mal: {ex.Message}");
            }
        }

        /// <summary>
        /// Método estático para leer datos desde un archivo JSON y deserializarlos.
        /// </summary>
        /// <param name="path">Ruta del archivo JSON a leer.</param>
        /// <returns>Los datos deserializados.</returns>
        public static T Leer(string path)
        {
            T objetoRecuperado = default(T);

            try
            {
                // Combina la ruta base con la ruta del archivo
                path = Path.Combine(rutaDir, path);

                // Lee el JSON desde el archivo
                string json = File.ReadAllText(path);

                // Deserializa el JSON y asigna los datos al objeto recuperado
                objetoRecuperado = JsonSerializer.Deserialize<T>(json);
            }
            catch (Exception ex)
            {
                // Captura cualquier excepción y la lanza como una nueva excepción con un mensaje personalizado
                throw new Exception($"Algo salió mal: {ex.Message}");
            }
            return objetoRecuperado;
        }
    }
}
