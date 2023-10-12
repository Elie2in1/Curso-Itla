using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Problema 1: Calcular el perímetro de un cuadrado
            Console.WriteLine("Problema 1: Calcular el perímetro de un cuadrado");
            Console.Write("Ingrese el valor del lado del cuadrado: ");
            double ladoCuadrado = Convert.ToDouble(Console.ReadLine());
            double perimetroCuadrado = CalcularPerimetroCuadrado(ladoCuadrado);
            Console.WriteLine($"El perímetro del cuadrado es: {perimetroCuadrado}");

            // Problema 2: Sumar los dos primeros números y multiplicar los dos últimos
            Console.WriteLine("\nProblema 2: Sumar los dos primeros números y multiplicar los dos últimos");
            Console.Write("Ingrese el primer número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese el segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese el tercer número: ");
            double num3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese el cuarto número: ");
            double num4 = Convert.ToDouble(Console.ReadLine());

            double sumaDosPrimeros = SumarDosNumeros(num1, num2);
            double productoDosUltimos = MultiplicarDosNumeros(num3, num4);

            Console.WriteLine($"La suma de los dos primeros números es: {sumaDosPrimeros}");
            Console.WriteLine($"El producto de los dos últimos números es: {productoDosUltimos}");

            // Problema 3: Calcular la suma y el promedio de cuatro valores numéricos
            Console.WriteLine("\nProblema 3: Calcular la suma y el promedio de cuatro valores numéricos");
            Console.Write("Ingrese el primer valor: ");
            double valor1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese el segundo valor: ");
            double valor2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese el tercer valor: ");
            double valor3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese el cuarto valor: ");
            double valor4 = Convert.ToDouble(Console.ReadLine());

            double suma = CalcularSuma(valor1, valor2, valor3, valor4);
            double promedio = CalcularPromedio(valor1, valor2, valor3, valor4);

            Console.WriteLine($"La suma de los cuatro valores es: {suma}");
            Console.WriteLine($"El promedio de los cuatro valores es: {promedio}");
        }

        static double CalcularPerimetroCuadrado(double lado)
        {
            return lado * 4;
        }

        static double SumarDosNumeros(double num1, double num2)
        {
            return num1 + num2;
        }

        static double MultiplicarDosNumeros(double num1, double num2)
        {
            return num1 * num2;
        }

        static double CalcularSuma(double valor1, double valor2, double valor3, double valor4)
        {
            return valor1 + valor2 + valor3 + valor4;
        }

        static double CalcularPromedio(double valor1, double valor2, double valor3, double valor4)
        {
            return (valor1 + valor2 + valor3 + valor4) / 4;
        }
    }
}
