using System;
using System.IO;
using Biblioteca;

namespace Clase_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            try
            {
                string pathDirectorio = @$"{path}\ArchivosClase15";

                if (!Directory.Exists(pathDirectorio)) 
                {
                    Directory.CreateDirectory(pathDirectorio);
                }

                Alumno alumno = new Alumno()
                {
                    NombreCompleto = "Lio Messi",
                    Legajo = 123456,
                    Edad = 36
                };

                Serializadora.GuardarXml(alumno, @$"{pathDirectorio}\alumno.xml");

                Alumno alumnoDeserializado = Serializadora.LeerXml(@$"{pathDirectorio}\alumno.xml");

                Console.WriteLine(alumnoDeserializado);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
