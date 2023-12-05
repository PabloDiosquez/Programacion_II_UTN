using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Cine
{
    public class Cine
    {
        private string nombre;

        List<Sala> salas;

        public Cine(string nombre) 
        {
            this.nombre = nombre;

            salas = new List<Sala>();
        }

        public string Nombre { get => this.nombre; set => this.nombre = value; }

        public List<Sala> Salas { get => this.salas; }

        public override string ToString()
        {
            return $"[Nombre: {this.Nombre}, Nro de salas: {this.Salas.Count}]";
        }
    }
}
