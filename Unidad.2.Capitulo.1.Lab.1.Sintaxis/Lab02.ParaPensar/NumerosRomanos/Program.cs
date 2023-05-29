Console.Write("Ingrese un numero: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

while (num < 1)
{
    Console.Write("Ingrese un numero mayor a 1: ");
    num = Convert.ToInt32(Console.ReadLine());
}

int[] numerosDec = { 1, 4, 5, 9, 10, 40, 50, 90, 100, 400, 500, 900, 1000 };
string[] numerosRom = { "I", "IV", "V", "IX", "X", "XL", "L", "XC", "C", "CD", "D", "CM", "M"};
string numeroRom = "";

while (num != 0)
{
    for (int i = numerosDec.Length - 1; i >= 0; i--)
    {
        if (num >= numerosDec[i])
        {
            numeroRom = String.Concat(numeroRom, numerosRom[i]);
            num = num - numerosDec[i];
            break;
        }
    }
}

Console.WriteLine(numeroRom);
Console.ReadKey();