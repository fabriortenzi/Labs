Console.Write("Ingrese un numero entero: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
Console.Write("Ingrese otro numero entero: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
Console.WriteLine($"El resultado de la suma de {num1} y {num2} es {num1 + num2}");
Console.ReadKey();