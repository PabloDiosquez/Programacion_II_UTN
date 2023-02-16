using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public static class LogicaNegocio
    {
        public static void CargarUsuario(string nombre, int edad)
        {
            if (string.IsNullOrEmpty(nombre))
            {
                throw new ArgumentNullException("Ingreso nombre nulo");
            }

            if (edad < 0)
            {
                throw new Exception("La edad no puede ser negativa.");
            }

            Usuario usuario = new Usuario(nombre, edad);
        }

    }
}
