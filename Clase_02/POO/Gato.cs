using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria
{
    /// <summary>
    /// Modela un gato. Un gato cuenta con un nombre, una fecha de nacimiento un peso y un tipo de pelo.
    /// </summary>
    internal class Gato
    {
        // Atributos 
        private string nombre;

        private DateTime fechaNacimiento;

        private double peso;

        private string tipoDePelo;

  
        // Constructor 🐱
        public Gato(string nombre, DateTime fechaNacimiento, string tipoDePelo)
        {
            AsignarNombre(nombre);

            this.fechaNacimiento = fechaNacimiento;

            this.tipoDePelo = tipoDePelo;

        }

        /// <summary>
        /// Asigna el nombre a un gato.
        /// En caso de que el nombre dado sea nulo o vacío asigna 'NN'.
        /// </summary>
        /// <param name="nombre">El nombre a asignar</param>
        public void AsignarNombre(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                this.nombre = "NN";
            else
                this.nombre = nombre.Trim();
        }

        /// <summary>
        /// Describe el nombre de un gato.
        /// </summary>
        /// <returns>String</returns>
        public string ObtenerNombre() 
        {
            return nombre;
        }

        /// <summary>
        /// Asigna la fecha de nacimiento de un gato.
        /// </summary>
        /// <param name="fechaNacimiento">DateTime</param>
        public void AsignarFechaNacimiento(DateTime fechaNacimiento)
        {
            this.fechaNacimiento = fechaNacimiento; 
        }

        /// <summary>
        /// Describe la fecha de nacimiento de un gato.
        /// </summary>
        /// <returns>DateTime</returns>
        public DateTime ObtenerFechaNacimiento()
        {
            return fechaNacimiento;
        }

        /// <summary>
        /// Asigna el peso a un gato.
        /// Pre: El peso debe ser >= 0. En caso de no serlo, setea el peso en 0.
        /// </summary>
        /// <param name="peso"></param>
        public void AsignarPeso(double peso)
        {
            if (peso >= 0)
                this.peso = peso;
            else
                this.peso = 0;
        }

        /// <summary>
        /// Describe el peso de un gato.
        /// </summary>
        /// <returns>double</returns>
        public double ObtenerPeso()
        {
            return peso;
        }

        /// <summary>
        /// Asigna el tipo de pelo de un gato.
        /// Pre: El tipo de pelo no debe ser nulo ni vacío. En caso de serlo, setea 'Sin especificar'.
        /// </summary>
        /// <param name="tipoDePelo"></param>
        public void AsignarTipoDePelo(string tipoDePelo)
        {
            if (!string.IsNullOrEmpty(tipoDePelo))
                this.tipoDePelo = tipoDePelo;
            else
                tipoDePelo = "Sin especificar";
        }

        /// <summary>
        /// Describe el tipo de pelo de un gato.
        /// </summary>
        /// <returns>String</returns>
        public string ObtenerTipoDePelo() 
        {
            return tipoDePelo;
        }

        /// <summary>
        /// Describe los datos de un gato.
        /// </summary>
        /// <returns>String</returns>
        public string ObtenerDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("### Datos del gato ###");
            sb.AppendLine($"Nombre: {nombre.ToUpper()}");
            sb.AppendLine($"Fecha de Nacimiento: {fechaNacimiento.ToString("dd/MM/yyyy")}");
            sb.AppendLine($"Peso: {peso}");
            sb.AppendLine($"Tipo de pelo: {tipoDePelo}");
            
            return sb.ToString();
        }
    }
}
