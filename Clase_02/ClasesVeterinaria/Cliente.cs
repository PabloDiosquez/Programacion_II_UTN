using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7
{
    /// <summary>
    /// Representa a un cliente de la veterinaria.
    /// </summary>
    public class Cliente
    {
        // Atributos 
        private string nombre;
        private string apellido;
        private string domicilio;
        private string telefono;
        private List<Mascota> mascotas;

        /// <summary>
        /// Constructor para crear un nuevo cliente de la veterinaria.
        /// </summary>
        /// <param name="nombre">El nombre del cliente.</param>
        /// <param name="apellido">El apellido del cliente.</param>
        /// <param name="domicilio">La dirección del cliente.</param>
        /// <param name="telefono">El número de teléfono del cliente.</param>
        public Cliente(string nombre, string apellido, string domicilio, string telefono)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.domicilio = domicilio;
            this.telefono = telefono;
            mascotas = new List<Mascota>();
        }

        /// <summary>
        /// Agrega una nueva mascota a la lista de mascotas del cliente.
        /// </summary>
        /// <param name="mascota">La mascota que se va a agregar.</param>
        public void AgregarMascota(Mascota mascota)
        {
            mascotas.Add(mascota);
        }

        /// <summary>
        /// Remueve una mascota de la lista de mascotas del cliente.
        /// </summary>
        /// <param name="mascota">La mascota que se va a remover.</param>
        /// <returns>True si la mascota se removió con éxito, false si la mascota no pertenece a la lista.</returns>
        public bool RemoverMascota(Mascota mascota)
        {
            if (mascotas.Contains(mascota))
            {
                mascotas.Remove(mascota);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Obtiene una descripción de todas las mascotas del cliente.
        /// </summary>
        /// <returns>Una cadena de texto que describe las mascotas del cliente.</returns>
        public string VerMascotas()
        {
            if (mascotas.Count == 0)
            {
                return "El cliente no tiene mascotas.";
            }

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Mascotas:");
            foreach (Mascota mascota in mascotas)
            {
                sb.AppendLine(mascota.ToString());
            }
            return sb.ToString();
        }

        /// <summary>
        /// Obtiene una descripción detallada de los datos del cliente.
        /// </summary>
        /// <returns>Una cadena de texto que describe los datos del cliente.</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("▪▪▪ Datos del Cliente ▪▪▪");
            sb.AppendLine($"Nombre y Apellido: {nombre} {apellido}");
            sb.AppendLine($"Domicilio: {domicilio}");
            sb.AppendLine($"Teléfono: {telefono}");
            return sb.ToString();
        }
    }
}
