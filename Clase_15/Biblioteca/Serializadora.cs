using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Biblioteca
{
    /// <summary>
    /// Clase que serializa objetos genéricos a XML y JSON, y los deserializa desde archivos.
    /// </summary>
    /// <typeparam name="T">Tipo de objeto a serializar y deserializar.</typeparam>
    public static class Serializadora<T>
        where T : class, new()
    {
        /// <summary>
        /// Guarda un objeto en formato XML en la ruta especificada.
        /// </summary>
        /// <param name="objeto">Objeto a serializar.</param>
        /// <param name="path">Ruta del archivo XML donde se guardará el objeto.</param>
        public static void GuardarXml(T objeto, string path)
        {
            try
            {
                // Abre un flujo de escritura para el archivo XML.
                using (StreamWriter sw = new StreamWriter(path, true))
                {
                    // Crea un serializador XML para el tipo T.
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));

                    // Serializa el objeto y lo escribe en el archivo.
                    xmlSerializer.Serialize(sw, objeto);
                }
            }
            catch (Exception ex)
            {
                // Captura cualquier excepción y la lanza como una nueva excepción con un mensaje personalizado.
                throw new Exception($"Algo salió mal 🥴: {ex.Message}");
            }
        }

        /// <summary>
        /// Lee un objeto en formato XML desde la ruta especificada.
        /// </summary>
        /// <param name="path">Ruta del archivo XML que contiene el objeto a leer.</param>
        /// <returns>El objeto deserializado.</returns>
        public static T LeerXml(string path)
        {
            if (path is null) throw new ArgumentNullException("path");

            try
            {
                // Abre un flujo de lectura para el archivo XML.
                using (StreamReader sr = new StreamReader(path))
                {
                    // Crea un serializador XML para el tipo T.
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));

                    // Deserializa el objeto desde el archivo y lo devuelve.
                    return xmlSerializer.Deserialize(sr) as T;
                }
            }
            catch (Exception ex)
            {
                // Captura cualquier excepción y la lanza como una nueva excepción con un mensaje personalizado.
                throw new Exception($"Algo salió mal 🥴: {ex.Message}");
            }
        }

        /// <summary>
        /// Guarda un objeto en formato JSON en la ruta especificada.
        /// </summary>
        /// <param name="objeto">Objeto a serializar.</param>
        /// <param name="path">Ruta del archivo JSON donde se guardará el objeto.</param>
        public static void GuardarJSON(T objeto, string path)
        {
            if (path is null) throw new ArgumentNullException("path");

            JsonSerializerOptions options = new JsonSerializerOptions();
            options.WriteIndented = true;

            try
            {
                // Abre un flujo de escritura para el archivo JSON.
                using (StreamWriter sw = new StreamWriter(path))
                {
                    // Serializa el objeto en formato JSON y lo escribe en el archivo.
                    sw.Write(JsonSerializer.Serialize(objeto, typeof(T), options));
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Algo salió mal 🥴: {ex.Message}");
            }
        }

        /// <summary>
        /// Lee un objeto en formato JSON desde la ruta especificada.
        /// </summary>
        /// <param name="path">Ruta del archivo JSON que contiene el objeto a leer.</param>
        /// <returns>El objeto deserializado.</returns>
        public static T LeerJSON(string path)
        {
            if (path is null) throw new ArgumentNullException("path");

            T objeto = default(T);

            try
            {
                // Abre un flujo de lectura para el archivo JSON.
                using (StreamReader sr = new StreamReader(path))
                {
                    // Deserializa el objeto desde el archivo JSON.
                    objeto = JsonSerializer.Deserialize<T>(sr.ReadToEnd());
                }
                return objeto;
            }
            catch (Exception ex)
            {
                throw new Exception($"Algo salió mal 🥴: {ex.Message}");
            }
        }
    }
}
