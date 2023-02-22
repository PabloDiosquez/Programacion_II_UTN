using System;
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

        public string Ficha(Equipo equipo)
        {
            return $"{equipo.nombre} fundado el {equipo.fechaCreacion}";
        }
    }
}
