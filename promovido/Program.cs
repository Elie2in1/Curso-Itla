using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Calculadora de Promedio de Notas");
        int nota1 = PedirNota("Nota 1");
        int nota2 = PedirNota("Nota 2");
        int nota3 = PedirNota("Nota 3");

        int promedio = CalcularPromedio(nota1, nota2, nota3);

        MostrarResultado(promedio);
    }

    static int PedirNota(string nombreNota)
    {
        Console.Write($"{nombreNota}: ");
        return int.Parse(Console.ReadLine());
    }

    static int CalcularPromedio(int nota1, int nota2, int nota3)
    {
        return (nota1 + nota2 + nota3) / 3;
    }

    static void MostrarResultado(int promedio)
    {
        if (promedio >= 7)
        {
            Console.WriteLine("Promovido con un promedio de {0}", promedio);
        }
        else
        {
            Console.WriteLine("No promovido con un promedio de {0}", promedio);
        }
    }
}
