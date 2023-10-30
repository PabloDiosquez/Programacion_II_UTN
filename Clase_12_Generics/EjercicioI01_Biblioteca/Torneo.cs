using System;
using System.Collections.Generic;

namespace EjercicioI01_Biblioteca
{
    public class Torneo<T> 
        where T: Equipo  
    {
        // Atributos 

        private string nombre;

        private List<T> equipos;

        // Constructor 

        public Torneo(string nombre)
        {
            this.nombre = nombre;

            equipos = new List<T>();
        }

        // Métodos de instancia 

        //public static bool operator ==(Torneo<T> torneo, Equipo equipo)
        //{
        //    if()
        //}

    }
}
