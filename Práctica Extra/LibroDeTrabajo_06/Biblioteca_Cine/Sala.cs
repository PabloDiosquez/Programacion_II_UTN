using System;
using System.Collections.Generic;

namespace Biblioteca_Cine
{
    public class Sala
    {
        // Atributos 

        private string nombre;

        private short capacidad;

        private Acomodador acomodador;

        private List<Espectador> espectadores;

        // Constructores

        public Sala(string nombre, short capacidad)
        {
            this.nombre = nombre;

            this.capacidad = (short)((capacidad > 0) ? capacidad : -1);

            espectadores = new List<Espectador>();
        }

        public Sala(Sala otraSala) : this(otraSala.Nombre, otraSala.Capacidad)
        {
        }

        // Propiedades 
        public string Nombre { get => nombre; set => nombre = value; }
        public short Capacidad { get => capacidad; }
        public Acomodador Acomodador { get => acomodador; }
        public List<Espectador> Espectadores { get => espectadores; }
        public int CantidadEspectadores { get => this.Espectadores.Count; }

        // Métodos 

        public void AsignarAcomodador(Acomodador acomodador)
        {
            if(acomodador is null) throw new ArgumentNullException(nameof(acomodador)); 

            this.acomodador = acomodador;
        }

        public void cambiarAcomodador(Acomodador nuevoAcomodador)
        {
            if(nuevoAcomodador is null) throw new ArgumentNullException(nameof(nuevoAcomodador));   

            this.acomodador = nuevoAcomodador;
        }

        public bool AgregarEspectador(Espectador espectador)
        {
            if(espectador is null) throw new ArgumentNullException(nameof(espectador));

            if (this.Espectadores.Count <= this.Capacidad)
            {
                this.Espectadores.Add(espectador);

                return true;
            }
            return false;
        }
        public override string ToString()
        {
            return $"[Nombre: {this.Nombre}, Capacidad: {this.Capacidad}]";
        }
    }
}
