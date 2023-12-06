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

        Paciente paciente;

        public Cama(int nroCama)
        {
            this.nroCama = nroCama;
        }

        // Propiedades 
        public int NroCama { get => nroCama; set => nroCama = value; }


        // Métodos 

        public void AsignarPaciente(Paciente paciente)
        {
            if (paciente is null) throw new ArgumentNullException(nameof(paciente));

            this.paciente = paciente;
        }

        public void RemoverPaciente()
        {
            this.paciente = null;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"[Nro cama: {this.NroCama}]");
            if (this.paciente is not null)
            {
               sb.AppendLine("Datos paciente");
               sb.AppendLine(this.paciente.ToString());
            }
            return sb.ToString();
        }
    }
}
