/*Confeccionar un programa que lea n pares de datos, cada par de datos corresponde
 * a la medida de la base y la altura de un triángulo. El programa deberá informar:
a) De cada triángulo la medida de su base, su altura y su superficie.
b) La cantidad de triángulos cuya superficie es mayor a 12.*/


triangulo();
void triangulo()
{
int altura  = 0 ;
int Base = 0 ;
int triangulo = 0 ;
int cantidad = 1 ;
int SuperficiesM = 0 ;
string linea = String.Empty ;


    Console.WriteLine("Diga la cantidad de triangulos analizar");
    linea = Console.ReadLine();
    triangulo = Convert.ToInt32(linea); 

    while (triangulo >= cantidad)
    {
        Console.WriteLine("Por favor entrar la medida de la base del triangulo y su altura");
        Console.WriteLine("******************************");

        Console.WriteLine("Inserte la Base");
        linea = Console.ReadLine();
        Base = Convert.ToInt32(linea);

        Console.WriteLine("Inserte la Altura");
        linea = Console.ReadLine();
        altura = Convert.ToInt32(linea);
        int Superficie = (Base * altura) / 2;
        
        Console.WriteLine($"El triangulo tiene una Base de {Base} una Altura de {altura} y su Area es {Superficie}");
        Console.WriteLine($"--------------------------------");
        

           if (Superficie > 12)
        {
            SuperficiesM += 1;
            Console.WriteLine($"/***Los triangulos cuya superfice es mayor a 12 son { SuperficiesM }***");
            Console.WriteLine($"-*-*-*-*-*-*-*-*--*-*-*-*-*-*-");
        }
        cantidad++;
    }
    
 
}

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