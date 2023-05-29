Console.WriteLine("Ingrese un texto");
string inputTexto = Console.ReadLine();

if (inputTexto == null)
{
    Console.WriteLine("No se ha ingresado ningun texto");
    return;
}

Console.WriteLine();
Console.WriteLine("Menu de Opciones");
Console.WriteLine("1- Mostrar la frase ingresada en Mayusculas");
Console.WriteLine("2- Mostrar la frase ingresada en Minusculas");
Console.WriteLine("3- Mostrar la cantidad de caracteres que tiene");
Console.WriteLine();

Console.Write("Opcion: ");
ConsoleKeyInfo opcion = Console.ReadKey();

while (opcion.Key != ConsoleKey.D1 && opcion.Key != ConsoleKey.D2 && opcion.Key != ConsoleKey.D3)
{
    Console.WriteLine();
    Console.Write("Vuelva a ingresar la opcion: ");
    opcion = Console.ReadKey();
}

Console.WriteLine();
Console.WriteLine();
switch (opcion.Key)
{
    case ConsoleKey.D1:
        Console.WriteLine(inputTexto.ToUpper());
        break;
    case ConsoleKey.D2:
        Console.WriteLine(inputTexto.ToLower());
        break;
    case ConsoleKey.D3:
        Console.WriteLine(inputTexto.Length);
        break;
}
Console.ReadKey();