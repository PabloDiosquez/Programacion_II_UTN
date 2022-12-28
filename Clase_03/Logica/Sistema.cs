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

        public static bool ChekearUsuario(Usuario usuario)
        {
            if (usuario is not null) 
            {
                for (int i = 0; i < usuariosRegistrados.Length; i++)
                {
                    if (usuariosRegistrados[i].ObtenerNombre() == usuario.ObtenerNombre())
                    {
                        return true;
                    }
                    else 
                    {
                        return false;
                    }
                } 
            }
            return false;
        }
    }
}
