using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Supermercado
{
    public interface IPersistencia
    {
        void Almacenar(string path);

        void Recuperar(string path);
    }
}
