using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public static class Sistema
    {
        static Usuario[] usuariosRegistrados;

        static Sistema() // Constructor STATIC de Sistema
        {
            usuariosRegistrados = new Usuario[3];
            CargarUsuarios();
        }

        private static void CargarUsuarios() 
        {
            usuariosRegistrados[0] = new Usuario("Lio", "ABC123");
            usuariosRegistrados[1] = new Usuario("Romeo", "ABC456");
            usuariosRegistrados[2] = new Usuario("María", "XYZ321");
        }

        public static bool AgregarNuevoUsuario(string nombre, string pass)
        {
            for (int i = 0; i < usuariosRegistrados.Length; i++) 
            {
                if (usuariosRegistrados[i] is null)
                {
                    usuariosRegistrados[i] = new Usuario(nombre, pass);

                    return true;
                }
            }

            return false;
        }

        public static bool ChekearUsuario(string nombre, string pass)
        {
            if (!string.IsNullOrWhiteSpace(nombre) || !string.IsNullOrWhiteSpace(pass)) 
            {
                for (int i = 0; i < usuariosRegistrados.Length; i++)
                {
                    if (usuariosRegistrados[i].ObtenerNombre().Trim().ToUpper() == nombre.Trim().ToUpper())
                    {
                        return usuariosRegistrados[i].CheckPass(pass);
                    }
                }

            }
            return false;

        }
    }
}
