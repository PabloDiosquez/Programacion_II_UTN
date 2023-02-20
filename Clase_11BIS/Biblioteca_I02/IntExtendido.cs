using System;

namespace Biblioteca_I02
{
    public static class IntExtendido
    {
        public static int ContadorDigitos(this Int32 numero)
        {
            int cont = 0;

            while (Math.Abs(numero) > 0)
            {
                cont++;

                numero = numero / 10;
            }

            return cont;
        }

        public static int ContadorDigitosII(this Int32 numero)
        {
            return numero.ToString().Replace("-","").Length;
        }
    }
}
