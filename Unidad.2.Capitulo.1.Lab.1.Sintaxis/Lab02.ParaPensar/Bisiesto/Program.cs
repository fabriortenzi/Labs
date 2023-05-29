Console.Write("Ingrese el año: ");
int año = Convert.ToInt32(Console.ReadLine());

bool bisiesto;

if (año % 100 == 0)
{
    if (año % 400 == 0)
    { bisiesto = true; }
    else
    { bisiesto = false; }
}
else if (año % 4 == 0)
{ bisiesto = true; }
else 
{ bisiesto = false; }

if (bisiesto) 
{ Console.WriteLine($"El año {año} es bisiesto"); }
else 
{ Console.WriteLine($"El año {año} no es bisiesto"); }
Console.ReadKey();

