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

