using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6
{
    /// <summary>
    /// Clase que proporciona métodos estáticos para realizar cálculos relacionados con conductores en una empresa de transporte.
    /// </summary>
    internal static class FuncionesAuxiliares
    {
        /// <summary>
        /// Encuentra el conductor con la mayor cantidad total de kilómetros recorridos en todos los días.
        /// </summary>
        /// <param name="empresa">La instancia de la <see cref="EmpresaTransporte"/> de la que se obtendrán los conductores.</param>
        /// <returns>El conductor con la mayor cantidad de kilómetros recorridos en total.</returns>
        /// <exception cref="Exception">Se lanza si la lista de conductores en la empresa está vacía.</exception>
        public static Conductor ConductorConMayorCantidadDeKM(EmpresaTransporte empresa)
        {
            if (empresa.Conductores().Count == 0)
            {
                throw new Exception("Lista de conductores vacía");
            }

            Conductor conductorConMayorKilometraje = empresa.Conductores()[0];

            foreach (Conductor conductor in empresa.Conductores())
            {
                conductorConMayorKilometraje = conductorConMayorCantidadDeKMEntre(conductor, conductorConMayorKilometraje);
            }
            return conductorConMayorKilometraje;
        }

        /// <summary>
        /// Encuentra el conductor con la mayor cantidad de kilómetros recorridos en un día específico.
        /// </summary>
        /// <param name="empresa">La instancia de la <see cref="EmpresaTransporte"/> de la que se obtendrán los conductores.</param>
        /// <param name="dia">El día para el que se buscará el conductor con la mayor cantidad de kilómetros recorridos.</param>
        /// <returns>El conductor con la mayor cantidad de kilómetros recorridos en el día especificado.</returns>
        /// <exception cref="Exception">Se lanza si la lista de conductores en la empresa está vacía.</exception>
        public static Conductor ConductorConMayorCantidadDeKMEnElDia(EmpresaTransporte empresa, string dia)
        {
            if (empresa.Conductores().Count == 0)
            {
                throw new Exception("Lista de conductores vacía");
            }

            Conductor conductorConMayorKilometraje = empresa.Conductores()[0];

            foreach (Conductor conductor in empresa.Conductores())
            {
                conductorConMayorKilometraje = conductorConMayorCantidadDeKMEntreEnDia(conductor, conductorConMayorKilometraje, dia);
            }

            return conductorConMayorKilometraje;
        }

        // <summary>
        /// Compara dos conductores y devuelve el conductor con la mayor cantidad de kilómetros recorridos en total.
        /// </summary>
        /// <param name="conductor1">El primer conductor a comparar.</param>
        /// <param name="conductor2">El segundo conductor a comparar.</param>
        /// <returns>El conductor con la mayor cantidad de kilómetros recorridos en total.</returns>
        public static Conductor conductorConMayorCantidadDeKMEntre(Conductor conductor1, Conductor conductor2) 
        {
            if (conductor1.TotalKilometrosRecorridos() >= conductor2.TotalKilometrosRecorridos()) 
            {
                return conductor1;
            }
            return conductor2;
        }

        /// <summary>
        /// Compara dos conductores y devuelve el conductor con la mayor cantidad de kilómetros recorridos en un día específico.
        /// </summary>
        /// <param name="conductor1">El primer conductor a comparar.</param>
        /// <param name="conductor2">El segundo conductor a comparar.</param>
        /// <param name="dia">El día para el que se compararán los kilómetros recorridos.</param>
        /// <returns>El conductor con la mayor cantidad de kilómetros recorridos en el día especificado.</returns>
        public static Conductor conductorConMayorCantidadDeKMEntreEnDia(Conductor conductor1, Conductor conductor2, string dia) 
        {
            if (conductor1.GetKilometrosRecorridosEnDia(dia) >= conductor2.GetKilometrosRecorridosEnDia(dia)) 
            {
                return conductor1;
            }
            return conductor2;
        }
    }
}
