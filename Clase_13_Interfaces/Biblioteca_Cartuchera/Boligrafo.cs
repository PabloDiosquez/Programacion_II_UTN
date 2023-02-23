using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Cartuchera
{
    internal class Boligrafo : IAcciones
        {
//        El método Escribir reducirá la tinta en 0.3 por cada carácter escrito.
//El método Recargar incrementará la tinta en tantas unidades como se agreguen.
//La propiedad UnidadesDeEscritura retornará el valor del atributo tinta.


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

        
    }
}
