using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Cartuchera
{
    internal class Lapiz : IAcciones
    {
        private float tamanioMina;

        public Lapiz(int unidades)
        {
            tamanioMina = unidades;
        }

        public ConsoleColor Color
        {
            get { return ConsoleColor.Gray; }

            set { throw new NotImplementedException(); }
        }

        public float UnidadesDeEscritura
        {
            get { return tamanioMina; }
        }

        public void Escribir(string texto)
        {
            foreach (char caracter in texto)
            {
                tamanioMina -= 0.1F;
            }
        }

        public bool Recargar(int unidadess)
        {
            throw new NotSupportedException();
        }
    }
}
