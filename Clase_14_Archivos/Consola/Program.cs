﻿using System;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            verificarSistemaOperativo();

            Console.WriteLine();

            ObtenerInformacionOS();
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
        }
    }
}
