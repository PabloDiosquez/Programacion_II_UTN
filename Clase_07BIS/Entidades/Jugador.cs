using System;

namespace Entidades
{
    // ENUMERADOS

    public enum EPosicion
    {
        Arquero = 1,

        Defensor = 2,

        Mediocampista = 3,

        Delantero = 4,
    }


    public class Jugador
    {
        private static int ultimoId;

        private int id;

        private string nombre;

        private EPosicion posicion;

        private int camiseta;

        private int edad;

        private string nacionalidad;

        private bool estaLesionado;

        private bool estaSuspendido;

        // PROPIEDADES 👉🏼 Definen ESTADOS del objeto
        public string Nombre
        {
            get { return nombre; }

            //set 
            //{
            //    if (!string.IsNullOrEmpty(value))
            //    {
            //        nombre = value;
            //    }
            //    else 
            //    {
            //        nombre = "NN";
            //    }
            //}
        }

        public string EstadoJugador 
        {
            get
            {
                if (estaLesionado)
                {
                    return "Está lesionado";
                }
                else if (estaSuspendido)
                {
                    return "Está suspendido";
                }
                else 
                {
                    return "Apto para jugar";
                }
            }

        }

        public bool EstaLesionado
        {
            set { estaLesionado = value; }
        }

        public bool EstaSuspendido 
        {
            set { estaSuspendido = value; }
        }

        public Jugador(string nombre, EPosicion posicion, int camiseta, int edad, string nacionalidad)
        {
            id = ultimoId;

            this.nombre = nombre;

            this.posicion = posicion;

            this.camiseta = camiseta;

            this.edad = edad;

            this.nacionalidad = nacionalidad;

            ultimoId++;
        }

        static Jugador()
        {
            ultimoId = 1;
        }
    }
}
