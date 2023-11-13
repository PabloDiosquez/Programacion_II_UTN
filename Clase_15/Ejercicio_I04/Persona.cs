using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Ejercicio_I04
{
    /// <summary>
    /// Representa a una persona con nombre y apellido.
    /// </summary>
    public class Persona
    {
        // Atributos
        private string nombre;
        private string apellido;

        // Propiedades
        /// <summary>
        /// Obtiene o establece el nombre de la persona.
        /// </summary>
        public string Nombre { get => nombre; set => nombre = value; }

        /// <summary>
        /// Obtiene o establece el apellido de la persona.
        /// </summary>
        public string Apellido { get => apellido; set => apellido = value; }

        // Constructores
        /// <summary>
        /// Constructor por defecto de Persona.
        /// </summary>
        public Persona() { }

        /// <summary>
        /// Constructor de Persona que recibe nombre y apellido.
        /// </summary>
        /// <param name="nombre">Nombre de la persona.</param>
        /// <param name="apellido">Apellido de la persona.</param>
        public Persona(string nombre, string apellido)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
        }

        // Sobrecarga del método ToString()
        /// <summary>
        /// Devuelve una representación en cadena de la persona.
        /// </summary>
        /// <returns>Cadena con el nombre y apellido de la persona.</returns>
        public override string ToString()
        {
            return $"[Nombre: {Nombre}, Apellido: {Apellido}]";
        }

        // Métodos estáticos

        /// <summary>
        /// Guarda los datos de una persona en un archivo XML en la ruta especificada.
        /// </summary>
        /// <param name="persona">Persona a ser guardada en XML.</param>
        /// <param name="path">Ruta del archivo XML.</param>
        public static void GuardarXML(Persona persona, string path)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(path))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(Persona));
                    xmlSerializer.Serialize(sw, persona);
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Error al guardar en XML: Nombre de archivo inválido.");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Lee los datos de una persona desde un archivo XML en la ruta especificada.
        /// </summary>
        /// <param name="path">Ruta del archivo XML.</param>
        /// <returns>Persona leída desde el archivo XML.</returns>
        public static Persona LeerXML(string path)
        {
            try
            {
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(Persona));
                    return xmlSerializer.Deserialize(fs) as Persona;
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("La ruta del archivo no debe ser vacía.");
                throw ex;
            }
            catch (SerializationException ex)
            {
                Console.WriteLine("Error al leer desde XML: Problema de deserialización.");
                Console.WriteLine(ex.Message);
                throw;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Guarda los datos de una persona en un archivo JSON en la ruta especificada.
        /// </summary>
        /// <param name="persona">Persona a ser guardada en JSON.</param>
        /// <param name="path">Ruta del archivo JSON.</param>
        public static void GuardarJSON(Persona persona, string path)
        {
            JsonSerializerOptions options = new JsonSerializerOptions();
            options.WriteIndented = true;

            try
            {
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.Write(JsonSerializer.Serialize(persona, typeof(Persona), options));
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Error al guardar en JSON: Nombre de archivo inválido.");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Lee los datos de una persona desde un archivo JSON en la ruta especificada.
        /// </summary>
        /// <param name="path">Ruta del archivo JSON.</param>
        /// <returns>Persona leída desde el archivo JSON.</returns>
        public static Persona LeerJSON(string path)
        {
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    return JsonSerializer.Deserialize<Persona>(sr.ReadToEnd()) as Persona;
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Error al leer en JSON: Nombre de archivo inválido.");
                Console.WriteLine(ex.Message);
                throw;
            }
            catch (JsonException ex)
            {
                Console.WriteLine("Error al leer desde JSON: Problema de deserialización.");
                Console.WriteLine(ex.Message);
                throw;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
