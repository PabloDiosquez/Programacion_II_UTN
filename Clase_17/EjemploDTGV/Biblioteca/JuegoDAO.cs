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

        // Métodos 
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
    }
}
