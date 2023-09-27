using System;
using System.Text;

namespace _3_LaEstanteria
{
    public class Producto
    {
        // Atributos
        private string codigoDeBarra;
        private string marca;
        private float precio;

        // Constructor
        public Producto(string codigoDeBarra, string marca, float precio)
        {
            this.codigoDeBarra = codigoDeBarra;
            this.marca = marca;
            this.precio = precio;
        }

        // Métodos de instancia

        /// <summary>
        /// Obtiene la marca del producto.
        /// </summary>
        /// <returns>La marca del producto (string).</returns>
        public string GetMarca()
        {
            return marca;
        }

        /// <summary>
        /// Obtiene el precio del producto.
        /// </summary>
        /// <returns>El precio del producto (float).</returns>
        public float GetPrecio()
        {
            return precio;
        }

        // Método de clase estático

        /// <summary>
        /// Retorna una cadena de caracteres que contiene la información del producto.
        /// </summary>
        /// <param name="producto">El producto cuya información se quiere mostrar.</param>
        /// <returns>Una cadena de caracteres que describe el producto (string).</returns>
        public static string MostrarProducto(Producto producto)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("*** Datos del producto ***");
            sb.AppendLine($"Marca: {producto.GetMarca()}");
            sb.AppendLine($"Precio: {producto.GetPrecio()}");

            return sb.ToString();
        }

        // Sobrecarga de operadores

        /// <summary>
        /// Convierte un producto en una cadena de caracteres, mostrando su código de barras.
        /// </summary>
        /// <param name="producto">El producto del cual se describe el código de barras.</param>
        public static explicit operator string(Producto producto)
        {
            return producto.codigoDeBarra;
        }

        /// <summary>
        /// Compara si dos productos son iguales basándose en sus marcas.
        /// </summary>
        /// <param name="producto1">El primer producto a comparar.</param>
        /// <param name="producto2">El segundo producto a comparar.</param>
        /// <returns>True si las marcas son iguales, False en caso contrario (bool).</returns>
        public static bool operator ==(Producto producto1, Producto producto2)
        {
            return producto1.GetMarca() == producto2.GetMarca();
        }

        /// <summary>
        /// Compara si dos productos son diferentes basándose en sus marcas.
        /// </summary>
        /// <param name="producto1">El primer producto a comparar.</param>
        /// <param name="producto2">El segundo producto a comparar.</param>
        /// <returns>True si las marcas son diferentes, False en caso contrario (bool).</returns>
        public static bool operator !=(Producto producto1, Producto producto2)
        {
            return !(producto1 == producto2);
        }

        /// <summary>
        /// Compara si un producto tiene la misma marca que una cadena de caracteres.
        /// </summary>
        /// <param name="producto">El producto a comparar.</param>
        /// <param name="marca">La marca a comparar.</param>
        /// <returns>True si la marca del producto es igual a la marca dada, False en caso contrario (bool).</returns>
        public static bool operator ==(Producto producto, string marca)
        {
            return producto.GetMarca() == marca;
        }

        /// <summary>
        /// Compara si un producto tiene una marca diferente a una cadena de caracteres.
        /// </summary>
        /// <param name="producto">El producto a comparar.</param>
        /// <param name="marca">La marca a comparar.</param>
        /// <returns>True si la marca del producto es diferente a la marca dada, False en caso contrario (bool).</returns>
        public static bool operator !=(Producto producto, string marca)
        {
            return !(producto == marca);
        }
    }
}
