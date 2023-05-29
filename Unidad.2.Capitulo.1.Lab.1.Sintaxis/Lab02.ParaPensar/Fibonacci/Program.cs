Console.WriteLine("Serie de Fibonacci");
Console.WriteLine();
Console.Write("Ingrese el numero: ");
int num = Convert.ToInt32(Console.ReadLine());
while (num < 2)
{
    Console.Write("Ingrese un numero mayor a 1: ");
    num = Convert.ToInt32(Console.ReadLine());
}


static int fibonacci(int num)
{
    int[] nums = new int[num];

    nums[0] = 0;
    nums[1] = 1;
    int total = 1;

    for (int i = 2; i < num; i++)
    {
        nums[i] = nums[i - 1] + nums[i - 2];
        total += nums[i];
    }

    return total;
}

Console.WriteLine();
Console.WriteLine($"La suma de los primeros {num} terminos de la serie de Fibonacci es {fibonacci(num)}");
Console.ReadKey();