using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_LaEstanteria
{
    /// <summary>
    /// Representa un estante que almacena productos en una ubicación específica.
    /// </summary>
    public class Estante
    {
        // Atributos 

        /// <summary>
        /// Almacena la ubicación física del estante en un lugar específico.
        /// </summary>
        private int ubicacionEstante;

        /// <summary>
        /// Almacena una matriz de objetos de tipo Producto que representan los productos almacenados en el estante.
        /// </summary>
        private Producto[] productos;

        // Constructor 

        /// <summary>
        /// Constructor privado que inicializa un estante con una capacidad especificada.
        /// </summary>
        /// <param name="capacidad">La cantidad máxima de productos que puede contener el estante.</param>
        private Estante(int capacidad)
        {
            productos = new Producto[capacidad];
        }

        /// <summary>
        /// Constructor público que inicializa un estante con una capacidad y ubicación específicas.
        /// </summary>
        /// <param name="capacidad">La cantidad máxima de productos que puede contener el estante.</param>
        /// <param name="ubicacion">La ubicación física del estante en un lugar específico.</param>
        public Estante(int capacidad, int ubicacion) : this(capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }

        // Métodos de instancia 

        /// <summary>
        /// Obtiene la matriz de productos almacenados en el estante.
        /// </summary>
        /// <returns>Una matriz de objetos de tipo Producto.</returns>
        public Producto[] GetProductos()
        {
            return productos;
        }

        /// <summary>
        /// Muestra una representación detallada de los productos almacenados en el estante en forma de una cadena de texto.
        /// </summary>
        /// <param name="estante">El estante que se desea mostrar.</param>
        /// <returns>Una cadena de texto que describe los productos en el estante.</returns>
        public static string MostrarEstante(Estante estante)
        {
            StringBuilder sb = new StringBuilder();

            foreach (Producto producto in estante.GetProductos())
            {
                sb.AppendLine(Producto.MostrarProducto(producto));
            }
            return sb.ToString();
        }

        // Sobrecarga de operadores 

        /// <summary>
        /// Comprueba si un producto está contenido en el estante.
        /// </summary>
        /// <param name="estante">El estante en el que se busca el producto.</param>
        /// <param name="producto">El producto que se busca en el estante.</param>
        /// <returns>True si el producto está en el estante, False en caso contrario.</returns>
        public static bool operator ==(Estante estante, Producto producto)
        {
            return estante.GetProductos().Contains(producto);
        }

        /// <summary>
        /// Comprueba si un producto no está contenido en el estante.
        /// </summary>
        /// <param name="estante">El estante en el que se busca el producto.</param>
        /// <param name="producto">El producto que se busca en el estante.</param>
        /// <returns>True si el producto no está en el estante, False en caso contrario.</returns>
        public static bool operator !=(Estante estante, Producto producto)
        {
            return !(estante == producto);
        }

        /// <summary>
        /// Agrega un producto al estante si hay espacio disponible.
        /// </summary>
        /// <param name="estante">El estante al que se intenta agregar el producto.</param>
        /// <param name="producto">El producto que se intenta agregar.</param>
        /// <returns>True si el producto se agregó correctamente, False si no hay espacio disponible.</returns>
        public static bool operator +(Estante estante, Producto producto)
        {
            int indiceVacio = -1;

            for (int i = 0; i < estante.GetProductos().Length; i++)
            {
                if (estante.GetProductos()[i] is null)
                {
                    indiceVacio = i;
                    break;
                }
            }

            if (indiceVacio != -1)
            {
                estante.GetProductos()[indiceVacio] = producto;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Elimina un producto del estante si está presente.
        /// </summary>
        /// <param name="estante">El estante del que se intenta eliminar el producto.</param>
        /// <param name="producto">El producto que se intenta eliminar.</param>
        /// <returns>True si el producto se eliminó correctamente, False si el producto no está presente en el estante.</returns>
        public static bool operator -(Estante estante, Producto producto)
        {
            int indiceBuscado = -1;

            for (int i = 0; i < estante.GetProductos().Length; i++)
            {
                if (estante.GetProductos()[i].ToString() == producto.ToString())
                {
                    indiceBuscado = i;
                    break;
                }
            }

            if (indiceBuscado != -1)
            {
                estante.GetProductos()[indiceBuscado] = null;
                return true;
            }
            return false;
        }
    }
}
