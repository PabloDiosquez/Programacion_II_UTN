using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6
{
    internal static class FuncionesAuxiliares
    {
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

        public static Conductor conductorConMayorCantidadDeKMEntre(Conductor conductor1, Conductor conductor2) 
        {
            if (conductor1.TotalKilometrosRecorridos() >= conductor2.TotalKilometrosRecorridos()) 
            {
                return conductor1;
            }
            return conductor2;
        }

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
