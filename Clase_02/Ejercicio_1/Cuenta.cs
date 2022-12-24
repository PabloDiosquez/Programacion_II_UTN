using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    internal class Cuenta
    {
        private string titular;

        private decimal cantidad;

        public Cuenta(string titular, decimal cantidad) 
        {
            this.titular = titular;

            this.cantidad = cantidad;
        }

        public string ObtenerTitular() 
        {
            return titular;
        }

        public decimal ObtenerCantidad()
        {
            return cantidad;
        }

        public string MostrarDatos() 
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Datos de la cuenta:");
            sb.AppendLine($"Titular: {titular}");
            sb.AppendLine($"Monto actual de dinero de la cuenta: ARS {cantidad}");

            return sb.ToString();
        }

        public void Ingresar(decimal monto) 
        {
            if (monto >= 0)
                cantidad += monto;
        }

        public void Retirar(decimal monto) 
        {
            if (monto >= 0)
                cantidad -= monto;
        }
    }
}
