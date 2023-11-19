using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    /// <summary>
    /// Clase de acceso a datos para la entidad Juego.
    /// </summary>
    public static class JuegoDAO
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
        /// Inicializa la clase JuegoDAO.
        /// </summary>
        static JuegoDAO()
        {
            cadenaConexion = @"Data Source=.\SQLEXPRESS;Initial Catalog=EJERCICIOS_UTN;Integrated Security=true";

            conexion = new SqlConnection(cadenaConexion);

            comando = new SqlCommand();

            comando.Connection = conexion;
        }

        // Métodos 

        /// <summary>
        /// Guarda un nuevo juego en la base de datos.
        /// </summary>
        /// <param name="juegoNuevo">Instancia del juego a guardar.</param>
        public static void Guardar(Juego juegoNuevo)
        {
            if (juegoNuevo is null) throw new ArgumentNullException(nameof(juegoNuevo));

            try
            {
                if (conexion.State == System.Data.ConnectionState.Closed) conexion.Open();

                comando.Parameters.Clear();
                comando.CommandText = "INSERT INTO JUEGOS (CODIGO_USUARIO, NOMBRE, PRECIO, GENERO) VALUES (@codigoUsuario, @nombre, @precio, @genero);";
                comando.Parameters.AddWithValue("@codigoUsuario", juegoNuevo.CodigoUsuario);
                comando.Parameters.AddWithValue("@nombre", juegoNuevo.Nombre);
                comando.Parameters.AddWithValue("@precio", juegoNuevo.Precio);
                comando.Parameters.AddWithValue("@genero", juegoNuevo.Genero);

                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexion.Close();
            }
        }

        /// <summary>
        /// Lee un juego por su código desde la base de datos.
        /// </summary>
        /// <param name="codigoJuego">Código único del juego a leer.</param>
        /// <returns>Instancia del juego o null si no se encuentra.</returns>
        public static Juego LeerPorId(int codigoJuego)
        {
            try
            {
                if (conexion.State == System.Data.ConnectionState.Closed) conexion.Open();

                comando.CommandText = "SELECT * FROM JUEGOS WHERE CODIGO_JUEGO = @codigo_juego;";

                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@codigo_juego", codigoJuego);

                SqlDataReader lector = comando.ExecuteReader();

                if (lector.Read())
                {
                    return new Juego(
                        lector["NOMBRE"].ToString(),
                        Convert.ToDouble(lector["PRECIO"]),
                        lector["GENERO"].ToString(),
                        Convert.ToInt32(lector["CODIGO_JUEGO"]),
                        Convert.ToInt32(lector["CODIGO_USUARIO"]));
                }
                return null;
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

        /// <summary>
        /// Elimina un juego por su código desde la base de datos.
        /// </summary>
        /// <param name="codigoJuego">Código único del juego a eliminar.</param>
        public static void Eliminar(int codigoJuego)
        {
            try
            {
                if (conexion.State == System.Data.ConnectionState.Closed) conexion.Open();

                comando.Parameters.Clear();
                comando.CommandText = "DELETE FROM JUEGOS WHERE CODIGO_JUEGO = @codigoJuego;";
                comando.Parameters.AddWithValue("@codigoJuego", codigoJuego);

                comando.ExecuteNonQuery();
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

        /// <summary>
        /// Modifica un juego por su código en la base de datos.
        /// </summary>
        /// <param name="codigoJuego">Código único del juego a modificar.</param>
        /// <param name="juegoNuevo">Nueva instancia del juego con los cambios.</param>
        public static void Modificar(int codigoJuego, Juego juegoNuevo)
        {
            if (juegoNuevo == null) throw new ArgumentNullException(nameof(juegoNuevo));

            try
            {
                if (conexion.State == System.Data.ConnectionState.Closed) conexion.Open();

                comando.Parameters.Clear();
                comando.CommandText = "UPDATE JUEGOS SET NOMBRE = @nombreModificado, PRECIO=@precioModificado, GENERO=@generoModificado WHERE CODIGO_JUEGO=@codigoJuego";
                comando.Parameters.AddWithValue("@codigoJuego", codigoJuego);
                comando.Parameters.AddWithValue("@nombreModificado", juegoNuevo.Nombre);
                comando.Parameters.AddWithValue("@precioModificado", juegoNuevo.Precio);
                comando.Parameters.AddWithValue("@generoModificado", juegoNuevo.Genero);

                comando.ExecuteNonQuery();
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

        /// <summary>
        /// Lee la lista de juegos en la biblioteca desde la base de datos.
        /// </summary>
        /// <returns>Lista de objetos Biblioteca.</returns>
        public static List<Biblioteca> Leer()
        {
            List<Biblioteca> biblioteca = new List<Biblioteca>();

            try
            {
                if (conexion.State == System.Data.ConnectionState.Closed) conexion.Open();

                comando.CommandText = "SELECT J.CODIGO_JUEGO, U.USERNAME AS USUARIO, J.NOMBRE AS JUEGO, J.GENERO FROM JUEGOS J INNER JOIN USUARIOS U ON J.CODIGO_USUARIO = U.CODIGO_USUARIO;";

                SqlDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    biblioteca.Add(new Biblioteca(lector["USUARIO"].ToString(), lector["GENERO"].ToString(), lector["JUEGO"].ToString(), Convert.ToInt32(lector["CODIGO_JUEGO"])));
                }
                return biblioteca;
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
