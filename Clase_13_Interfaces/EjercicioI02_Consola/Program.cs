﻿using System;
using EjercicioI02_Biblioteca;
using System.Text;
using System.Collections.Generic;

namespace EjercicioI02_Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Paquete> paquetes = new List<Paquete>();
            paquetes.Add(new PaqueteFragil("F01", 190.00M, "Buenos aires", "La rioja", 1.75));
            paquetes.Add(new PaquetePesado("P01", 2598.63M, "Misiones", "San luis", 56.32));
            paquetes.Add(new PaqueteFragil("F02", 1599.99M, "Córdoba", "Mendoza", 44.12));
            paquetes.Add(new PaquetePesado("P02", 639.60M, "Jujuy", "Tierra del fuego", 5.05));
            paquetes.Add(new PaqueteFragil("F03", 458.95M, "Santa cruz", "San Juan", 10.00));
            paquetes.Add(new PaquetePesado("P03", 120.40M, "Río negro", "Neuquén", 35.00));

            GestionImpuestos gestionImpuestos = new GestionImpuestos();
            gestionImpuestos.RegistrarImpuestos(paquetes);

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Total impuestos aduana: ${gestionImpuestos.CalcularTotalImpuestosAduana():#.00}");
            stringBuilder.AppendLine($"Total impuestos AFIP: ${gestionImpuestos.CalcularTotalImpuestosAfip():#.00}");
            stringBuilder.AppendLine();
            stringBuilder.AppendLine($"Paquetes:");

            for (int i = 0; i < paquetes.Count; i++)
            {
                stringBuilder.AppendLine("---------------------------------------");
                stringBuilder.AppendLine($"PAQUETE {i + 1:00}");
                stringBuilder.AppendLine(paquetes[i].ObtenerInformacionDePaquete());

                if (paquetes[i] is IAfip paqueteAfip)
                {
                    stringBuilder.AppendLine($"Impuesto AFIP: ${paqueteAfip.Impuestos:#.00}");
                }

                if (paquetes[i] is IAduana paqueteAduana)
                {
                    stringBuilder.AppendLine($"Impuesto aduana: ${paqueteAduana.Impuestos:#.00}");
                }

                stringBuilder.AppendLine($"Costo de envío con impuestos: ${paquetes[i].AplicarImpuestos():#.00}");
            }

            stringBuilder.AppendLine("---------------------------------------");

            Console.WriteLine(stringBuilder);
        }
    }
}
