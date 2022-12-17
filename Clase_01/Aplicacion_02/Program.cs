using System;

namespace Aplicacion_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public static class Mensajes
    {
        public static string MostrarMensaje() 
        {
            return "Mensaje desde la App 2";
        }
    }
}

namespace Aplicacion_02BIS
{
    public static class Mensajes
    {
        public static string MostrarMensajeBIS()
        {
            return "Mensaje desde la App 2 BIS";
        }
    }
}
