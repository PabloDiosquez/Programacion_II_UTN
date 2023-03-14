using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Juego
    {
        private int codigoJuego;

        private int codigoUsuario;

        private string genero;

        private string nombre;

        private float precio;

        public Juego(string nombre, float precio, string genero, int codigoJuego, int codigoUsuario) 
            : this(nombre, precio, genero, codigoUsuario)
        {
            this.CodigoJuego = codigoJuego;   
        }

        public Juego(string nombre, float precio, string genero, int codigoUsuario)
        {
            this.nombre = nombre;

            this.precio = precio;

            this.genero = genero;

            this.codigoUsuario = codigoUsuario;
        }


        public int CodigoJuego { get; }

        public int CodigoUsuario { get; }

        public string Genero { get; }

        public string Nombre { get; }   

        public double Precio { get; }

    }
}
