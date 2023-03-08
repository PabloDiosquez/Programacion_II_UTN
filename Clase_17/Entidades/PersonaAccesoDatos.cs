using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Entidades
{
    public static class PersonaAccesoDatos
    {
        static string cadenaConexion;

        static SqlCommand comando;

        static SqlConnection conexion;

        static PersonaAccesoDatos()
        {
            cadenaConexion = @"Data Source=.\SQLEXPRESS; Initial Catalog=EMPRESA_DB; Integrated Security=True";

            comando = new SqlCommand();

            conexion = new SqlConnection(cadenaConexion);

            comando.Connection = conexion;

            comando.CommandType = System.Data.CommandType.Text;
        }
    }
}
