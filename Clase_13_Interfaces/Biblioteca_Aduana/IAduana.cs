﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Aduana
{
    internal interface IAduana
    {
        decimal Impuestos { get; }

        decimal AplicarImpuestos();
    }
}
