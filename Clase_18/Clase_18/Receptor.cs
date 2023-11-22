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

        public void RecibirNotificacion()
        {
            Console.WriteLine($"Recibí una notificación: {DateTime.Now:T}");
        }
    }
}
