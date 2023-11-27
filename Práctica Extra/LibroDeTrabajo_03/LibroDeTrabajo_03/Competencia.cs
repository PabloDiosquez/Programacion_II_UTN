using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibroDeTrabajo_03
{
    public class Competencia
    {
        // Atributos

        private List<Alumno> alumnosInscriptos;

        private int totalInscritos;

        // Constructor 

        public Competencia()
        {
            this.alumnosInscriptos = new List<Alumno>();

            this.totalInscritos = 0;
        }

        // Métodos de instancia 

        public bool InscribirAlumno(Alumno alumno) 
        {
            if (!this.ExisteAlumno(alumno))
            {
                this.alumnosInscriptos.Add(alumno);

                this.totalInscritos++;

                return true;
            } 
            return false;
            
        }

        public bool BorrarAlumno(Alumno alumno) 
        {
            if (this.ExisteAlumno(alumno))
            {
                this.alumnosInscriptos.Remove(alumno);

                this.totalInscritos--;

                return true;
            }
            return false;
        }

        public int ObtenerTotalAlumnosInscriptos() 
        {
            return this.totalInscritos;
        }

        public int ObtenerTotalEscuelas()
        {
            return this.ObtenerEscuelas().Count();
        }

        public string ImprimirEscuelas() 
        {
            StringBuilder sb = new StringBuilder();

            List<string> escuelas = this.ObtenerEscuelas();

            escuelas.Sort();

            sb.AppendLine(" *** Escuelas inscriptas *** ");

            foreach (string escuela in escuelas)
            {
                sb.AppendLine(escuela);
            }

            return sb.ToString();
        }

        private List<string> ObtenerEscuelas()
        {
            List<string> escuelas = new List<string>();

            foreach (Alumno alumno in this.alumnosInscriptos)
            {
                if (!escuelas.Contains(alumno.NombreEscuela))
                {
                    escuelas.Add(alumno.NombreEscuela);
                }
            }
            return escuelas;
        }

        private bool ExisteAlumno(Alumno alumno) 
        {
            foreach (Alumno alumnoInscripto in this.alumnosInscriptos)
            {
                if (alumno.Dni == alumnoInscripto.Dni) return true;
            }
            return false;
        }
    }
}
