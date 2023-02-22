using System;

namespace Biblioteca
{
    public class MiClase : IMiInterfaz
    {
        public int Propiedad { get { return 0; } }

        public string Saludar()
        {
            return "Saludando...";
        }
    }
}
