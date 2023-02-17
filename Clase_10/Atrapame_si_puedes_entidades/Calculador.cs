using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atrapame_si_puedes
{
    internal static class Calculador
    {
        public static int calculador(int dividendo, int divisor)
        {
            try
            {
                int res = dividendo / divisor;

                return res;
            }
            catch (DivideByZeroException ex)
            {
                throw ex;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
