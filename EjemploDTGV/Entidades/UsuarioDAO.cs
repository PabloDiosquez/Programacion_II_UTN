using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class UsuarioDAO
    {
        static string cadenaConexion;

        static SqlCommand comando;

        static SqlConnection conexion;

        static UsuarioDAO()
        {
            cadenaConexion = "";

            comando = new SqlCommand();

            conexion = new SqlConnection(cadenaConexion);
        }

    }
}
