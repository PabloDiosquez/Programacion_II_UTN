using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibroDeTrabajo_03
{
    /// <summary>
    /// Representa un punto en un plano bidimensional con coordenadas X e Y.
    /// </summary>
    public class Punto
    {
        // Atributos 

        /// <summary>
        /// Coordenada X del punto.
        /// </summary>
        private double coord_X;

        /// <summary>
        /// Coordenada Y del punto.
        /// </summary>
        private double coord_Y;

        // Constructores 

        /// <summary>
        /// Constructor predeterminado que inicializa el punto en el origen (0,0).
        /// </summary>
        public Punto()
        {
            this.coord_X = 0;
            this.coord_Y = 0;
        }

        /// <summary>
        /// Constructor que inicializa el punto con coordenadas específicas.
        /// </summary>
        /// <param name="coord_X">Coordenada X del punto.</param>
        /// <param name="coord_Y">Coordenada Y del punto.</param>
        public Punto(double coord_X, double coord_Y)
        {
            this.coord_X = coord_X;
            this.coord_Y = coord_Y;
        }

        // Propiedades 

        /// <summary>
        /// Obtiene o establece la coordenada X del punto.
        /// </summary>
        public double X
        {
            get { return coord_X; }
            set { coord_X = value; }
        }

        /// <summary>
        /// Obtiene o establece la coordenada Y del punto.
        /// </summary>
        public double Y
        {
            get { return coord_Y; }
            set { coord_Y = value; }
        }

        // Métodos de instancia 

        /// <summary>
        /// Calcula la distancia entre este punto y otro punto dado.
        /// </summary>
        /// <param name="punto">El otro punto.</param>
        /// <returns>La distancia entre los dos puntos.</returns>
        public double Distancia(Punto punto)
        {
            return (this - punto).Norma();
        }

        /// <summary>
        /// Calcula la norma (módulo) del punto.
        /// </summary>
        /// <returns>La norma del punto.</returns>
        public double Norma()
        {
            return Math.Sqrt(this.ProductoPunto(this));
        }

        /// <summary>
        /// Calcula el producto punto entre este punto y otro punto dado.
        /// </summary>
        /// <param name="punto">El otro punto.</param>
        /// <returns>El producto punto entre los dos puntos.</returns>
        public double ProductoPunto(Punto punto)
        {
            return this.X * punto.X + this.Y * punto.Y;
        }

        // Sobrecarga de operadores

        /// <summary>
        /// Sobrecarga del operador de suma para sumar dos puntos.
        /// </summary>
        public static Punto operator +(Punto primerPunto, Punto segundoPunto)
        {
            if (primerPunto is null || segundoPunto is null) throw new ArgumentNullException();

            return new Punto(primerPunto.X + segundoPunto.X, primerPunto.Y + segundoPunto.Y);
        }

        /// <summary>
        /// Sobrecarga del operador de resta para restar dos puntos.
        /// </summary>
        public static Punto operator -(Punto primerPunto, Punto segundoPunto)
        {
            if (primerPunto is null || segundoPunto is null) throw new ArgumentNullException();

            return new Punto(primerPunto.X - segundoPunto.X, primerPunto.Y - segundoPunto.Y);
        }

        /// <summary>
        /// Sobrecarga del operador de igualdad para comparar dos puntos.
        /// </summary>
        public static bool operator ==(Punto primerPunto, Punto segundoPunto)
        {
            if (ReferenceEquals(primerPunto, segundoPunto)) return true;
            if (primerPunto is null || segundoPunto is null) return false;

            return primerPunto.X == segundoPunto.X && primerPunto.Y == segundoPunto.Y;
        }

        /// <summary>
        /// Sobrecarga del operador de desigualdad para comparar dos puntos.
        /// </summary>
        public static bool operator !=(Punto primerPunto, Punto segundoPunto)
        {
            return !(primerPunto == segundoPunto);
        }
    }
}
