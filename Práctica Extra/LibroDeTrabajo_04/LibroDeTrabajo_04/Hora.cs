using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibroDeTrabajo_04
{
    /// <summary>
    /// Representa una hora del día.
    /// </summary>
    public class Hora
    {
        // Atributos 

        /// <summary>
        /// Almacena las horas de la hora actual.
        /// </summary>
        private int horas;

        /// <summary>
        /// Almacena los minutos de la hora actual.
        /// </summary>
        private int minutos;

        /// <summary>
        /// Almacena los segundos de la hora actual.
        /// </summary>
        private int segundos;

        // Constructores 

        /// <summary>
        /// Constructor predeterminado de la clase Hora.
        /// </summary>
        public Hora()
        {

        }

        /// <summary>
        /// Constructor que inicializa la hora con valores específicos.
        /// </summary>
        /// <param name="horas">Las horas.</param>
        /// <param name="minutos">Los minutos.</param>
        /// <param name="segundos">Los segundos.</param>
        public Hora(int horas, int minutos, int segundos)
        {
            this.horas = ValidarHoras(horas);
            this.minutos = ValidarMinutosOSegundos(minutos);
            this.segundos = ValidarMinutosOSegundos(segundos);
        }

        /// <summary>
        /// Constructor que inicializa la hora a partir de una cadena en formato HH:MM:SS.
        /// </summary>
        /// <param name="hora">La cadena de la hora en formato HH:MM:SS.</param>
        public Hora(string hora)
        {
            char[] separadores = { ':', '-', '/', ',' };
            string[] horasMinutosSegundos = hora.Split(separadores);

            this.horas = ValidarHoras(int.Parse(horasMinutosSegundos[0]));
            this.minutos = ValidarMinutosOSegundos(int.Parse(horasMinutosSegundos[1]));
            this.segundos = ValidarMinutosOSegundos(int.Parse(horasMinutosSegundos[2]));
        }

        // Propiedades 

        /// <summary>
        /// Obtiene o establece las horas.
        /// </summary>
        public int Horas
        {
            get => horas;
            set => horas = value;
        }

        /// <summary>
        /// Obtiene o establece los minutos.
        /// </summary>
        public int Minutos
        {
            get => minutos;
            set => minutos = value;
        }

        /// <summary>
        /// Obtiene o establece los segundos.
        /// </summary>
        public int Segundos
        {
            get => segundos;
            set => segundos = value;
        }

        // Métodos de instancia 

        /// <summary>
        /// Imprime la hora actual en la consola.
        /// </summary>
        public void Imprimir()
        {
            Console.WriteLine(this.ToString());
        }

        /// <summary>
        /// Devuelve una cadena que representa la hora actual.
        /// </summary>
        /// <returns>Una cadena que representa la hora en formato HH HORAS, MM MINUTOS, SS SEGUNDOS.</returns>
        public override string ToString()
        {
            return $"{this.Horas:D2} HORAS, {this.Minutos:D2} MINUTOS, {this.Segundos:D2} SEGUNDOS";
        }

        // Métodos de validación

        /// <summary>
        /// Valida las horas y devuelve el valor si está dentro del rango permitido.
        /// </summary>
        /// <param name="horas">Las horas a validar.</param>
        /// <returns>Las horas validadas o -1 si están fuera del rango permitido.</returns>
        private static int ValidarHoras(int horas)
        {
            if (horas >= 0 && horas < 24) return horas;

            return -1;
        }

        /// <summary>
        /// Valida los minutos o segundos y devuelve el valor si está dentro del rango permitido.
        /// </summary>
        /// <param name="minutosOSegundos">Los minutos o segundos a validar.</param>
        /// <returns>Los minutos o segundos validados o -1 si están fuera del rango permitido.</returns>
        private static int ValidarMinutosOSegundos(int minutosOSegundos)
        {
            if (minutosOSegundos >= 0 && minutosOSegundos < 60) return minutosOSegundos;

            return -1;
        }
    }
}
