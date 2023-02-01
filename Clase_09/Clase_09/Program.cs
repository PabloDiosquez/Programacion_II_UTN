using System;

namespace Clase_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    El polimorfismo es la habilidad de los objetos de responder al mismo mensaje de distintas formas
            //    y también el último de los pilares de la programación orientada a objetos que analizaremos.
            //    Con mensaje nos referimos a cuando un objeto recibe una invocación de uno de los servicios que
            //    ofrece en forma de métodos. Es decir, los objetos del mismo tipo pueden resolver la invocación de
            //    una misma operación(misma firma del método, misma semántica) de diferentes maneras.

            //    Existen distintas formas de implementar el polimorfismo, nosotros veremos polimorfismo basado en herencia.

            //    Una operación especifica un servicio que se puede requerir de cualquier objeto para influir en su
            //    comportamiento o alterar su estado, el qué hace.Un método es una implementación de una operación,
            //    un algoritmo ejecutable que resuelve el requerimiento, el cómo lo hace.En una jerarquía de herencia
            //    puede haber varios métodos para la misma operación, y el polimorfismo selecciona qué método de la
            //    jerarquía se ejecuta en tiempo de ejecución.

            //    Recordemos que todas las clases derivadas heredan la interfaz de su clase base(sus operaciones y 
            //    propiedades públicas).Sin embargo, como cada clase derivada es una entidad semi-independiente,
            //    cada una podría requerir resolver la respuesta al mismo mensaje de distinta forma.

            //    Por ejemplo, si tenemos la clase Animal y una operación llamada EmitirSonido y sus derivadas
            //    Perro, Gato y Vaca.La operación es la misma, hacer un sonido, pero cada sub - tipo de animal emite un
            //    sonido distinto. Los perros ladran, los gatos maullan y las vacas mugen, son distintas formas de resolver
            //    la misma operación.


            Animal animal = new Animal();

            Perro perro = new Perro();

            Gato gato = new Gato();

            Console.WriteLine($"Animal: {animal.EmitirSonido()}");

            Console.WriteLine($"Perro: {perro.EmitirSonido()}");

            Console.WriteLine($"Gato: {gato.EmitirSonido()}");

            Console.WriteLine();

            //    observemos qué sucede si guardamos los objetos de tipo Perro y Gato en una variable de tipo Animal

            Animal animal1 = perro;

            Animal animal2 = gato;

            Console.WriteLine($"Animal: {animal.EmitirSonido()}");

            Console.WriteLine($"Perro: {animal1.EmitirSonido()}");

            Console.WriteLine($"Gato: {animal2.EmitirSonido()}");

            Console.WriteLine();

            //Se ejecuta la implementación del tipo de la referencia, es decir, del tipo de la variable que apunta
            //al objeto. Sin embargo, el objeto en memoria es efectivamente un perro o un gato. Esto se denomina
            //herencia no - polimórfica.

            //Cuando un método se oculta con la palabra reservada new, el entorno de ejecución no distingue el tipo
            //del objeto en memoria, sino que se basa en el tipo de la variable que contiene la referencia.

            //Para implementar polimorfismo en C# debemos declarar el método en la clase base como virtual y
            //redefinirlo en la clase derivada con override. Así el entorno de ejecución podrá distinguir en tiempo 
            //de ejecución el tipo real del objeto en memoria. Se ejecutará la implementación de la operación más 
            //cercana en la jerarquía de herencia al tipo real de la instancia, independientemente del tipo de la 
            //referencia.

            //La palabra reservada virtual se usa para declarar un método que pueda ser sobrescrito por una clase
            //derivada.La palabra reservada override se usa para sobrescribir un método virtual de la clase base.

            //Transformemos el ejemplo de los animales para que aproveche el polimorfismo.

            Personaje personaje = new Personaje();

            Personaje mago = new Mago();

            Personaje arquero = new Arquero();

            Console.WriteLine($"Personaje: {personaje.Atacar()}");

            Console.WriteLine($"Mago: {mago.Atacar()}");

            Console.WriteLine($"Arquero: {arquero.Atacar()}");

            Console.WriteLine();

            //Observemos que a pesar de que el tipo de la variable es Personaje, por polimorfismo se ejecutará la
            //implementación del tipo real del objeto.

            //Probemos agregar un nuevo tipo derivado de Arquero y no invalidar la implementación del método Atacar().

            Arquerito arquerito = new Arquerito(); // 👉🏼 por polimorfismo se ejecutará la implementación más cercana en la jerarquía de herencia.

            Console.WriteLine($"Arquerito: {arquerito.Atacar()}");

        }
    }

    internal class Animal
    {
        public string EmitirSonido()
        {
            return "Roar!";
        }
    }

    //  Podremos compilar igual, pero nos advierten que los métodos declarados en los tipos derivados están ocultado
    //  el método en la clase base. Y nos aconsejan que, si esa fue nuestra intención, deberíamos usar el operador
    //  new en la declaración.

    //  Agregando el operador new hacemos explícita nuestra intención de ocultar la implementación de la clase base.

    internal class Perro : Animal
    {
        public new string EmitirSonido()
        {
            return "Woof!";
        }
    }

    internal class Gato : Animal 
    {
        public new string EmitirSonido()
        {
            return "Miau!";
        }
    }

    internal class Personaje 
    {
        public virtual string Atacar()
        {
            return "Atacando...";
        }
    }

    internal class Mago : Personaje
    {
        public override string Atacar()
        {
            return "Lanzando hechizo...";
        }
    }

    internal class Arquero : Personaje
    {
        public override string Atacar()
        {
            return "Lanzando flecha...";
        }
    }

    internal class Arquerito : Arquero
    {

    }
}
