using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Cine
{
    public class Cine
    {
        private int cantidadSalas;

        private string nombre;

        Sala[] salas;

        public Cine(string nombre, int cantidadSalas) 
        {
            this.nombre = nombre;

            this.cantidadSalas = (cantidadSalas > 0) ? cantidadSalas : 0;

            salas = new Sala[this.cantidadSalas];
        }

        public string Nombre { get => this.nombre; set => this.nombre = value; }

        public Sala[] Salas { get => this.salas; }
        public int CantidadSalas { get => cantidadSalas; set => cantidadSalas = value; }

        public int cantidadDeEspectadoresTotales()
        {
            int totalEspectadores = 0;

            foreach (Sala sala in this.Salas) 
            {
                totalEspectadores += sala.CantidadEspectadores;
            }
            return totalEspectadores;
        }

        public override string ToString()
        {
            return $"[Nombre: {this.Nombre}, Nro de salas: {this.CantidadSalas}]";
        }
    }
}
