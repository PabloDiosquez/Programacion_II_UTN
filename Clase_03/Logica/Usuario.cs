using System;

namespace Logica
{
    public class Usuario
    {
        private string nombre;

        private string password;

        public Usuario(string nombre, string password)
        {
            AsignarNombre(nombre);
            AsignarPassword(password);
        }

        public void AsignarNombre(string nombre)
        {
            if (!string.IsNullOrWhiteSpace(nombre))
            {
                this.nombre = nombre;
            }
        }

        public void AsignarPassword(string password) 
        {
            if (!string.IsNullOrWhiteSpace(password))
            {
                this.password = password;
            }
        }

        public string ObtenerNombre() 
        {
            return nombre;
        }

        internal bool CheckPass(string pass)
        {
            return password == pass;
        }
    }
}
