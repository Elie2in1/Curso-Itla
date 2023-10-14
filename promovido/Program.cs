using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Calculadora de Promedio de Notas");
        Console.WriteLine("Por favor, ingrese las tres notas:");

        // Solicitar y leer las tres notas del usuario
        Console.Write("Nota 1: ");
        double nota1 = double.Parse(Console.ReadLine());

        Console.Write("Nota 2: ");
        double nota2 = double.Parse(Console.ReadLine());

        Console.Write("Nota 3: ");
        double nota3 = double.Parse(Console.ReadLine());

        // Calcular el promedio de las notas
        double promedio = (nota1 + nota2 + nota3) / 3.0;

        // Comprobar si el estudiante está promovido o no
        if (promedio >= 7.0)
        {
            Console.WriteLine("Promovido con un promedio de {0}", promedio);
        }
        else
        {
            Console.WriteLine("No promovido con un promedio de {0}", promedio);
        }
    }
}
