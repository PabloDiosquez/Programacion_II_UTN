using System;
using System.Collections.Generic;
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

                Alumno alumno1 = new Alumno()
                {
                    NombreCompleto = "Cristiano Ronaldo",
                    Legajo = 654321,
                    Edad = 36
                };

                Alumno alumno3 = new Alumno()
                {
                    NombreCompleto = "Andrés Iniesta",
                    Legajo = 777777,
                    Edad = 37
                };

                Alumno alumno4 = new Alumno()
                {
                    NombreCompleto = "Luis Suárez",
                    Legajo = 888888,
                    Edad = 35
                };

                //Serializadora<Alumno>.GuardarXml(alumno, @$"{pathDirectorio}\alumnos.xml");

                List<Alumno> alumnos = new List<Alumno>() { alumno1, alumno3, alumno4 };

                Serializadora<List<Alumno>>.GuardarXml(alumnos, @$"{pathDirectorio}\alumnos.xml");

                List<Alumno> alumnosDeserializados = Serializadora<List<Alumno>>.LeerXml(@$"{pathDirectorio}\alumnos.xml");

                Console.WriteLine(alumnoDeserializado);

                foreach (Alumno alumnoDeserializado in alumnosDeserializados)
                {
                    Console.WriteLine(alumnoDeserializado);
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
