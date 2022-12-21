using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_03
{
    internal static class Funciones
    {
        /// <summary>
        /// Este método devuelve el nombre de la App.
        /// </summary>
        /// <returns>Devuelve un string</returns>
        public static string NombreApp() 
        {
            return "App_03";
        }

        /// <summary>
        /// Este método devuelve la cantidad de usuarios de la App, según la versión.
        /// </summary>
        /// <param name="version">version de la App</param>
        /// <returns>Devuelve un int</returns>
        public static int CantidadUsuarios(string version)
        {
            if (version == "0.1A")
                return 100;
            else if (version == "0.1B")
                return 120;

            return 0;
        }
    }
}
