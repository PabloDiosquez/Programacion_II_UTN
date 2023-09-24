using System;

namespace Ejercicio_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //De una empresa de transporte de cargas se quiere guardar el nombre de los conductores y los kilómetros que conducen
            //cada día de la semana.
            //Para guardar esta información, la empresa de transporte tendrá un array de conductores.
            //De cada conductor se tendrá la siguiente información:

            //Nombre del conductor.
            //Kilometros recorridos por cada día de la semana. Por ejemplo:
            //Día 1: 200
            //Día 2: 599
            //Día 3: 899
            //Día 4: 0(tiene franco)
            //Día 5: 256
            //Día 6: 0
            //Día 7: 0
            //Consigna
            //Desarrollar las clases y métodos necesarios.Toda la lógica de negocio deberá estar encapsulada en clases y dentro de
            //un proyecto de tipo biblioteca de clases.
            //Crear un proyecto de consola y en el método Main cargar 3 conductores a la empresa de transportes.
            //Luego mostrar:
            //El conductor que hizo más km en esa semana.
            //El conductor que hizo más km el día 3.
            //El conductor que hizo más km el día 5.

            Conductor conductor = new Conductor(123, "Messi", "Lio");

            conductor.CargarKilometrosRecorridosPorDia();

            conductor.MostrarInfoConductor();

        }
    }
}
