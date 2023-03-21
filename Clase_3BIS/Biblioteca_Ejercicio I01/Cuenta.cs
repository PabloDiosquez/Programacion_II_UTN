using System;
using System.Text;

namespace Biblioteca_Ejercicio_I01
{
    public class Cuenta
    {
        // titular que contendrá la razón social del titular de la cuenta.
        private string titular;

        // cantidad que será un número decimal que representa al monto actual de dinero en la cuenta.
        private decimal cantidad;

        public Cuenta(string titular, decimal cantidad)
        {
            this.titular = titular;

            this.cantidad = cantidad;   
        }

        public string Titular { get { return titular; } }

        public decimal Cantidad { get { return cantidad; } }


        /// <summary>
        ///  Retorna una cadena de texto con los datos de la cuenta.
        /// </summary>
        /// <returns>string</returns>
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("🔸 Datos de la cuenta 🔸");
            sb.AppendLine($"Titular: {titular}");
            sb.AppendLine($"Cantidad: {cantidad}");

            return sb.ToString();
        }

        /// <summary>
        /// recibirá un monto para acreditar a la cuenta. 
        /// Si el monto ingresado es negativo, no se hará nada.
        /// </summary>
        /// <param name="monto">Monto de dinero a acreditar.</param>
        public void Ingresar(decimal monto)
        {
            if (monto >= 0)
            {
                cantidad += monto;
            }
        }

        /// <summary>
        /// Recibe un monto para debitar de la cuenta.
        /// La cuenta puede quedar en negativo.
        /// </summary>
        /// <param name="monto"></param>
        public void Retirar(decimal monto)
        {
            cantidad -= monto;  
        }
    }
}
