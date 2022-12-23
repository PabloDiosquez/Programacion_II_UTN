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
            this.nombre = nombre;

            this.fechaNacimiento = fechaNacimiento;

            this.tipoDePelo = tipoDePelo;

        }

        public void AsignarPeso(double peso)
        {
            this.peso = peso;
        }

        public double ObtenerPeso()
        {
            return this.peso;
        }

        public string ObtenerDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("### Datos del gato ###");
            sb.AppendLine($"Nombre: {nombre}");
            sb.AppendLine($"Fecha de Nacimiento: {fechaNacimiento.ToString("dd/MM/yyyy")}");
            sb.AppendLine($"Peso: {peso}");
            sb.AppendLine($"Tipo de pelo: {tipoDePelo}");

            return sb.ToString();
        }
    }
}
