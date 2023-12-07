using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Espectador
    {
        // Atributos 

        private string nombre;

        private string apellido;

        private int dni;

        private int nroEntrada;

        // Constructores 

        public Espectador(int dni, string nombre, string apellido)
        {
            this.dni = dni;

            this.nombre = nombre;

            this.apellido = apellido;
        }

        public Espectador(int dni, string nombre, string apellido, int nroEntrada) : this(dni, nombre, apellido)
        {
            this.nroEntrada = nroEntrada;
        }

        public Espectador(Espectador espectador) : this(espectador.dni, espectador.nombre, espectador.apellido)
        {
            this.nroEntrada=espectador.nroEntrada;
        }

        // Propiedades 

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Dni { get => dni; set => dni = value; }
        public int NroEntrada { get => nroEntrada; set => nroEntrada = value; }
    }
}
