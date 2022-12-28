using System;
using Logica;

namespace Vista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (Sistema.ChekearUsuario("Lio", "ABC123"))
            {
                Console.WriteLine("Usuario logueado");
            }
            else 
            {
                Console.WriteLine("");
            }

        }
    }
}
