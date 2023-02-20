using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class BusinessException: Exception
    {
        public BusinessException(string mensaje) : base (mensaje)
        {
        }
    }
}
