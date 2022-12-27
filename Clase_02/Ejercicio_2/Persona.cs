using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    internal class Persona
    {
        private string nombre;

        private DateTime fechaNacimiento;

        private int dni;

        public Persona(string nombre, DateTime fechaNacimiento, int dni)
        {
            AsignarNombre(nombre);

            AsignarFechaNacimiento(fechaNacimiento);

            AsignarDni(dni);
        }

        public string ObtenerNombre() 
        {
            return nombre;
        }

        public void AsignarNombre(string nombre) 
        {
            this.nombre = nombre;
        }

        public DateTime ObtenerFechaNacimiento() 
        {
            return fechaNacimiento;
        }

        public void AsignarFechaNacimiento(DateTime fecha) 
        {
            this.fechaNacimiento = fecha;
        }

        public int ObtenerDni() 
        {
            return dni;
        }

        public void AsignarDni(int dni)
        {
            this.dni = dni;
        }
    }
}
