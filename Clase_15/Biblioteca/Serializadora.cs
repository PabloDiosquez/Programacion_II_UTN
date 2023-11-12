using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Biblioteca
{
    public static class Serializadora<T>
    {
        public static void GuardarXml(T objeto, string path)
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
                throw new Exception($"Algo salió mal 🥴: {ex.Message}");
            }
        }

        public static T LeerXml(string path)
        {
            if(path is null) throw new ArgumentNullException("path");

            T objeto = default(T);

            try
            {
                using (StreamReader sw = new StreamReader(path))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));

                    objeto = (T)xmlSerializer.Deserialize(sw);
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
