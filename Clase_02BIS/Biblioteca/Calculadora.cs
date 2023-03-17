using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Calculadora
    {
        //Ejercicio I04 - La calculadora

        //Consigna
        //Realizar un programa que permita realizar operaciones matemáticas simples(suma, resta, multiplicación y división).

        //Crear una clase llamada Calculadora que posea dos métodos estáticos(de clase):

        //Calcular(público) : Recibirá tres parámetros, el primer operando, el segundo operando y la operación matemática.El método devolverá el resultado de la operación.

        //Validar(privado): Recibirá como parámetro el segundo operando.Este método se debe utilizar sólo cuando la operación elegida sea la DIVISIÓN.
        //Este método devolverá true si el operando es distinto de cero.

        //Se le debe pedir al usuario que ingrese dos números y la operación que desea realizar (ingresando el caracter +, -, * o /).

        //El usuario decidirá cuándo finalizar el programa.

        public static string Calcular(double operando1, double operando2, string operacion)
        {
            double res = 0;

            switch (operacion)
            {
                case "+":
                    res =  operando1 + operando2;
                    break;

                case "-":
                    res =  operando1 - operando2;
                    break;

                case "*":
                    res = operando1 * operando2;
                    break;

                case "/":
                    if (Validar(operando2))
                    {
                        res = operando1 / operando2;
                    }
                    else
                    {
                        return Double.MaxValue.ToString();
                    }
                    break;
                default:
                    return "Esta operación NO es válida";
                    
            }

            return res.ToString();
        }

        public static bool Validar(double divisor)
        {
            if (divisor != 0)
            {
                return true;
            }

            return false;
        }
    }
}
