using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Biblioteca
{
    public static class Serializadora
    {
        public static void GuardarXml(Alumno alumno, string path)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(path))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(Alumno));

                    xmlSerializer.Serialize(sw, alumno);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Algo salió mal 🥴: {ex.Message}");
            }
        }
    }
}
