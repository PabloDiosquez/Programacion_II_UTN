using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_I01_Program
{
    public class MiClase
    {
        // Constructores de instancia

        public MiClase() 
        {
            try
            {
               LanzarDivideByZeroException();
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error en MiClase constructor (instancia 1).", ex);

                throw new UnaExcepcion($"Error en MiClase constructor (stage 1)", ex);
            }
        }

        public MiClase(bool segundaInstancia)
        {
            try
            {
                MiClase otraMiClase = new MiClase();
            }
            catch (UnaExcepcion ex)
            {
                Console.WriteLine("Error en MiClase constructor (instancia 2).", ex);

                throw new UnaExcepcion(ex.Message);
            }
        }

        // Método estático que sólo lanza una excepción
        public static void LanzarDivideByZeroException()
        {
            throw new DivideByZeroException("¡División por cero en un método estático!");
        }
    }
}
