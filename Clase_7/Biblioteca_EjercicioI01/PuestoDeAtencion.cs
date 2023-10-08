using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Biblioteca_EjercicioI01
{
    /// <summary>
    /// Enumerador que define los posibles puestos de atención.
    /// </summary>
    public enum Puesto
    {
        Caja1,
        Caja2,
    }

    /// <summary>
    /// Clase que representa un puesto de atención en un establecimiento.
    /// </summary>
    public class PuestoDeAtencion
    {
        // Atributos

        private static int numeroActual;
        private Puesto puesto;

        // Constructores

        /// <summary>
        /// Constructor estático que inicializa el número actual en cero.
        /// </summary>
        static PuestoDeAtencion()
        {
            numeroActual = 0;
        }

        /// <summary>
        /// Constructor que crea un puesto de atención con el tipo de puesto especificado.
        /// </summary>
        /// <param name="puesto">El tipo de puesto de atención (Caja1 o Caja2).</param>
        public PuestoDeAtencion(Puesto puesto)
        {
            this.puesto = puesto;
        }

        // Métodos de instancia 

        /// <summary>
        /// Atiende a un cliente en el puesto de atención.
        /// </summary>
        /// <param name="cliente">El cliente que se va a atender.</param>
        /// <returns>Devuelve true si la atención fue exitosa, false en caso contrario.</returns>
        public bool AtenderCliente(Cliente cliente)
        {
            Console.WriteLine("Inicia la atención al cliente.");
            Thread.Sleep(4000); // Simula un proceso de atención que dura 4 segundos.
            Console.WriteLine("Cliente atendido.");
            return true;
        }

        // Propiedades 

        /// <summary>
        /// Obtiene el número actual de atención y lo incrementa en uno.
        /// </summary>
        /// <returns>El número de atención actual.</returns>
        public static int NumeroActual()
        {
            numeroActual++;
            return numeroActual;
        }
    }
}
