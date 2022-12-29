using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_4
{
    internal class Sobrecarga

        // SOBRECARGA DE MÉTODOS
    {
        // Cantidad de parámetros 
        public static int Sumar(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Sumar(int num1, int num2, int num3)
        {
            //return (num1 + num2) + num3;

            return Sumar(num1, num2) + num3;
        }

        // Tipo de parámetro

        public static float Sumar(float num1, float num2)
        {
            //return (float)Sumar(num1, num2);

            return num1 + num2; 
        }

        public static string Sumar(string s1, string s2=" Opcional") // 👉🏼 Parámtros opcionales (deben ir siempre al final ⚠)
        {
            return s1 + s2;
        }

        // Orden de los parámetros

        public static float Sumar(int num1, float num2) 
        {
            return num1 + num2;
        }

        public static float Sumar(float num1, int num2) 
        {
            return num1 + num2;
        }
    }
}
