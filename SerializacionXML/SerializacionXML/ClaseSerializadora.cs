using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SerializacionXML
{
    /// <summary>
    /// Clase que proporciona métodos para serializar objetos Personaje en archivos XML.
    /// </summary>
    public class ClaseSerializadora
    {
        // Atributos

        /// <summary>
        /// Ruta base donde se guardarán los archivos serializados.
        /// </summary>
        static string ruta;

        /// <summary>
        /// Ruta completa para el directorio donde se guardarán los archivos serializados.
        /// </summary>
        static string rutaDir;

        // Constructores
        static ClaseSerializadora()
        {
            // Obtiene la ruta del escritorio del sistema.
            ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            // Combina la ruta base con el nombre del directorio de archivos serializados.
            rutaDir = $"{ruta}/ArchivosSerializadora";
        }

        // Métodos

        /// <summary>
        /// Serializa un objeto Personaje y lo escribe en un archivo XML.
        /// </summary>
        /// <param name="personaje">El objeto Personaje a serializar.</param>
        public static void Escribir(Personaje personaje)
        {
            // Construye la ruta completa del archivo XML para el objeto Personaje.
            string rutaArchivo = $"{rutaDir}/personajesSerializados.xml";

            try
            {
                // Verifica si el directorio de archivos serializados existe y, si no, lo crea.
                if (!Directory.Exists(rutaDir)) Directory.CreateDirectory(rutaDir);

                // Abre un StreamWriter para escribir en el archivo XML.
                using (StreamWriter sw = new StreamWriter(rutaArchivo, true))
                {
                    // Crea un XmlSerializer para serializar objetos Personaje.
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(Personaje));

                    // Serializa el objeto Personaje y lo escribe en el archivo.
                    xmlSerializer.Serialize(sw, personaje);
                }
            }
            catch (Exception ex)
            {
                // Captura excepciones y las relanza con un mensaje personalizado.
                throw new Exception($"Ocurrió un error con el archivo: {ex.Message}");
            }
        }

        /// <summary>
        /// Serializa una lista de objetos Personaje y la escribe en un archivo XML.
        /// </summary>
        /// <param name="personajes">La lista de objetos Personaje a serializar.</param>
        public static void Escribir(List<Personaje> personajes)
        {
            // Si la lista está vacía, no se realiza la serialización.
            if (personajes.Count == 0) return;

            // Construye la ruta completa del archivo XML para la lista de Personajes.
            string rutaArchivo = $"{rutaDir}/listaPersonajes.xml";

            try
            {
                // Verifica si el directorio de archivos serializados existe y, si no, lo crea.
                if (!Directory.Exists(rutaDir)) Directory.CreateDirectory(rutaDir);

                // Abre un StreamWriter para escribir en el archivo XML.
                using (StreamWriter sw = new StreamWriter(rutaArchivo, true))
                {
                    // Crea un XmlSerializer para serializar listas de objetos Personaje.
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Personaje>));

                    // Serializa la lista de Personajes y la escribe en el archivo.
                    xmlSerializer.Serialize(sw, personajes);
                }
            }
            catch (Exception ex)
            {
                // Captura excepciones y las relanza con un mensaje personalizado.
                throw new Exception($"Ocurrió un error: {ex.Message}");
            }
        }
    }
}
