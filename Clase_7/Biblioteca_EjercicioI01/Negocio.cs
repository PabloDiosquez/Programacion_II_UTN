using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_EjercicioI01
{
    /// <summary>
    /// Clase que representa un negocio con una cola de clientes y una caja de atención.
    /// </summary>
    public class Negocio
    {
        // Atributos 

        private string nombre;
        private PuestoDeAtencion caja;
        private Queue<Cliente> clientes;

        // Constructor 

        /// <summary>
        /// Constructor privado para crear una instancia de la clase Negocio.
        /// </summary>
        private Negocio()
        {
            clientes = new Queue<Cliente>();
            caja = new PuestoDeAtencion(Puesto.Caja1);
        }

        /// <summary>
        /// Constructor que crea una instancia de la clase Negocio con un nombre especificado.
        /// </summary>
        /// <param name="nombre">El nombre del negocio.</param>
        public Negocio(string nombre):this()
        {
            this.nombre = nombre;
        }

        // Propiedades

        /// <summary>
        /// Obtiene el cliente que está siendo atendido actualmente y lo elimina de la cola de clientes.
        /// </summary>
        public Cliente Cliente
        {
            get { return this.clientes.Dequeue(); }

            set
            {
                if (this != value) this.clientes.Enqueue(value);
            }
        }

        /// <summary>
        /// Obtiene la cantidad de clientes pendientes en la cola.
        /// </summary>
        public int ClientesPendientes
        {
            get { return clientes.Count; }
        }

        // Sobrecarga de operadores 

        /// <summary>
        /// Comprueba si un cliente ya se encuentra en la cola del negocio.
        /// </summary>
        /// <param name="negocio">El negocio en el que se realiza la verificación.</param>
        /// <param name="clienteNuevo">El cliente que se desea verificar.</param>
        /// <returns>True si el cliente no está en la cola, false en caso contrario.</returns>
        public static bool operator ==(Negocio negocio, Cliente clienteNuevo)
        {
            if (negocio.clientes is null) return false;

            foreach (Cliente cliente in negocio.clientes)
            {
                if (cliente == clienteNuevo) return true;
            }
            return false;
        }

        /// <summary>
        /// Comprueba si un cliente ya se encuentra en la cola del negocio.
        /// </summary>
        /// <param name="negocio">El negocio en el que se realiza la verificación.</param>
        /// <param name="cliente">El cliente que se desea verificar.</param>
        /// <returns>True si el cliente está en la cola, false en caso contrario.</returns>
        public static bool operator !=(Negocio negocio, Cliente cliente)
        {
            return !(negocio == cliente);
        }

        /// <summary>
        /// Agrega un cliente a la cola del negocio si no está presente en ella.
        /// </summary>
        /// <param name="negocio">El negocio al que se desea agregar el cliente.</param>
        /// <param name="cliente">El cliente que se desea agregar.</param>
        /// <returns>True si el cliente se agregó a la cola, false si ya estaba presente.</returns>
        public static bool operator +(Negocio negocio, Cliente cliente)
        {
            if (negocio == cliente) return false;

            negocio.clientes.Enqueue(cliente);

            return true;
        }

        /// <summary>
        /// Atiende al próximo cliente en la cola utilizando la caja de atención del negocio.
        /// </summary>
        /// <param name="negocio">El negocio que realiza la atención.</param>
        /// <returns>True si se atendió a un cliente, false si no hay clientes en espera.</returns>
        public static bool operator ~(Negocio negocio)
        {
            if (negocio.clientes.Count > 0)
            {
                Cliente cliente = negocio.clientes.Dequeue();
                negocio.caja.AtenderCliente(cliente);
                return true;
            }
            return false;
        }
    }
}
