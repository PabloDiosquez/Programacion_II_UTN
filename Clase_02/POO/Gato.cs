using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria
{
    internal class Gato
    {
        private string nombre;

        private DateTime fechaNacimiento;

        private double peso;

        private string tipoDePelo;

        public void AsignarPeso(double peso)
        {
            this.peso = peso;
        }
    }
}
