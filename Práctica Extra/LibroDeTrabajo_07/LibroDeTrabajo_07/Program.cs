using System;

namespace LibroDeTrabajo_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ejercicio 1.

            //¿Qué salida por la consola produce el siguiente código ?
            int x = 0;
            try
            {
                Console.WriteLine(1.2 / x);
                Console.WriteLine("Si es un numero real, hace la división por cero");
                Console.WriteLine(1 / x);
                Console.WriteLine("Ok");
            }
            catch (Exception)
            {
                Console.WriteLine("No puede dividir por cero un numero entero");
            }
            //¿Qué se puede inferir respecto de la excepción división por cero en relación al tipo de
            //los operandos?

            //Console.WriteLine(1.0 / x);: Aquí intentas realizar una división por cero con un número de punto flotante(1.0).
            //En C#, cuando divides un número de punto flotante por cero, obtienes un resultado especial llamado "Infinity" o
            //"NegativeInfinity" dependiendo del signo.

            //En este caso, la salida en la consola será "Infinity"(si x es 0) o "-Infinity"(si x es - 0).

            //Console.WriteLine("Si es un numero real, hace la división por cero");: Se imprimirá este mensaje en la consola.

            //Console.WriteLine(1 / x);: Aquí intentas realizar una división por cero con un número entero.Esta operación
            //resultará en una excepción System.DivideByZeroException porque la división por cero no está definida para números
            //enteros.

            //Debido a la excepción, la ejecución saltará directamente al bloque catch y no se ejecutará el código restante
            //dentro del bloque try.

            //Console.WriteLine("Ok");: Este código no se ejecutará porque ya estamos manejando la excepción en el bloque catch.

            //El bloque catch (Exception) { Console.WriteLine("No puede dividir por cero un numero entero"); }
            // manejará la excepción DivideByZeroException y imprimirá "No puede dividir por cero un numero entero" en
            // la consola.


            //Ejercicio 2.

            //Suponiendo que está definida la clase NoEsElJefeException ¿Por qué no es atrapada la
            //excepción en el siguiente código?

            //bool jefe = true;
            //try
            //{
            //    if (!jefe)
            //        new NoEsElJefeException();
            //    Console.WriteLine("Bienvenido jefe");
            //}
            //catch (NoEsElJefeException)
            //{
            //    Console.WriteLine("No está autorizado");
            //}

            //En el código proporcionado, aunque creas una instancia de la clase `NoEsElJefeException`, no la estás lanzando explícitamente.En C#, las excepciones no se manejan automáticamente solo porque se crea una instancia de una clase de excepción. Necesitas utilizar la palabra clave `throw` para lanzar la excepción.

            //Aquí hay una versión corregida del código:

            //bool jefe = true;
            // try
            // {
            //     if (!jefe)
            //     {
            //         throw new NoEsElJefeException();
            //     }
            //     Console.WriteLine("Bienvenido jefe");
            // }
            // catch (NoEsElJefeException)
            // {
            //     Console.WriteLine("No está autorizado");
            // }

            //En este ejemplo, si `jefe` es `false`, se lanzará la excepción `NoEsElJefeException`
            //con la palabra clave `throw`. Luego, la excepción será atrapada por el bloque `catch` y
            //se imprimirá "No está autorizado" en la consola.Si `jefe` es `true`, se imprimirá
            //"Bienvenido jefe" en la consola sin lanzar ni atrapar ninguna excepción.

            // Ejercicio 3.

            try
            {
                metodo1();
            }
            catch (Exception)
            {
                Console.WriteLine($"método 1 propagó una excepción");
            }
            
            //¿Qué imprime? ¿Por qué?

            //La variable b es de tipo byte, que es un tipo de dato sin signo y tiene un rango
            //de 0 a 255.Al intentar incrementar el valor de b más allá de 255, ocurre un
            //desbordamiento.

            //Debido al desbordamiento, se produce una excepción de tipo System.OverflowException.
            //Sin embargo, el bloque catch en el método Main solo atrapa excepciones de tipo
            //Exception.

            //Aunque la excepción generada es de un tipo más específico(OverflowException), la
            //excepción no se maneja en el método Main porque el bloque catch solo está buscando
            //excepciones de tipo Exception.

            //El bloque finally dentro del método metodo1 siempre se ejecuta, independientemente
            //de si se produce una excepción o no.En este caso, se imprimirá "bloque finally".

            // Ejercicio 5.

            int[] arreglo = { 1, 2, 3, 4, 5 };
            int valorBuscado = 10;

            try
            {
                int posicion = Helper.index(arreglo, valorBuscado);
                Console.WriteLine($"El valor {valorBuscado} se encuentra en la posición {posicion}");
            }
            catch (ValorNoEncontradoException ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
        static void metodo1()
        {
            byte b = 255;
            try
            {
                b++;
            }
            finally
            {
                Console.WriteLine("bloque finally");
            }

        }

    }
}
