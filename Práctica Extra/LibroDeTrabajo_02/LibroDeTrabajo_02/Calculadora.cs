using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibroDeTrabajo_02
{
    // Ejercicio 4.
    
    public static class Calculadora
    {
        public static double Calcular(double primerNumero, double segundoNumero, string operador) 
        {
            switch (operador)
            {
                case "+":
                    return primerNumero + segundoNumero;
                case "-":
                    return primerNumero - segundoNumero;
                case "*":
                    return primerNumero * segundoNumero;
                case "/":
                    if (segundoNumero != 0) return primerNumero / segundoNumero;
                    else return double.MaxValue;
                default:
                    Console.WriteLine($"{operador} NO es una operador válido...");
                    return double.NaN;  
            }
        }

    }
}
