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

        static PersonaAccesoDatos()
        {
            cadenaConexion = @"Data Source=.\SQLEXPRESS; Initial Catalog=EMPRESA_DB; Integrated Security=True";

            comando = new SqlCommand();

            conexion = new SqlConnection(cadenaConexion);

            comando.Connection = conexion;

            comando.CommandType = System.Data.CommandType.Text;
        }

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

        public static void Eliminar(int id)
        {
            try
            {
                conexion.Open();

                comando.CommandText = $"DELETE FROM EMPLEADOS WHERE ID = @id";

                comando.Parameters.AddWithValue("@id",id);

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
