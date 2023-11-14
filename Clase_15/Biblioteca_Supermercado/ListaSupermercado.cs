using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Supermercado
{
    public class ListaSupermercado
    {
        // Atributos 

        private DateTime fecha;

        private List<string> lista;


        // Constructores

        static ListaSupermercado() 
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            string pathArchivo = $@"{path}\listaSuper.json";
        }

        public ListaSupermercado() { }

        // Métodos de instancia 
        public void Agregar(string objeto)
        {
            this.lista.Add(objeto);
        }

        public bool Modificar(string objetoAnterior, string objetoNuevo)
        {
            return false;
        }

        public bool Eliminar(string objeto) 
        {
            return false;
        }

        public void LimpiarLista() 
        {

        }
    }
}
