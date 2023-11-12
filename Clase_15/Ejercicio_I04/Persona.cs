using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Ejercicio_I04
{
    public class Persona
    {
        // Atributos 

        private string nombre;

        private string apellido;

        // Propiedades
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }

        // Constructores 

        public Persona() { }

        public Persona(string nombre, string apellido) 
        {
            this.Nombre = nombre;

            this.Apellido = apellido;
        }

        // Sobrecarga del método ToString()

        public override string ToString()
        {
            return $"[Nombre: {Nombre}, Apellido: {Apellido}]";
        }

        // Métodos estáticos 

        public static void GuardarXML(Persona persona) 
        {
            string path = string.Empty;

            try
            {
                using (StreamWriter sw = new StreamWriter(path))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(Persona));

                    xmlSerializer.Serialize(sw, persona);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static Persona LeerXML()
        {
            string path = string.Empty;

            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(Persona));

                    return xmlSerializer.Deserialize(sr) as Persona;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void GuardarJSON(Persona persona)
        {
            string path = string.Empty;

            JsonSerializerOptions options = new JsonSerializerOptions();

            options.WriteIndented = true;   

            try
            {
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.Write(JsonSerializer.Serialize(persona, typeof(Persona), options));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static Persona LeerJSON() 
        {
            string path = string.Empty;

            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    return JsonSerializer.Deserialize<Persona>(sr.ReadToEnd()) as Persona;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
