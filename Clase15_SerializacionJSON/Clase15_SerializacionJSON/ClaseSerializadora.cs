using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Clase15_SerializacionJSON
{
    public static class ClaseSerializadora<T>
    {
        // Atributos 

        static string ruta;

        static string rutaDir;

        // Constructor 

        static ClaseSerializadora()
        {
            ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            rutaDir = @$"{ruta}\ArchivosJSON";
        }

        public static void Escribir(T datos, string path)
        {
            try
            {
                if (!Directory.Exists(rutaDir))
                {
                    Directory.CreateDirectory(rutaDir);
                }

                string fullPath = Path.Combine(rutaDir, path);

                string objetoJson = JsonSerializer.Serialize(datos);

                File.WriteAllText(fullPath, objetoJson);

            }
            catch (Exception ex)
            {
                throw new Exception($"Algo salió mal: {ex.Message}");
            }
        }

        public static T Leer(string path)
        {



            return default(T);
        }
    }
}
