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

        public int notaRandom = random.Next(6,10);

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

        private float CalcularPromedio()
        {
            return (notaPrimerParcial + notaSegundoParcial) / 2F;
        }

        public double CalcularNotaFinal()
        {
            if (notaPrimerParcial >= 4 && notaSegundoParcial >= 4)
            {
                return notaRandom;
            }

            return -1;
        }


        public string MostrarDatosDelAlumno()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("🔹 Datos del Alumno: 🔸");

            sb.AppendLine($"Apellido: {apellido}");

            sb.AppendLine($"Nombre: {nombre}");

            sb.AppendLine($"Legajo: {legajo}");

            sb.AppendLine($"Nota primer parcial: {notaPrimerParcial}");

            sb.AppendLine($"Nota segundo parcial: {notaSegundoParcial}");

            sb.AppendLine($"Promedio: {CalcularPromedio()}");

            double notaFinal = CalcularNotaFinal();

            if (notaFinal != -1)
            {
                sb.AppendLine($"Nota final: {notaFinal}");
            }
            else 
            {
                sb.AppendLine("Alumno desaprobado.");
            }

            return sb.ToString();
        }

        // TODO 1: Crear tres instancias de la clase Estudiante (tres objetos) en el método Main.
        // TODO 2: Cargar las notas del primer y segundo parcial a todos los alumnos. Dos deberán estar aprobados y uno desaprobado.
        // TODO 3: Mostrar los datos de todos los alumnos.
    }
}
