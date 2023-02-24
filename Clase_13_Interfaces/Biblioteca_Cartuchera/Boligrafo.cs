using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Cartuchera
{
    public class Boligrafo : IAcciones
    {
        private ConsoleColor colorTinta;

        private float tinta;

        public Boligrafo(int unidades, ConsoleColor color)
        {
            tinta = unidades;
            
            colorTinta = color;
        }

        public ConsoleColor Color 
        {
            get { return colorTinta; }

            set { throw new NotImplementedException(); }
        }

        public float UnidadesDeEscritura
        {
            get { return tinta; }

            set { throw new NotImplementedException(); }
        }

        public EscrituraWrapper Escribir(string texto)
        {
            if (tinta > texto.Length * 0.3F)
            {
                tinta -= texto.Length * 0.3F;

                return new EscrituraWrapper(texto, colorTinta);
            }

            return null;
        }

        public bool Recargar(int unidades)
        {
            tinta += unidades;

            return true;
        }

        public override string ToString()
        {
            return $"Bolígrafo -- Color de escritura: {colorTinta} -- Nivel de tinta: {tinta}";
        }


    }
}
