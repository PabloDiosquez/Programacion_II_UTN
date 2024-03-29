﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Torneo
{
    public abstract class Equipo
    {
        private string nombre;

        private DateTime fechaCreacion;

        public Equipo(string nombre, DateTime fechaCreacion)
        {
            this.nombre = nombre;

            this.fechaCreacion = fechaCreacion;
        }

        public string Nombre { get { return nombre; } }

        public string Ficha()
        {
            return $"{nombre} fundado el {fechaCreacion.ToString("dd/MM/yyyy")}";
        }

        public static bool operator ==(Equipo equipoA, Equipo equipoB)
        {
            return equipoA.nombre == equipoB.nombre && equipoA.fechaCreacion == equipoB.fechaCreacion;
        }

        public static bool operator !=(Equipo equipoA, Equipo equipoB)
        {
            return !(equipoA == equipoB);
        }
    }
}
