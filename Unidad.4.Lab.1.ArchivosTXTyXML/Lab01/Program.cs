using System.IO;

FileStream lector1 = new FileStream("agenda.txt", FileMode.Open, FileAccess.Read, FileShare.Read);
while (lector1.Length > lector1.Position)
{
    Console.Write((char) lector1.ReadByte()); 
}
lector1.Close();
Console.ReadKey();
Console.WriteLine();


// Con StreamReader

escribir();
leer();
Console.ReadKey();

static void leer()
{
    StreamReader lector2 = File.OpenText("agenda.txt");
    string? linea;
    Console.WriteLine("Nombre\tApellido\te-mail\t\t\tTelefono");
    do
    {
        linea = lector2.ReadLine();
        if (linea != null)
        {
            string[] valores = linea.Split(';');
            Console.WriteLine($"{valores[0]}\t{valores[1]}\t{valores[2]}\t{valores[3]}");
        }
    } while (linea != null);
    lector2.Close();
}

static void escribir()
{
    StreamWriter escritor = File.AppendText("agenda.txt");
    Console.WriteLine("Ingrese nuevos contactos");
    string? rta = "s";
    while (rta == "s")
    {
        Console.Write("Ingrese nombre: ");
        string? nombre = Console.ReadLine();
        Console.WriteLine();
        Console.Write("Ingrese apellido: ");
        string? apellido = Console.ReadLine();
        Console.WriteLine();
        Console.Write("Ingrese e-mail: ");
        string? email = Console.ReadLine();
        Console.WriteLine();
        Console.Write("Ingrese telefono: ");
        string? telefono = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine();

        escritor.WriteLine(nombre + ";" + apellido + ";" + email + ";" + telefono);
        Console.Write("Desea agregar otro contacto? [s/n] ");
        rta = Console.ReadLine();
    }
    escritor.Close();
}
