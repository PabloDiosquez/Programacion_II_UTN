using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public static class UsuarioDAO
    {
        // Atributos 

        static string cadenaConexion;

        static SqlConnection conexion;

        static SqlCommand comando;

        // Constructor 

        static UsuarioDAO()
        {
            cadenaConexion = @"Data Source=.\SQLEXPRESS;Initial Catalog=EJERCICIOS_UTN;Integrated Security=true";

            conexion = new SqlConnection(cadenaConexion);

            comando = new SqlCommand();

            comando.Connection = conexion;
        }

        public static List<Usuario> Leer() 
        {
            List<Usuario> usuarios = new List<Usuario>();

            try
            {
                if (conexion.State == System.Data.ConnectionState.Closed) conexion.Open();

                comando.CommandText = "SELECT USERNAME AS NOMBRE, CODIGO_USUARIO FROM USUARIOS;";

                SqlDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    usuarios.Add(new Usuario(lector["NOMBRE"].ToString(), Convert.ToInt32(lector["CODIGO_USUARIO"])));
                }
                return usuarios;
            }
            catch (Exception)
            {
                throw;
            }
            finally 
            {
                if (conexion.State == System.Data.ConnectionState.Open) conexion.Close();
            }
        }
    }
}
