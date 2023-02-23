using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Cartuchera
{
    internal interface IAcciones
    {
        public ConsoleColor Color { get; set; }

        public float UnidadesDeEscritura { get; set; }

        public EscrituraWrapper Escribir(string texto);

        public bool Recargar(int unidades);
    }
}
