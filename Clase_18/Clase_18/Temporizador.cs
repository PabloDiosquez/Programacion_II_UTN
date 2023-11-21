using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static Clase_18.Program;

namespace Clase_18
{
    public static class Temporizador
    {
        public static void EsperarYDisparar(int milisegundos, ObjetoDelegado delegado)
        {
            Thread.Sleep(milisegundos);

            delegado("Disparar...");
        }
    }
}
