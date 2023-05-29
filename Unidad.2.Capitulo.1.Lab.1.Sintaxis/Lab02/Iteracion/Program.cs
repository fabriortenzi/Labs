int cantIteraciones = 5;
string[] cadenas = new string[cantIteraciones];

Console.WriteLine($"Ingrese {cantIteraciones} cadenas");
Console.WriteLine();
for (int i = 0; i < cadenas.Length; i++)
{
    cadenas[i] = Console.ReadLine();
}

Console.WriteLine();
Console.WriteLine("Cadenas en orden inverso: ");
Console.WriteLine();
for (int i = cantIteraciones - 1 ; i >= 0; i--)
{
    Console.WriteLine(cadenas[i]);
}
Console.ReadKey();