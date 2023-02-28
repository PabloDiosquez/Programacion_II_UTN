﻿using System;
using System.IO;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            verificarSistemaOperativo();

            Console.WriteLine();

            ObtenerInformacionOS();

            ObtenerInformacionAlmacenamiento(); 
        }

        static void verificarSistemaOperativo()
        {
            Console.WriteLine($"¿Es Windows? {OperatingSystem.IsWindows()}");

            Console.WriteLine($"¿Es Linux? {OperatingSystem.IsLinux()}");

            Console.WriteLine($"¿Es MacOS? {OperatingSystem.IsMacOS()}");

            Console.WriteLine($"¿Es IOS? {OperatingSystem.IsIOS()}");

            Console.WriteLine($"¿Es Android? {OperatingSystem.IsAndroid()}");
        }

        static void ObtenerInformacionOS()
        {
            Console.WriteLine($"Sistema Operativo: {Environment.OSVersion}");

            Console.WriteLine($"Plataforma: {Environment.OSVersion.Platform}");

            Console.WriteLine($"Versión: {Environment.OSVersion.Version}");

            Console.WriteLine($"Cantidad de procesadores lógicos: {Environment.ProcessorCount}");

            Console.WriteLine($"Arquitectura de 64 bits?: {Environment.Is64BitProcess}");

            Console.WriteLine($"Nombre de Usuario: {Environment.UserName}");
        }

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
    }
}