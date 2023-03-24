using System;
using System.Text;

namespace Ejercicio_I03___El_ejemplo_universal
{
    public class Estudiante
    {
        private string apellido;

        private string legajo;

        private string nombre;

        private int notaPrimerParcial;

        private int notaSegundoParcial;

        private static Random random;

        static Estudiante()
        {
            random = new Random();  
        }

        public Estudiante(string apellido, string nombre, string legajo)
        {
            this.apellido = apellido;

            this.legajo = nombre;   

            this.nombre = legajo;   
        }

        public void SetNotaPrimerParcial(int notaPrimerParcial)
        {
            this.notaPrimerParcial = notaPrimerParcial;
        }

        public void SetNotaSegundoParcial(int notaSegundoParcial)
        {
            this.notaSegundoParcial = notaSegundoParcial;
        }

        private int CalcularPromedio()
        {
            return (notaPrimerParcial + notaSegundoParcial) / 2;
        }

        public string MostrarDatosDelAlumno()
        {
            StringBuilder sb = new StringBuilder();


            return sb.ToString();
        }
    }
}
