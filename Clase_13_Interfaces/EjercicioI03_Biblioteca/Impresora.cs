using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioI03_Biblioteca
{
    /// <summary>
    /// Clase que representa una impresora que gestiona una cola de objetos imprimibles.
    /// </summary>
    public class Impresora
    {
        // Atributos 

        /// <summary>
        /// Lista que almacena los objetos imprimibles en espera para su impresión.
        /// </summary>
        private List<Imprimible> colaDeImpresion;

        // Constructor 

        /// <summary>
        /// Constructor de la clase Impresora. Inicializa una nueva instancia de la impresora
        /// con una cola de impresión vacía.
        /// </summary>
        public Impresora()
        {
            colaDeImpresion = new List<Imprimible>();
        }

        // Métodos de instancia 

        /// <summary>
        /// Imprime todos los objetos imprimibles en la cola de impresión.
        /// </summary>
        public string ImprimirTodo()
        {
            string texto = string.Empty;

            foreach (Imprimible imprimible in this.colaDeImpresion)
            {
                texto += $"{imprimible.Imprimir()}\n";
            }
            return texto;
        }

        /// <summary>
        /// Agrega un objeto imprimible a la cola de impresión.
        /// </summary>
        /// <param name="imprimible">Objeto que se agregará a la cola de impresión.</param>
        public void AgregarImprimible(Imprimible imprimible)
        {
            this.colaDeImpresion.Add(imprimible);
        }
    }
}
