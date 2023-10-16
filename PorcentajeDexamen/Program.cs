/*Un postulante a un empleo, realiza un test de capacitación, 
 * se obtuvo la siguiente información: cantidad total de preguntas
 * que se le realizaron y la cantidad de preguntas que contestó correctamente. 
 * Se pide confeccionar un programa que ingrese los dos datos por teclado e informe 
 * el nivel del mismo según el porcentaje de respuestas correctas que ha obtenido, y sabiendo que:
    Nivel máximo:	Porcentaje>=90%.
	Nivel medio:	Porcentaje>=75% y <90%.
	Nivel regular:	Porcentaje>=50% y <75%.
	Fuera de nivel:	Porcentaje<50%.*/



int preguntas = 0;
int correctos  = 0;
int calculador = 100;
string linea=string.Empty;

Console.WriteLine("Entra Cantidad de preguntas");
linea = Console.ReadLine();
preguntas = Convert.ToInt32(linea);

Console.WriteLine("Entrar Cantidad de Respuestas Correctas");
linea = Console.ReadLine();
correctos = Convert.ToInt32(linea);

int porcentaje = (correctos * calculador)/ preguntas ;
//Console.WriteLine("" + porcentaje);
if (porcentaje >= 90)
{
	Console.WriteLine("El postulante es de Nivel Maximo su resultado es: "+  porcentaje +"%");
}
else  if (porcentaje >= 75 && porcentaje<90)
{
	Console.WriteLine("El postulante es de Nivel Medio su resultado es: " + porcentaje +"%");
}
if (porcentaje >= 50 && porcentaje < 75)
{
    Console.WriteLine("El postulante es de Nivel Regular su resultado es: " + porcentaje + "%");
}
if (porcentaje < 50 )
{
    Console.WriteLine("El postulante se encuentra fuera de Nivel Regular su resultado es: " + porcentaje + "%");
}