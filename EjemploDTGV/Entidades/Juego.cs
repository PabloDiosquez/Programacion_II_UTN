﻿using System;
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

        private double precio;

        public Juego(string nombre, double precio, string genero, int codigoJuego, int codigoUsuario)
        {
            this.nombre = nombre;

            this.precio = precio;   

            this.genero = genero;   

            this.codigoJuego = codigoJuego;

            this.codigoUsuario = codigoUsuario;
        }

        public Juego(string nombre, double precio, string genero, int codigoUsuario) : this(nombre, precio, genero, 0, codigoUsuario)
        {
            
        }


        public int CodigoJuego { get; }

        public int CodigoUsuario { get; }

        public string Genero { get; }

        public string Nombre { get; }   

        public double Precio { get; }

    }
}