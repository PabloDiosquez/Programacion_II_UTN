using System;
using System.IO;
using System.Text.Json;
using System.Xml.Serialization;

namespace Biblioteca_Supermercado
{
    public class SerializadorJSON<T> : IPersistencia<T> where T : class, new()
    {
        public void Almacenar(T objeto, string path)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(path))
                {
                    JsonSerializer.Serialize(objeto, typeof(T));
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
                    string json = sr.ReadToEnd();   

                    return JsonSerializer.Deserialize(json, typeof(T)) as T;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al almacenar el archivo: {ex.Message}");
            }
        }
    }
}
