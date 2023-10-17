/*Confeccionar un programa que permita cargar
un número entero positivo de hasta tres cifras y 
muestre un mensaje indicando si tiene 1, 2, o 3 cifras. 
Mostrar un mensaje de error si el número de cifras es mayor.*/

int num = 0;

string linea=string.Empty;
Console.WriteLine("inserte un numero para analizar");
linea = Console.ReadLine();
num = Convert.ToInt32(linea);

if (num < 10 )
{
    Console.WriteLine("El numero ingresado es de una cifra");
}
else if (num >= 10 && num < 100 )
{
    Console.WriteLine("El numero ingresado es de dos cifras");
}
 if ( num >= 100 && num < 1000 )
{
    Console.WriteLine("El numero ingresado es de tres cifras");
}    
if (num >= 1000)
{
    Console.WriteLine("Error el numero ingresado es Mayor a tres cifras");
}
