using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioI01_Biblioteca
{
    public class Lapiz : IAcciones
    {
        // Atributos

        private float tamanioMina;

        // Constructor 
        public Lapiz(int unidades) 
        {
            this.tamanioMina = unidades;
        }

        // Propiedades 

        public float UnidadesDeEscritura { get => this.tamanioMina; }
        
        public ConsoleColor Color { get => ConsoleColor.Gray; set => throw new NotImplementedException(); }

        // Métodos de la interfaz

        public EscrituraWrapper Escribir(string texto)
        {
            float tamanioMinaUsada = this.tamanioMina - 0.1F * texto.Replace(" ", "").Length;

            if (tamanioMinaUsada > 0) this.tamanioMina = tamanioMinaUsada;
            
            else tamanioMina = 0; 

            return new EscrituraWrapper(texto, this.Color);
        }

        public bool Recargar(int unidades) 
        {
            throw new NotImplementedException();
        }

        // Métodos de instancia

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Datos del lápiz");
            sb.AppendLine($"Color de la escritura: {this.Color}");
            sb.AppendLine($"Tamaño de la mina: {this.UnidadesDeEscritura}");

            return sb.ToString();
        }

    }
}
