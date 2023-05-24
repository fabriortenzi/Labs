using AdivineElNumero;

ConsoleKeyInfo opcion;

do
{
    Console.Clear();
    AdivineElNumero.Program.Main();
    Console.WriteLine();
    do
    {
        Console.Write("Desea seguir jugando? [s/n] ");
        opcion = Console.ReadKey();
        Console.WriteLine();
    } while (opcion.Key != ConsoleKey.N && opcion.Key != ConsoleKey.S);
} while (opcion.Key != ConsoleKey.N);

Console.WriteLine();
Console.WriteLine("Fin del Juego!");
Console.WriteLine($"Tu mayor puntaje fue {Juego.Record}");