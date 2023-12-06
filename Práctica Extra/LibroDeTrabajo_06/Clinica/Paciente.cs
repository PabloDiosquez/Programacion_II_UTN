using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica
{
    public class Paciente : Persona
    {
        private string diagnostico;

        private ObraSocial obraSocial;

        private DateTime fechaIngreso;

        // Constructores
        public Paciente(int legajo, string nombre) : base(legajo, nombre)
        {
        }

        public Paciente(Persona persona) : base(persona)
        {
        }

        // Propiedades 
        public string Diagnostico { get => diagnostico; set => diagnostico = value; }
        public ObraSocial ObraSocial { get => obraSocial; set => obraSocial = value; }
        public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }

        // Métodos 

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Diagnóstico: {this.Diagnostico}");
            sb.AppendLine($"Obra Social: {this.ObraSocial}");
            sb.AppendLine($"Fecha ingreso: {this.FechaIngreso}");

            return sb.ToString();
        }
    }
}
