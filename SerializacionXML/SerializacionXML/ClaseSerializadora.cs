using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SerializacionXML
{
    public class ClaseSerializadora
    {
        // Atributos 

        static string ruta;

        static string rutaDir;

        // Constructores 
        static ClaseSerializadora() 
        {
            ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            rutaDir = $"{ruta}/ArchivosSerializadora";
        }

        // Métodos 

        public static void Escribir(Personaje personaje)
        {
            string rutaArchivo = $"{rutaDir}/personajesSerializados.xml";

            try
            {
                if(!Directory.Exists(rutaDir)) Directory.CreateDirectory(rutaDir);

                using (StreamWriter sw = new StreamWriter(rutaArchivo, true))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(Personaje));

                    xmlSerializer.Serialize(sw, personaje);
                }

            }
            catch (Exception ex)
            {
                throw new Exception($"Ocurrió un error con el archivo: {ex.Message}");
            }
        }
    }
}
