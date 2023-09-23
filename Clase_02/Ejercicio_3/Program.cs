using System;

namespace Ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //La clase Estudiante:

            //Tendrá un constructor estático que inicializará el atributo estático random.
            //Tendrá un constructor de instancia que inicializará los atributos nombre, apellido y legajo.
            //El método setter SetNotaPrimerParcial permitirá cambiar el valor del atributo notaPrimerParcial.
            //El método setter SetNotaSegundoParcial permitirá cambiar el valor del atributo notaSegundoParcial.
            //El método privado CalcularPromedio retornará el promedio de las dos notas.
            //El método CalcularNotaFinal deberá retornar la nota del final con un numero aleatorio entre 6 y 10 incluidos siempre y cuando las notas del primer y segundo parcial sean mayores o iguales a 4, caso contrario la inicializará con el valor - 1.
            //El método Mostrar utilizará StringBuilder para armar una cadena de texto con todos los datos de los alumnos:
            //Nombre, apellido y legajo.
            //Nota del primer y segundo parcial.
            //Promedio.
            //Nota final. Se mostrará sólo si el valor es distinto de - 1, caso contrario se mostrará la leyenda "Alumno desaprobado".
            //Crear tres instancias de la clase Estudiante(tres objetos) en el método Main.
            //Cargar las notas del primer y segundo parcial a todos los alumnos. Dos deberán estar aprobados y uno desaprobado.
            //Mostrar los datos de todos los alumnos.

            Estudiante estudiante1 = new Estudiante("Lio", "Messi", "123");
            Estudiante estudiante2 = new Estudiante("Dibu", "Martinez", "122");
            Estudiante estudiante3 = new Estudiante("Ángel", "Di María", "321");

            // Notas de los estudiantes 

            estudiante1.SetNotaPrimerParcial(9);
            estudiante1.SetNotaSegundoParcial(7);

            estudiante2.SetNotaPrimerParcial(9);
            estudiante2.SetNotaSegundoParcial(6);

            estudiante3.SetNotaPrimerParcial(3);
            estudiante3.SetNotaSegundoParcial(2);

            // Datos de los estudiantes 

            Console.WriteLine(estudiante1.Mostrar());
            Console.WriteLine(estudiante2.Mostrar());
            Console.WriteLine(estudiante3.Mostrar());
        }
    }
}
