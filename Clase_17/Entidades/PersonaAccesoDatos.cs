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
    }
}
