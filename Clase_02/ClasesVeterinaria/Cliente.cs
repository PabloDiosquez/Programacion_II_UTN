using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7
{
    internal class Cliente
    {
        // Atributos 
        private string nombre;

        private string apellido;

        private string domicilio;

        private string telefono;

        private List<Mascota> mascotas;

        // Constructor 👷🏼‍
        public Cliente(string nombre, string apellido, string domicilio, string telefono)
        {
            this.nombre = nombre;

            this.apellido = apellido;   

            this.domicilio = domicilio; 

            this.telefono = telefono;   

            mascotas = new List<Mascota>();
        }

        // Métodos de instancia 

        public void AgregarMascota(Mascota mascota) 
        {
            mascotas.Add(mascota);  
        }

        public bool RemoverMascota(Mascota mascota)
        {
            if (mascotas.Contains(mascota))
            {
                mascotas.Remove(mascota);

                return true;
            }

            return false;
        }

        public string VerMascotas()
        {
            if (mascotas.Count == 0) 
            {
                return "Aún no tiene mascotas";
            }

            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Mascotas:");
            foreach (Mascota mascota in mascotas) 
            {
                sb.AppendLine(mascota.ToString());
            }

            return sb.ToString();   
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("▪▪▪ Datos Cliente ▪▪▪");
            sb.AppendLine($"Nombre y Apellido: {nombre} {apellido}");
            sb.AppendLine($"Domicilio: {domicilio}");
            sb.AppendLine($"Teléfono: {telefono}");

            return sb.ToString();
        }
    }
}
