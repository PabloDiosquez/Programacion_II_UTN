using System; // namespace
//using Aplicacion_02;
using Mensajes = Aplicacion_02.Mensajes; // Alias
using MensajesBIS = Aplicacion_02BIS.Mensajes;

namespace Aplicacion_01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Mensaje 'desde' App 2 
            Console.WriteLine(Mensajes.MostrarMensaje());

            // Mensaje 'desde' App 2BIS
            Console.WriteLine(MensajesBIS.MostrarMensajeBIS());
        }
    }
}
