using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espectaculo
{
    public class Espectador
    {
        // Atributos 

        private int? nroButaca;

        private string nombre;

        private string apellido;

        private int dni;

        // Constructores
        public Espectador(int dni, string nombre, string apellido) 
        {
            this.dni = dni;

            this.nombre = nombre;   

            this.apellido = apellido;

            this.nroButaca = null;
        }

        public Espectador(Espectador espectador)
            : this(espectador.dni, espectador.nombre, espectador.apellido)
        { }

        // Propiedades 

        public int NroButaca { get => (int)nroButaca; set => nroButaca = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Dni { get => dni; set => dni = value; }
    }
}
