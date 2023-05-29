string claveCorrecta = "#rJ";
int intentos = 0;
string claveIngresada = "";

while (intentos < 4)
{
    Console.Write("Ingrese la clave: ");
    claveIngresada = Console.ReadLine();
    if (claveIngresada == claveCorrecta)
    { break; }
    intentos++;
}

Console.WriteLine();
if (claveIngresada == claveCorrecta)
{ Console.WriteLine("Clave correcta ingresada"); }
else 
{ Console.WriteLine("Maximo de intentos permitidos (4)"); }
Console.ReadKey();