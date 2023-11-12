﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Biblioteca
{
    /// <summary>
    /// Clase que serializa objetos genéricos a XML y los deserializa desde archivos.
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
                using (StreamReader sw = new StreamReader(path))
                {
                    // Crea un serializador XML para el tipo T.
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));

                    // Deserializa el objeto desde el archivo y lo devuelve.
                    return xmlSerializer.Deserialize(sw) as T;
                }
            }
            catch (Exception ex)
            {
                // Captura cualquier excepción y la lanza como una nueva excepción con un mensaje personalizado.
                throw new Exception($"Algo salió mal 🥴: {ex.Message}");
            }
        }
    }
}
