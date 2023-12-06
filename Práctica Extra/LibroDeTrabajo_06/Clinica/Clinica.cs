using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica
{
    public class Clinica
    {
        private List<Servicio> servicios;

        private List<ObraSocial> obrasSociales;

        public Clinica()
        {
            this.servicios = new List<Servicio>();

            this.obrasSociales = new List<ObraSocial>();
        }
    }
}
