﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Aduana
{
    public class PaqueteFragil : Paquete
    {
        public PaqueteFragil(string codigoSeguimiento, decimal costoEnvio, string destino, string origen, double pesoKg)
            : base(codigoSeguimiento, costoEnvio, destino, origen, pesoKg)
        {

        }

        public override bool TienePrioridad { get { return true; } }
    }
}
