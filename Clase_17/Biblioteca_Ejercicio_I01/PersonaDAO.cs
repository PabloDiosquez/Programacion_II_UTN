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
                comando.CommandText = $"INSERT INTO PERSONA (ID, NOMBRE, APELLIDO) VALUES (@ID, @NOMBRE, @APELLIDO)')";
                comando.Parameters.AddWithValue("@ID", persona.Id);
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
            List<Persona> personas = default(List<Persona>);    

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

        public static void Modificar(Persona personaA, Persona personaB) 
        {
            try
            {
                conexion.Open();
                comando.Parameters.Clear();
                comando.CommandText = "UPDATE PERSONA SET ID=@id, NOMBRE=@nombre, APELLIDO=@apellido WHERE ID=@idViejo";
                comando.Parameters.AddWithValue("@id", personaB.Id);
                comando.Parameters.AddWithValue("@nombre", personaB.Nombre);
                comando.Parameters.AddWithValue("@apellido", personaB.Apellido);
                comando.Parameters.AddWithValue("@idViejo", personaA.Id);

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
