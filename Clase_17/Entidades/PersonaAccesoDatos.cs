using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Entidades
{
    /// <summary>
    /// Clase estática que proporciona métodos para el acceso a datos de la entidad Persona en la base de datos.
    /// </summary>
    public static class PersonaAccesoDatos
    {
        static string cadenaConexion;
        static SqlCommand comando;
        static SqlConnection conexion;

        /// <summary>
        /// Inicializa la clase <see cref="PersonaAccesoDatos"/> con la cadena de conexión predeterminada.
        /// </summary>
        static PersonaAccesoDatos()
        {
            cadenaConexion = @"Data Source=.\SQLEXPRESS; Initial Catalog=EMPRESA_DB; Integrated Security=True";

            comando = new SqlCommand();
            conexion = new SqlConnection(cadenaConexion);

            comando.Connection = conexion;
            comando.CommandType = System.Data.CommandType.Text;
        }

        /// <summary>
        /// Lee los datos de la base de datos para una persona específica según su identificador.
        /// </summary>
        /// <param name="id">El identificador único de la persona.</param>
        /// <returns>Un objeto Persona con los datos de la persona encontrada o el valor predeterminado de Persona si no se encuentra ninguna coincidencia.</returns>
        public static Persona Leer(int id)
        {
            try
            {
                conexion.Open();

                comando.CommandText = $"SELECT * FROM EMPLEADOS WHERE ID_EMPLEADO = {id};";

                Persona persona = default(Persona);

                using (SqlDataReader lector = comando.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        if (Convert.ToInt32(lector["ID_EMPLEADO"]) == id)
                        {
                            // Se encontró una persona con el ID especificado, se crea un objeto Persona.
                            persona = new Persona(lector["NOMBRE"].ToString(), lector["APELLIDO"].ToString());
                        }
                    }
                }

                return persona;
            }
            catch (Exception)
            {
                // Se propaga la excepción para su manejo en capas superiores.
                throw;
            }
            finally
            {
                // Se cierra la conexión después de realizar las operaciones necesarias.
                conexion?.Close();
            }
        }

        /// <summary>
        /// Obtiene una lista de empleados almacenados en la base de datos.
        /// </summary>
        /// <returns>Una lista de objetos Persona.</returns>
        public static List<Persona> Leer()
        {
            List<Persona> personas = new List<Persona>();

            try
            {
                conexion.Open();

                comando.CommandText = "SELECT * FROM EMPLEADOS";

                SqlDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    personas.Add(new Persona(lector["NOMBRE"].ToString(), lector["APELLIDO"].ToString()));
                }

                return personas;
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
        /// Elimina una persona de la base de datos según su identificador.
        /// </summary>
        /// <param name="id">El identificador de la persona a eliminar.</param>
        public static void Eliminar(int id)
        {
            try
            {
                comando.Parameters.Clear(); // Al trabajar con miembros estáticos, se deben limpiar los parámetros.

                conexion.Open();

                comando.CommandText = $"DELETE FROM EMPLEADOS WHERE ID = @id";

                comando.Parameters.AddWithValue("@id", id);

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
        /// Guarda una nueva persona en la base de datos.
        /// </summary>
        /// <param name="persona">La persona a guardar.</param>
        public static void Guardar(Persona persona)
        {
            try
            {
                comando.Parameters.Clear();

                conexion.Open();

                comando.CommandText = $"INSERT INTO EMPLEADOS (NOMBRE, APELLIDO) VALUES (@NOMBRE, @APELLIDO)";

                comando.Parameters.AddWithValue("@NOMBRE", persona.Nombre);
                comando.Parameters.AddWithValue("@APELLIDO", persona.Apellido);

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
    }
}
