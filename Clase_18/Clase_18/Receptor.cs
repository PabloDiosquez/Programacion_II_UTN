using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_18
{
    public class Receptor
    {
        private string nombre;

        public Receptor(string nombre)
        {
            this.nombre = nombre;
        }

        public string Nombre { get { return nombre; } }

        public void RecibirNotificacion()
        {
            Console.WriteLine($"{this.Nombre} - Recibí una notificación: {DateTime.Now:T}");
        }
    }
}
