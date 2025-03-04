﻿using Lab04;

Contactos contactos = new ContactosMySQLConDataAdapter();
contactos.listar();
menu(contactos);

static void menu(Contactos contactos)
{
    string rta = "";
    do
    {
        Console.WriteLine("1 - Listar");
        Console.WriteLine("2 - Agregar");
        Console.WriteLine("3 - Modificar");
        Console.WriteLine("4 - Eliminar");
        Console.WriteLine("5 - Guardar Cambios");
        Console.WriteLine("6 - Salir");
        rta = Console.ReadLine();
        switch (rta)
        {
            case "1":
                contactos.listar();
                break;
            case "2":
                contactos.nuevaFila();
                break;
            case "3":
                contactos.editarFila();
                break;
            case "4":
                contactos.eliminarFila();
                break;
            case "5":
                contactos.aplicaCambios();
                break;
            default:
                break;
        }
    } while (rta != "6");
}
