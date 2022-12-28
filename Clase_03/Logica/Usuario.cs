using System;

namespace Logica
{
    public class Usuario
    {
        private string nombre;

        private string password;

        public Usuario(string nombre, string password)
        {
            this.nombre = nombre;
            this.password = password;
        }

        public string ObtenerNombre() 
        {
            return nombre;
        }

        public string ObtenerPassword() 
        {
            return password;
        }

        public bool EsPasswordValido(string password)
        {
            return this.password == password;
        }
    }
}
