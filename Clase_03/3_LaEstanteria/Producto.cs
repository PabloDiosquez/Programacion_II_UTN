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

        public string GetMarca()
        {
            return marca;
        }

        public float GetPrecio()
        {
            return precio;
        }

        // Método de clase estático 

        public static string MostrarProdcuto(Producto producto) 
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"*** Datos del producto ***");
            sb.AppendLine($"Marca: {producto.GetMarca()}");
            sb.AppendLine($"Precio: {producto.GetPrecio()}");

            return sb.ToString();
        }

        // Sobrecarga de operadores

        public static explicit operator string(Producto producto) 
        {
            return producto.codigoDeBarra;
        }

        public static bool operator ==(Producto producto1, Producto producto2) 
        {
            return producto1.GetMarca() == producto2.GetMarca();
        }

        public static bool operator !=(Producto producto1, Producto producto2)
        {
            return !(producto1 == producto2);
        }

        public static bool operator ==(Producto producto, string marca)
        {
            return producto.GetMarca() == marca;
        }

        public static bool operator !=(Producto producto, string marca)
        {
            return !(producto == marca);
        }
    }
}
