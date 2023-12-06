using System;
using System.Collections.Generic;

namespace Clinica
{
    public class Servicio
    {
        // Atributos

        private string nombre;

        private Medico jefe;

        private Medico coordinador;

        private List<Medico> medicos;

        private List<Enfermero> enfermeros;

        private Cama[] camas;

        // Constructores

        public Servicio(string nombre, int nroCamas)
        {
            this.nombre = nombre;   

            medicos = new List<Medico>();

            enfermeros = new List<Enfermero>();

            camas = new Cama[nroCamas];
        }

        public Servicio(string nombre, int nroCamas, Medico jefe, Medico coordinador)
            : this(nombre, nroCamas)
        {
            this.jefe = jefe;

            this.coordinador = coordinador;
        }

        public Servicio(Servicio servicio) : this(servicio.nombre, servicio.camas.Length, servicio.jefe, servicio.coordinador)
        {
        }

        // Propiedades 
        public string Nombre { get => nombre; }
        public Medico Jefe { get => jefe; set => jefe = value; }
        public Medico Coordinador { get => coordinador; set => coordinador = value; }
        public List<Medico> Medicos { get => medicos; }
        public List<Enfermero> Enfermeros { get => enfermeros; }
        public Cama[] Camas { get => camas; }

        // Métodos 

        public override string ToString()
        {
            return $"[Nombre: {this.Nombre}, Cantidad de camas: {this.cantidadCamas()}, Jefe: {this.Jefe}, Coordinador: {this.Coordinador}]";
        }

        public int cantidadCamas()
        {
            return this.Camas.Length;
        }
    }
}
