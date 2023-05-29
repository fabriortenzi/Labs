Console.WriteLine("Numeros pares entre 1 y 100");
Console.WriteLine();

for (int i = 1; i <= 100; i++)
{
    if (i % 2 == 0)
    { Console.Write($"{i} "); }
}
Console.WriteLine();
Console.ReadKey();