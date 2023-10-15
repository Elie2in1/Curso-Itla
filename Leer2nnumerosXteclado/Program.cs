// Realizar un programa que lea por teclado dos números, si el primero es mayor al
// segundo informar su suma y diferencia, en caso contrario informar
// el producto y la división del primero respecto al segundo.

int num1 = 0;
int num2 = 0;

string linea = string.Empty;
Console.WriteLine("Por favor escribir primer Numero");
linea = Console.ReadLine();
num1 = Convert.ToInt32(linea);

Console.WriteLine("Por favor escribir segundo numero");
linea = Console.ReadLine();
num2 = Convert.ToInt32(linea);

int suma = num1 + num2;
int diferencia = num1 - num2;
int producto = num1 * num2;
int division = num2 / num1;

if (num1 > num2)
{   Console.WriteLine("La suma de los numeros es: " + suma);
    Console.WriteLine("La diferencia de los numeros es: " + diferencia);
        }
else
{
    if (num1 < num2)
    { Console.WriteLine("El producto de los numero es:" + producto); 
    Console.WriteLine("La division de los numero es:" + division);
    }

}