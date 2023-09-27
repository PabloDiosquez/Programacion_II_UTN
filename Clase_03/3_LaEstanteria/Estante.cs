using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_LaEstanteria
{
    public class Estante
    {
        // Atributos 

        private int ubicacionEstante;

        private Producto[] productos;

        // Constructor 

        private Estante(int capacidad)
        {
            productos = new Producto[capacidad];
        }

        public Estante(int capacidad, int ubicacion) : this(capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }

        // Métodos de instancia 
        public Producto[] GetProductos()
        {
            return productos;
        }

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

        public static bool operator ==(Estante estante, Producto producto)
        {
            return estante.GetProductos().Contains(producto);
        }

        public static bool operator !=(Estante estante, Producto producto)
        {
            return !(estante == producto);
        }

    }
}
