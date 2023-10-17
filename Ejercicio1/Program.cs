
/*Problema 1:Realizar un programa que realice la carga del lado de un cuadrado,
mostrar por pantalla el perímetro del mismo 
(El perímetro de un cuadrado se calcula multiplicando el valor del lado por cuatro).*/
int lado = 0;
string linea = string.Empty;
Console.WriteLine("Ingrese la medida de un lado del cuadro");
linea = Console.ReadLine();
lado = Convert.ToInt32(linea);
int perimetro = lado * 4;
Console.WriteLine("El perimetro del cuadro es: "+  perimetro);
Console.WriteLine("*****************************************");

/* Problema 2: Escribir un programa en el cual se ingresen
cuatro números, calcular e informar la suma de los dos primeros
y el producto del tercero y el cuarto.*/
int num1 = 0;
int num2 = 0;
int num3 = 0;
int num4 = 0;
Console.WriteLine("Entrar Primer numero");
linea = Console.ReadLine();
num1 = Convert.ToInt32(linea);

Console.WriteLine("Entrar Segundo numero");
linea = Console.ReadLine();
num2 = Convert.ToInt32(linea);

Console.WriteLine("Entrar tercer numero");
linea = Console.ReadLine();
num3 = Convert.ToInt32(linea);

Console.WriteLine("Entrar cuarto numero");
linea = Console.ReadLine();
num4 = Convert.ToInt32(linea);

int suma = num1 + num2;
int producto = num3 * num4;

Console.WriteLine("La suma del primer y segundo numero es:"+  suma);
Console.WriteLine("El producto de tercer y cuarto numero es:"+  producto);
Console.WriteLine("*****************************************");
/* Problema 3: Calcular la suma y el promedio de cuatro valores numérico
*/
int val1 = 0;
int val2 = 0;
int val3 = 0;
int val4 = 0;
Console.WriteLine("Entrar Primer valor");
linea = Console.ReadLine();
val1 = Convert.ToInt32(linea);

Console.WriteLine("Entrar Segundo valor");
linea = Console.ReadLine();
val2 = Convert.ToInt32(linea);

Console.WriteLine("Entrar tercer valor");
linea = Console.ReadLine();
val3 = Convert.ToInt32(linea);

Console.WriteLine("Entrar cuarto valor");
linea = Console.ReadLine();
val4 = Convert.ToInt32(linea);

int suma2 = val1 + val2 + val3 + val4;
int promedio = suma2 / 4;

Console.WriteLine("La suma de los valores es:" + suma2);
Console.WriteLine("El promedio de los valores es:" + promedio);