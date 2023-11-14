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
                using (StreamWriter sw = new StreamWriter(path, true))
                {
                    JsonSerializerOptions options = new JsonSerializerOptions();    

                    options.WriteIndented = true;   

                    sw.Write(JsonSerializer.Serialize(objeto, typeof(T)), options);
                }

                Console.WriteLine("Operación de escritura exitosa.");
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

        public static void VaciarJson(string path)
        {
            // Crear un objeto vacío o el tipo de objeto que necesites
            T objetoVacio = null;

            try
            {
                using (StreamWriter sw = new StreamWriter(path, true))
                {
                    JsonSerializer.Serialize(objetoVacio, typeof(T));
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
