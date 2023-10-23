using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioI01_Biblioteca
{
    public interface IAcciones
    {
        // Propiedades 

        ConsoleColor Color { get; set; }

        float UnidadesDeEscritura { get; }

        // Métodos 
        EscrituraWrapper Escribir(string texto);

        bool Recargar(int unidades);
    }
}
