using System;

namespace Entidades
{
    public class Usuario
    {
        private int codigoUsuario;

        private string userName;

        public Usuario(string userName, int codigoUsuario)
        {
            this.userName = userName;

            this.codigoUsuario = codigoUsuario;
        }

        public int CodigoUsuario { get; }

        public override string ToString()
        {
            return userName;
        }

    }
}
