using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Ejercicio_I01
{
    public static class PersonaDAO
    {
        static string conexionString;

        static SqlConnection conexion;

        static SqlCommand comando;

        static PersonaDAO()
        {
            conexionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=BD_I01;Integrated Security=True";

            conexion = new SqlConnection(conexionString);

            comando = new SqlCommand();

            comando.Connection = conexion;

            comando.CommandType = System.Data.CommandType.Text;
        }

        public static void Guardar(Persona persona)
        {
            try
            {
                conexion.Open();
                comando.Parameters.Clear();
                comando.CommandText = $"INSERT INTO PERSONA (ID, NOMBRE, APELLIDO) VALUES (@id, @nombre, @apellido)";
                comando.Parameters.AddWithValue("@id", persona.Id);
                comando.Parameters.AddWithValue("@nombre", persona.Nombre);
                comando.Parameters.AddWithValue("@apellido", persona.Apellido);

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

        public static Persona LeerPorId(int id)
        {
            try
            {
                conexion.Open();
                comando.Parameters.Clear();
                comando.CommandText = $"SELECT * FROM PERSONA WHERE ID = @ID_PERSONA;";
                comando.Parameters.AddWithValue("@ID_Persona", id);

                SqlDataReader lector = comando.ExecuteReader();

                if (lector.Read())
                {
                    return new Persona(Convert.ToInt32(lector["ID"]), lector["NOMBRE"].ToString(), lector["APELLIDO"].ToString());
                }
                return default(Persona);
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

        public static List<Persona> Leer()
        {
            List<Persona> personas = new List<Persona>();    

            try
            {
                conexion.Open();

                comando.CommandText = "SELECT * FROM PERSONA;";

                SqlDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    personas.Add(new Persona(Convert.ToInt32(lector["ID"]), lector["NOMBRE"].ToString(), lector["APELLIDO"].ToString()));
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally 
            {
                conexion.Close();
            }
            return personas;    
        }

        public static void Modificar(Persona personaAntigua, Persona personaNueva) 
        {
            try
            {
                if (conexion.State == System.Data.ConnectionState.Closed) conexion.Open();

                comando.Parameters.Clear();

                comando.CommandText = "UPDATE PERSONA SET ID=@nuevoId, NOMBRE=@nuevoNombre, APELLIDO=@nuevoApellido WHERE ID=@idAntiguo";
                comando.Parameters.AddWithValue("@nuevoId", personaNueva.Id);
                comando.Parameters.AddWithValue("@nuevoNombre", personaNueva.Nombre);
                comando.Parameters.AddWithValue("@nuevoApellido", personaNueva.Apellido);
                comando.Parameters.AddWithValue("@idAntiguo", personaAntigua.Id);

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
        /// Borra un registro de la tabla PERSONA en la base de datos.
        /// </summary>
        /// <param name="persona">Objeto de tipo Persona que contiene la información del registro a borrar.</param>
        public static void Borrar(Persona persona)
        {
            try
            {
                // Utilizando 'using' para garantizar la liberación de recursos
                using (SqlConnection conexion = new SqlConnection(conexionString))
                {
                    // Abre la conexión
                    conexion.Open();

                    // Utilizando 'using' para garantizar la liberación de recursos
                    using (SqlCommand comando = new SqlCommand("DELETE FROM PERSONA WHERE ID=@id", conexion))
                    {
                        // Establece el valor del parámetro
                        comando.Parameters.AddWithValue("@id", persona.Id);

                        // Ejecuta la consulta
                        comando.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                // Manejar o registrar la excepción específica de SQL
                Console.WriteLine("Error de SQL: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Manejar o registrar otras excepciones
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
