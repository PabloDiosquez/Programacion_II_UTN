using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6
{
    /// <summary>
    /// Clase que representa una empresa de transporte.
    /// </summary>
    internal class EmpresaTransporte
    {
        // Atributos

        /// <summary>
        /// Nombre de la empresa de transporte.
        /// </summary>
        private string nombreEmpresa;

        /// <summary>
        /// Lista de conductores asociados a la empresa.
        /// </summary>
        private List<Conductor> conductores;

        // Constructor

        /// <summary>
        /// Constructor de la clase <see cref="EmpresaTransporte"/>. Inicializa una nueva instancia de la empresa de transporte.
        /// </summary>
        public EmpresaTransporte()
        {
            conductores = new List<Conductor>();
        }

        /// <summary>
        /// Describe la lista de conductores de una empresa.
        /// </summary>
        /// <returns>Lista de conductores</returns>
        public List<Conductor> Conductores() 
        {
            return conductores;
        }

        // Métodos de instancia 

        /// <summary>
        /// Agrega un conductor a la lista de conductores de la empresa.
        /// </summary>
        /// <param name="conductor">El objeto de tipo <see cref="Conductor"/> que se agregará a la empresa.</param>
        public void AgregarConductor(Conductor conductor)
        {
            conductores.Add(conductor);
        }

        /// <summary>
        /// Remueve un conductor de la lista de conductores de la empresa.
        /// </summary>
        /// <param name="conductor">El objeto de tipo <see cref="Conductor"/> que se removerá de la empresa.</param>
        /// <returns>
        /// <c>true</c> si se removió exitosamente el conductor de la empresa; de lo contrario, <c>false</c>.
        /// </returns>
        public bool RemoverConductor(Conductor conductor)
        {
            if (conductores.Contains(conductor))
            {
                conductores.Remove(conductor);
                return true;
            }

            return false;
        }
    }
}
