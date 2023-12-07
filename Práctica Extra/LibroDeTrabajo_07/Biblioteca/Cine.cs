using System;

namespace Biblioteca
{
    public class Cine
    {
        // Atributos 

        private string nombre;

        private Butaca[] butacas;

        private int nroButacas;

        // Constructor 

        public Cine(string nombre, int nroButacas)
        {
            this.nombre = (!string.IsNullOrEmpty(nombre)) ? nombre : "###############";

            this.nroButacas = (nroButacas > 0) ? nroButacas : 0;

            this.butacas = new Butaca[nroButacas];
        }

        // Propiedades 
        public string Nombre { get => nombre; set => nombre = value; }
        public Butaca[] Butacas { get => butacas; set => butacas = value; }
        public int NroButacas { get => nroButacas; set => nroButacas = value; }
    }
}
