using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexadores
{
    internal class Personaje
    {

        private int id;

        private string nombre;

        private string poder;

        public Personaje(int id, string nombre, string poder)
        {
            this.id = id;

            this.nombre = nombre;

            this.poder = poder;
        }

        public string Nombre 
        {
            get { return nombre; }
        }

        public string Poder
        {
            get { return poder; }
        }
    }
}
