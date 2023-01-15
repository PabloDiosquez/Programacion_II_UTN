using System;

namespace Entidades
{
    public class Jugador
    {
        private static int ultimoId;

        private int id;

        private string nombre;

        private string posicion;

        private int camiseta;

        private int edad;

        private string nacionalidad;

        public string Nombre
        {
            get { return nombre; }
        }

        public Jugador(string nombre, string posicion, int camiseta, int edad, string nacionalidad)
        {
            this.nombre = nombre;

            this.posicion = posicion;

            this.camiseta = camiseta;

            this.edad = edad;

            this.nacionalidad = nacionalidad;
        }
    }
}
