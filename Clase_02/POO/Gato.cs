using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria
{
    internal class Gato
    {
        private string nombre;

        private DateTime fechaNacimiento;

        private double peso;

        private string tipoDePelo;

  
        public Gato(string nombre, DateTime fechaNacimiento, string tipoDePelo)
        {
            AsignarNombre(nombre);

            this.fechaNacimiento = fechaNacimiento;

            this.tipoDePelo = tipoDePelo;

        }

        public void AsignarNombre(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                this.nombre = "NN";
            else
                this.nombre = nombre;
        }

        public string ObtenerNombre() 
        {
            return nombre;
        }

        public void AsignarPeso(double peso)
        {
            this.peso = peso;
        }

        public double ObtenerPeso()
        {
            return peso;
        }

        public string ObtenerDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("### Datos del gato ###");

            sb.AppendLine($"Nombre: {nombre.ToUpper()}");
            sb.AppendLine($"Fecha de Nacimiento: {fechaNacimiento.ToString("dd/MM/yyyy")}");
            sb.AppendLine($"Peso: {peso}");
            if (tipoDePelo is not null)
                sb.AppendLine($"Tipo de pelo: {tipoDePelo}");
            else
                sb.AppendLine($"Tipo de pelo: sin especificar");

            return sb.ToString();
        }
    }
}
