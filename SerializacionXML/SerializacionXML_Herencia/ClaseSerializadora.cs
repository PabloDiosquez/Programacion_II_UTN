using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SerializacionXML_Herencia
{
    /// <summary>
    /// Clase genérica para serializar y deserializar objetos a/desde XML.
    /// </summary>
    /// <typeparam name="T">Tipo de datos a serializar/deserializar.</typeparam>
    public class ClaseSerializadora<T>
    {
        // Ruta del directorio de escritura
        static string ruta;

        // Ruta completa para el directorio de serialización
        static string rutaDir;

        /// <summary>
        /// Constructor estático que inicializa la ruta y el directorio de escritura.
        /// </summary>
        static ClaseSerializadora()
        {
            // Obtiene la ruta del escritorio del usuario
            ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            // Establece la ruta completa del directorio de serialización
            rutaDir = $"{ruta}/SerializaciónHerencia";
        }

        /// <summary>
        /// Método estático para escribir datos serializados en un archivo XML.
        /// </summary>
        /// <param name="datos">Datos a ser serializados.</param>
        public static void Escribir(T datos)
        {
            // Ruta completa del archivo a escribir
            string rutaArchivo = $"{rutaDir}/personaje.xml";

            try
            {
                // Verifica si el directorio existe, de lo contrario lo crea
                if (Directory.Exists(rutaDir)) Directory.CreateDirectory(rutaDir);

                // Escribe los datos serializados en un archivo XML
                using (StreamWriter sw = new StreamWriter(rutaArchivo))
                {
                    // Inicializa un XmlSerializer para el tipo T
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));

                    // Serializa los datos en el archivo
                    xmlSerializer.Serialize(sw, datos);
                }
            }
            catch (Exception ex)
            {
                // Captura cualquier excepción y la lanza como una nueva excepción con un mensaje personalizado
                throw new Exception($"Ocurrió algo inesperado: {ex.Message}");
            }
        }

        /// <summary>
        /// Método estático para leer datos desde un archivo XML y deserializarlos.
        /// </summary>
        /// <param name="path">Ruta del archivo XML a leer.</param>
        /// <returns>Los datos deserializados.</returns>
        public static T Leer(string path)
        {
            // Verifica si la ruta es nula o vacía y lanza una excepción si es así
            if (string.IsNullOrEmpty(path)) throw new ArgumentNullException("path");

            // Inicializa los datos con el valor predeterminado de T
            T datos = default(T);

            try
            {
                // Lee los datos desde el archivo XML
                using (StreamReader sr = new StreamReader(path))
                {
                    // Inicializa un XmlSerializer para el tipo T
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));

                    // Deserializa los datos del archivo y los asigna a la variable
                    datos = (T)xmlSerializer.Deserialize(sr);
                }
            }
            catch (Exception ex)
            {
                // Captura cualquier excepción y la lanza como una nueva excepción con un mensaje personalizado
                throw new Exception($"Ocurrió algo inesperado: {ex.Message}");
            }
            return datos; // Devuelve los datos deserializados
        }
    }
}
