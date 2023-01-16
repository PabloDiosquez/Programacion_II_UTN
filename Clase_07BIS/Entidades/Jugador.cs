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
