using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    internal class Rectangulo
    {
        // Atributos 

        private Punto vertice1; 

        private Punto vertice2;
        
        private Punto vertice3;
        
        private Punto vertice4;

        private float perimetro = -1;

        private float area = -1;

        // Constructor 👷🏼‍

        public Rectangulo(Punto vertice1,Punto vertice3)
        {
            this.vertice1 = vertice1; 
            this.vertice2 = new Punto(Math.Abs(vertice3.GetY() - vertice1.GetX()), vertice1.GetY());

            this.vertice3 = vertice3;

            this.vertice4 = new Punto(vertice1.GetX(), Math.Abs(vertice3.GetY() - vertice1.GetY()));

        }

        // Métodos de instancia 

        public float Perimetro()
        {
            if (perimetro == -1)
            {
                float alturaR = Math.Abs(vertice3.GetY() - vertice1.GetY());

                float baseR = Math.Abs(vertice3.GetX() - vertice1.GetX());

                perimetro = 2 * (baseR + alturaR);
            }

            return perimetro;
        }

        public float Area()
        {
            if (area == -1) 
            {
                float alturaR = Math.Abs(vertice3.GetY() - vertice1.GetY());

                float baseR = Math.Abs(vertice3.GetX() - vertice1.GetX());

                area = baseR * alturaR;
            }

            return area;
        }

        public static string MostrarRectangulo(Rectangulo rectangulo)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"### Datos del rectángulo: ###");
            sb.AppendLine($"Perímetro: {rectangulo.Perimetro()}");
            sb.AppendLine($"Área: {rectangulo.Area()}");
            return sb.ToString();
        }
    }
}
