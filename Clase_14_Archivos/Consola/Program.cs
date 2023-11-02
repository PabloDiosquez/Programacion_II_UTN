using System;
using System.IO;

namespace Consola
{
    /// <summary>
    /// Clase principal del programa.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Punto de entrada del programa.
        /// </summary>
        /// <param name="args">Argumentos de línea de comandos.</param>
        static void Main(string[] args)
        {
            //verificarSistemaOperativo();

            //Console.WriteLine();

            //ObtenerInformacionOS();

            //ObtenerInformacionAlmacenamiento();

            //CrearDirectorio();

            Archivo.Escribir();

        }

        /// <summary>
        /// Verifica el sistema operativo y muestra información sobre él.
        /// </summary>
        static void verificarSistemaOperativo()
        {
            Console.WriteLine($"¿Es Windows? {OperatingSystem.IsWindows()}");
            Console.WriteLine($"¿Es Linux? {OperatingSystem.IsLinux()}");
            Console.WriteLine($"¿Es MacOS? {OperatingSystem.IsMacOS()}");
            Console.WriteLine($"¿Es IOS? {OperatingSystem.IsIOS()}");
            Console.WriteLine($"¿Es Android? {OperatingSystem.IsAndroid()}");
        }

        /// <summary>
        /// Obtiene información del sistema operativo y la muestra.
        /// </summary>
        static void ObtenerInformacionOS()
        {
            Console.WriteLine($"Sistema Operativo: {Environment.OSVersion}");
            Console.WriteLine($"Plataforma: {Environment.OSVersion.Platform}");
            Console.WriteLine($"Versión: {Environment.OSVersion.Version}");
            Console.WriteLine($"Cantidad de procesadores lógicos: {Environment.ProcessorCount}");
            Console.WriteLine($"Arquitectura de 64 bits?: {Environment.Is64BitProcess}");
            Console.WriteLine($"Nombre de Usuario: {Environment.UserName}");
        }

        /// <summary>
        /// Obtiene información de almacenamiento y la muestra.
        /// </summary>
        static void ObtenerInformacionAlmacenamiento()
        {
            DriveInfo[] volumenes = DriveInfo.GetDrives();

            foreach (DriveInfo unidad in volumenes)
            {
                Console.WriteLine($"{unidad.Name}");
                Console.WriteLine($"{unidad.DriveType}");
                Console.WriteLine($"{unidad.DriveFormat}");
                Console.WriteLine($"{unidad.TotalSize}");
                Console.WriteLine($"{unidad.AvailableFreeSpace}");
            }
        }

        /// <summary>
        /// Crea un directorio en el escritorio del usuario.
        /// </summary>
        static void CrearDirectorio()
        {
            string rutaEscritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string rutaNuevoEscritorio = Path.Combine(rutaEscritorio, "Clase 14 Archivos -- Prueba");

            VerificarSiExisteDirectorio(rutaNuevoEscritorio);

            Directory.CreateDirectory(rutaNuevoEscritorio);

            VerificarSiExisteDirectorio(rutaNuevoEscritorio);
        }

        /// <summary>
        /// Verifica si un directorio existe y muestra el resultado.
        /// </summary>
        /// <param name="rutaEscritorio">La ruta del directorio a verificar.</param>
        static void VerificarSiExisteDirectorio(string rutaEscritorio)
        {
            Console.WriteLine($"¿Existe el directorio? {Directory.Exists(rutaEscritorio)}");
        }
    }
}
