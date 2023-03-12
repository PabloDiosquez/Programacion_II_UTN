using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace Entidades
{
    public static class JuegoDAO
    {
        static string cadenaConexion;

        static SqlCommand comando;

        static SqlConnection conexion;

        static JuegoDAO()
        {
            cadenaConexion = "";

            comando = new SqlCommand();

            conexion = new SqlConnection(cadenaConexion);
        }
    }
}
