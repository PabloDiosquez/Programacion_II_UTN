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
            cadenaConexion = @"Data Source=.\SQLEXPRESS;Initial Catalog=EJERCICIOS_UTN;Integrated Security=True";

            comando = new SqlCommand();

            conexion = new SqlConnection(cadenaConexion);

            comando.Connection = conexion;

            comando.CommandType = System.Data.CommandType.Text;
        }

        public static List<Biblioteca> Leer()
        {
            List<Biblioteca> lista = new List<Biblioteca>();

            try
            {
                // Biblioteca(string usuario, string genero, string juego, int codigoJuego)

                conexion.Open();

                comando.CommandText = "SELECT USERNAME, GENERO, NOMBRE, CODIGO_JUEGO FROM USUARIOS AS U INNER JOIN JUEGOS AS J ON U.CODIGO_USUARIO = J.CODIGO_USUARIO;";

                SqlDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    lista.Add(new Biblioteca(lector["USERNAME"].ToString(), lector["GENERO"].ToString(), lector["NOMBRE"].ToString(), Convert.ToInt32(lector["CODIGO_JUEGO"])));
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

            return lista;
        }
    }
}
