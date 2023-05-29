Console.Write("Ingrese un numero: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 2)
{
    Console.Write("Ingrese un numero mayor a 2: ");
    n = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine();

int ant = 2;
for (int i = 2; i <= n; i++)
{
    if (esPrimo(i))
    {
        if (ant + 2 == i)
        { Console.WriteLine($"Los numeros {ant} y {i} son primos gemelos"); }
        ant = i;
    }
}

Console.WriteLine();
Console.ReadKey();

static bool esPrimo(int num)
{
    for (int i = 2; i < num; i++)
    {
        if (num % i == 0)
        { return false; }
    }
    return true;
}