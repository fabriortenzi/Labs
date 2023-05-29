Console.Write("Ingrese un numero de filas: ");
int filas = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

while (filas <= 0)
{
    Console.Write("Ingrese un numero mayor a 0: ");
    filas = Convert.ToInt32(Console.ReadLine());
}

// Variable para llevar la cuenta de cuantos asteriscos imprimir por fila
int ast = 1;

for (int i = filas - 1; i >= 0; i--)
{
    for (int j = 0; j < i; j++)
    {
        Console.Write(' ');
    }
    for (int k = 0; k < ast; k++)
    {
        Console.Write('*');
    }
    // La cantidad de asteriscos se incrementa en 2 por cada fila
    ast += 2;
    for (int m = 0; m < i; m++)
    {
        Console.Write(' ');
    }
    Console.WriteLine();
}

Console.WriteLine();
Console.ReadKey();
