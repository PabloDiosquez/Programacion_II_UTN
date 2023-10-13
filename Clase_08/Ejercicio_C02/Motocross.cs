using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_C02
{
    public class Motocross : VehiculoDeCarrera
    {
        // Atributos 

        private short cilindrada;

        // Constructores

        public Motocross(short numero, string escuderia):base(numero, escuderia)
        {
            this.numero = numero;

            this.escuderia = escuderia; 
        }

        public Motocross(short numero, string escuderia, short cilindrada) : this(numero, escuderia)
        {
            this.cilindrada = cilindrada;
        }
    }
}
