using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica
{
    public class Cama
    {
        // Atributos 

        private int nroCama;

        private string nombrePaciente;

        private string diagnostico;

        private ObraSocial obraSocial;

        private DateTime fechaIngreso;

        public Cama(int nroCama)
        {
            this.nroCama = nroCama;
        }

        // Propiedades 
        public int NroCama { get => nroCama; set => nroCama = value; }
        public string NombrePaciente { get => nombrePaciente; set => nombrePaciente = value; }
        public string Diagnostico { get => diagnostico; set => diagnostico = value; }
        public ObraSocial ObraSocial { get => obraSocial; set => obraSocial = value; }
        public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }

        // Métodos 

        public override string ToString()
        {
            return $"[Nro de cama: {this.NroCama}]";
        }
    }
}
