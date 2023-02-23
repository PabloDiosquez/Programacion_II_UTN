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

        public ConsoleColor Color { get => ConsoleColor.Gray; set => throw new NotImplementedException(); }
        public float UnidadesDeEscritura { get => tamanioMina; set => throw new NotImplementedException(); }

        public EscrituraWrapper Escribir(string texto)
        {
            if (tamanioMina >= texto.Length * 0.1F)
            {
                tamanioMina -= texto.Length * 0.1F;

                return new EscrituraWrapper(texto, ((IAcciones)this).Color);
            }

            return null;

        }

        public bool Recargar(int unidades)
        {
            throw new NotImplementedException();
        }
    }
}
