using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_18
{
    public static class ListaExtension
    {
        public static List<T> Filtar<T>(this List<T> lista, Predicate<T> condicion)
        {
            List<T> listaFiltrada = new List<T>();  

            foreach (T elemento in lista) 
            {
                if(condicion(elemento)) listaFiltrada.Add(elemento);    
            }
            return listaFiltrada;   
        }
    }
}
