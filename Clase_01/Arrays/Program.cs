using System;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaracióm del array
            int[] numeros = new int[4];

             // Console.WriteLine(numeros[0]); // 👉🏼 Tiene almacenados valores por defecto. En este caso, 0.

            // Carga del array
            numeros[0] = 15;

            numeros[1] = 2;

            numeros[2] = 12;

            numeros[3] = -1;

            // Sintaxis simplificada
            int[] numeros1 = { 1, 2, 3, 4, 5,};

            int[] numeros2 = new int[5] { -1, 23, 15, -42, 101,};

            // Arrays implícitos 👉🏼 No se especifican ni el tipo ni la cantidad de elementos

            var datos = new[] { "Lio", "Messi", "Argentina"};

            var numeros3 = new[] { 1, 2, 3, 4, 5.5, 6 }; // 👉🏼 internamente les asigna a todos el tipo double

            // Array de objetos
            
            Empleado empleado = new Empleado("Lio", "Messi", 35);

            Empleado[] empleados = new Empleado[2];

            empleados[0] = empleado;

            empleados[1] = new Empleado("Emiliano","Martínez",38);

            // Arrays de tipos o clases anónimas

            var personas = new[]
            {
                new {Nombre="Lio", Apellido="Messi", Edad=35 },

                new {Nombre="Enzo", Apellido="Fernández", Edad=20 },

                new {Nombre="Julián", Apellido="Álvarez", Edad=22 },

            };

            //Console.WriteLine(personas[1]);

        }

    }
}
