using System;

namespace Biblioteca
{
    public class Juego
    {
        // Atributos 

        private int codigoJuego;

        private int codigoUsuario;

        private string genero;

        private string nombre;

        private double precio;

        // Constructores 

        public Juego(string nombre, double precio, string genero, int codigoJuego, int codigoUsuario) 
            : this(nombre, precio, genero, codigoUsuario) 
        {
            this.codigoJuego = codigoJuego; 
        }

        public Juego(string nombre, double precio, string genero, int codigoUsuario)
        {
            this.nombre = nombre;   

            this.precio = precio;   

            this.genero = genero;   

            this.codigoUsuario = codigoUsuario;
        }

        // Propiedades 

        public int CodigoJuego { get => codigoJuego; }
        public int CodigoUsuario { get => codigoUsuario; }
        public string Genero { get => genero; }
        public string Nombre { get => nombre; }
        public double Precio { get => precio; }
    }
}
