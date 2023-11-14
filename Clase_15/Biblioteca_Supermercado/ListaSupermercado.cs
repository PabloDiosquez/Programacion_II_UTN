using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Supermercado
{
    public class ListaSupermercado
    {
        // Atributos 

        private List<string> lista;

        static string path;

        static string pathArchivo;

        public string PathArchivo { get { return pathArchivo; } }


        // Constructores

        static ListaSupermercado() 
        {
            path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            pathArchivo = $@"{path}\listaSuper.json";
        }

        public ListaSupermercado()
        {
            lista = new List<string>(); 
        }

        // Métodos de instancia 

        public void ActualizarLista(string path)
        {
            //List<string> listaSwap = this.lista.ToList();

            //LimpiarLista();

            //// Restaurar la lista original desde la copia
            //lista.AddRange(listaSwap);

            // Almacenar la lista en el archivo JSON
            new SerializadorJSON<List<string>>().Almacenar(lista, path);
        }
        public void Agregar(string objeto)
        {
            this.lista.Add(objeto);
        }

        // TODO 1: Probar éste método.
        public bool Modificar(string objetoAnterior, string objetoNuevo)
        {
            if (this.lista.Contains(objetoAnterior))
            {
                int indice = this.lista.IndexOf(objetoAnterior);

                this.lista[indice] = objetoNuevo;

                this.ActualizarLista(pathArchivo);

                return true;
            }

            return false;
        }

        // TODO 2: Probar éste método.
        public bool Eliminar(string objeto) 
        {
            if (this.lista.Contains(objeto))
            {
                this.lista.Remove(objeto);  

                return true;
            }
            return false;
        }

        public void LimpiarLista(string path) 
        {
            lista.Clear();

            SerializadorJSON<List<string>>.VaciarJson(path);
        }
    }
}
