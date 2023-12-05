using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espectaculo
{
    public class ObraDeTeatro : Espectaculo
    {
        // Atributos

        private string nombre;

        Butaca[] butacas;

        // Constructores

        public ObraDeTeatro(string nombre, int cantidadButacas) 
            : base(cantidadButacas)
        {
            this.nombre = nombre;

            this.butacas = new Butaca[this.CantidadButacas];
        }

        public ObraDeTeatro(ObraDeTeatro obra)
            : this(obra.nombre, obra.CantidadButacas)
        {
        }

        // Propiedades 
        public string Nombre { get => nombre; set => nombre = value; }

        // Métodos de instancia

        public bool VenderEntrada(Espectador espectador, double precio) 
        {
            
            if (espectador == null) throw new ArgumentNullException(nameof(espectador));

            int nroButacaLibre = Array.FindIndex(this.butacas, butaca => butaca is null);

            if (nroButacaLibre == -1)
            {
                Console.WriteLine("Todas las butacas están ocupadas.");

                return false;
            }

            this.butacas[nroButacaLibre] = new Butaca(nroButacaLibre, precio);

            espectador.NroButaca = nroButacaLibre;

            return true;
        }

        public int cantidadDeEspectadores()
        {
            return this.butacas.Length - this.butacas.Count(butaca => butaca is null);
        }

        public double totalRecaudado()
        {
            if (this.butacas.Length == 0) return 0;

            double totalRecaudado = 0;

            foreach (Butaca butaca in this.butacas)
            {
                if (butaca is not null)
                {
                    totalRecaudado += butaca.Precio;
                }
            }
            return totalRecaudado;
        }

    }
}
