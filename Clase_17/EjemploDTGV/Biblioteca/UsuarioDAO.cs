using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    /// <summary>
    /// Clase de acceso a datos para la entidad Usuario.
    /// </summary>
    public static class UsuarioDAO
    {
        // Atributos 

        /// <summary>
        /// Cadena de conexión para la base de datos.
        /// </summary>
        private static string cadenaConexion;

        /// <summary>
        /// Objeto de conexión a la base de datos.
        /// </summary>
        private static SqlConnection conexion;

        /// <summary>
        /// Objeto de comando para ejecutar consultas en la base de datos.
        /// </summary>
        private static SqlCommand comando;

        // Constructor 

        /// <summary>
        /// Inicializa la clase UsuarioDAO.
        /// </summary>
        static UsuarioDAO()
        {
            cadenaConexion = @"Data Source=.\SQLEXPRESS;Initial Catalog=EJERCICIOS_UTN;Integrated Security=true";

            conexion = new SqlConnection(cadenaConexion);

            comando = new SqlCommand();

            comando.Connection = conexion;
        }

        /// <summary>
        /// Lee la lista de usuarios desde la base de datos.
        /// </summary>
        /// <returns>Lista de objetos Usuario.</returns>
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
