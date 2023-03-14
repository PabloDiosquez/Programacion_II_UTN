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
            cadenaConexion = @"Data Source=.\SQLEXPRESS;Initial Catalog=EJERCICIOS_UTN;Integrated Security=true; Encrypt=False";

            comando = new SqlCommand();

            conexion = new SqlConnection(cadenaConexion);

            comando.Connection = conexion;

            comando.CommandType = System.Data.CommandType.Text; 
        }

        public static List<Usuario> Leer()
        {
            List<Usuario> usuarios = new List<Usuario>();

            try
            {
                conexion.Open();

                comando.CommandText = "SELECT CODIGO_USUARIO, USERNAME FROM USUARIOS;";

                SqlDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    usuarios.Add(new Usuario(lector["USERNAME"].ToString(), Convert.ToInt32(lector["CODIGO_USUARIO"]))
                    {

                    });
                }

                lector.Close();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexion.Close();
            } 

            return usuarios;
        }

    }
}
