using System;
using System.Text;

namespace EjercicioI01_Biblioteca
{
    public class Boligrafo : IAcciones
    {
        // Atributos

        private ConsoleColor colorTinta;

        private float tinta;

        // Constructor 

        public Boligrafo(int unidades, ConsoleColor color)
        {
            this.tinta = unidades;

            this.colorTinta = color;
        }

        // Propiedades 
        public ConsoleColor Color { get => colorTinta; set => colorTinta = value; }
        public float UnidadesDeEscritura { get => tinta; }

        // Métodos de instancia

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Información sobre el Bolígrafo:");
            sb.AppendLine($"Color de la escritura: {Color}");
            sb.AppendLine($"Nivel de Tinta: {UnidadesDeEscritura}");

            return sb.ToString();
        }

        // Métodos de la interfaz

        public EscrituraWrapper Escribir(string texto)
        {
            float tintaUsada = 0.3F * texto.Replace(" ", "").Length;

            if (this.UnidadesDeEscritura - tintaUsada >= 0)
            {
                this.tinta -= tintaUsada;
            }
            else this.tinta = 0;

            return new EscrituraWrapper(texto, this.colorTinta);
        }

        public bool Recargar(int unidades)
        {
            bool recargaRealizada = false;

            if (unidades >= 0) 
            {
                this.tinta += unidades;

                recargaRealizada = true;
            }
            return recargaRealizada;
        }
        
    }
}
