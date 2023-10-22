/*Desarrollar un programa que solicite la carga de 10 números e imprima la suma de los últimos 5 valores ingresados*/
Numeros1A10();
void Numeros1A10()
{
    int cantidadNumeros = 10;
    List<int> numeros = new List<int>();
    int sumaUltimos5 = 0;

    Console.WriteLine("Ingrese 10 números:");

    for (int i = 0; i < cantidadNumeros; i++)
    {
        Console.Write($"Número {i + 1}: ");
        int numero = Convert.ToInt32(Console.ReadLine());
        numeros.Add(numero); // Agrega el número a la lista
    }

    // Calcular la suma de los últimos 5 números ingresados
    int conteo = numeros.Count - 5;
    for (int i = conteo; i < numeros.Count; i++)
    {
        sumaUltimos5 += numeros[i];
    }

    Console.WriteLine($"La suma de los últimos 5 números ingresados es: {sumaUltimos5}");
}