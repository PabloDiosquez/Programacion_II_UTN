using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public static class LogicaNegocio
    {

        static LogicaNegocio()
        {
            List<Usuario> usuarios = new List<Usuario>();
        }
        public static string CargarUsuario(string nombre, int edad)
        {
            try
            {
                if (string.IsNullOrEmpty(nombre))
                {
                    throw new ArgumentNullException("Ingreso nombre nulo o vacío");
                }

                if (edad < 0)
                {
                    throw new Exception($"La edad no puede ser negativa. El Form recibió {edad}");
                }

                Usuario usuario = new Usuario(nombre, edad);

                return usuario.ToString();

            }
            catch (Exception ex)
            {

                throw new Exception("Verificar la información", ex);
            }
        }

    }
}
