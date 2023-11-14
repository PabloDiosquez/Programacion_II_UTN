using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Biblioteca_Supermercado
{
    public class SerializadorXML<T> : IPersistencia<T> where T : class, new()
    {
        public void Almacenar(T objeto, string path)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(path))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));

                    xmlSerializer.Serialize(sw, objeto);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al almacenar el archivo: {ex.Message}");
            }
        }

        public T Recuperar(string path)
        {
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));

                    return xmlSerializer.Deserialize(sr) as T;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al recuperar el archivo: {ex.Message}");
            }
        }
    }
}
