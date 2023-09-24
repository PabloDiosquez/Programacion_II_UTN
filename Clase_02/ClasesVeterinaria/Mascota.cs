using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7
{
    internal class Mascota
    {
        // Atributos 

        private string nombre;

        private string especie;

        private DateTime fechaNacimiento;

        private List<String> vacunas;

        // Constructor 🐕‍🦺

        public Mascota(string nombre, string especie, DateTime fechaNacimiento) 
        {
            this.nombre = nombre;

            this.especie = especie;

            this.fechaNacimiento = fechaNacimiento;

            vacunas = new List<string>();
        }

        // Métodos de instancia 

        public string Nombre()
        {
            return nombre;
        }

        public string Especie() 
        {
            return especie;
        }

        public string FechaDeNacimiento() 
        {
            return fechaNacimiento.ToString("dd/mm/yyyy");  
        }

        public bool AgregarVacuna(string vacuna)
        {
            if (!string.IsNullOrEmpty(vacuna)) 
            {
                vacunas.Add(vacuna);

                return true;
            }

            return false;
        }

        public bool tieneVacuna(string vacuna) 
        {
            return vacunas.Contains(vacuna);
        }

        public string VerVacunas()
        {
            if (vacunas.Count == 0) 
            {
                return "Aún no tiene vacunas";
            }

            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Vacunas:");

            foreach (string vacuna in vacunas) 
            {
                sb.AppendLine($" ** {vacuna} **");
            }

            return sb.ToString();
        }

        public string MostrarDatos() 
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($" ** Datos Mascota **");
            sb.AppendLine($"Nombre: {Nombre()}");
            sb.AppendLine($"Especie: {Especie()}");
            sb.AppendLine($"Fecha de nacimiento: {FechaDeNacimiento()}");

            return sb.ToString();
        }

        public override string ToString()
        {
            return $"{Nombre()}";
        }

    }
}
