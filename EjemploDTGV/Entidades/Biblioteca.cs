using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Biblioteca
    {
        private int codigoJuego;

        private string genero;

        private string juego;

        private string usuario;

        public Biblioteca(string usuario, string genero, string juego, int codigoJuego)
        {
            this.usuario = usuario;

            this.genero = genero;   

            this.juego = juego; 

            this.codigoJuego = codigoJuego; 
        }

        public int CodigoJuego { get => codigoJuego; }
        public string Genero { get => genero; }
        public string Juego { get => juego; }
        public string Usuario { get => usuario; }
    }
}
