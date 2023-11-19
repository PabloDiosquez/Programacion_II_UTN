using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public static class JuegoDAO
    {
        // Atributos 

        static string cadenaConexion;

        static SqlConnection conexion;

        static SqlCommand comando;

        // Constructor

        static JuegoDAO()
        {
            cadenaConexion = @"Data Source=.\SQLEXPRESS;Initial Catalog=EJERCICIOS_UTN;Integrated Security=true";

            conexion = new SqlConnection(cadenaConexion);

            comando = new SqlCommand();

            comando.Connection = conexion;
        }
    }
}
