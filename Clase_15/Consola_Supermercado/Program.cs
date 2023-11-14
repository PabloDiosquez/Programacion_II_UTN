using System;
using System.IO;
using Biblioteca_Supermercado;

namespace Consola_Supermercado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListaSupermercado lista = new ListaSupermercado();

            lista.Agregar("Huevos");
            lista.Agregar("Pan");
            lista.Agregar("Azúcar");
            lista.Agregar("Yerba");
            lista.ActualizarLista(lista.PathArchivo);

            //lista.LimpiarLista(lista.PathArchivo);
        }
    }
}
