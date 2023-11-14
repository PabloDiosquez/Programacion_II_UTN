using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Supermercado
{
    public interface IPersistencia<T>
    {
        void Almacenar(T objeto, string path);

        T Recuperar(string path);
    }
}
