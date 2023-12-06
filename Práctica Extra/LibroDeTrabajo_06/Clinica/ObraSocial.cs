using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica
{
    public class ObraSocial
    {
        private string nombre;

        private string cobertura;

        public ObraSocial(string nombre, string cobertura)
        {
            this.nombre = nombre;

            this.cobertura = cobertura;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Cobertura { get => cobertura; set => cobertura = value; }
    }
}
