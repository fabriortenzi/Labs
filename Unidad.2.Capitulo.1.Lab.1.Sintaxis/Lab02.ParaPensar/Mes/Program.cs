Console.Write("Ingrese nombre del mes: ");
string mes = Console.ReadLine();

Console.WriteLine();
Console.WriteLine(nroMes(mes));
Console.ReadKey();

static string nroMes(string mes)
{
    string mesMin = mes.ToLower();

    switch (mesMin)
    {
        case "enero":
            return "Enero 1";
            break;
        case "febrero":
            return "Febrero 2";
            break;
        case "marzo":
            return "Marzo 3";
            break;
        case "abril":
            return "Abril 4";
            break;
        case "mayo":
            return "Mayo 5";
            break;
        case "junio":
            return "Junio 6";
            break;
        case "julio":
            return "Julio 7";
            break;
        case "agosto":
            return "Agosto 8";
            break;
        case "septiembre":
            return "Septiembre 9";
            break;
        case "octubre":
            return "Octubre 10";
            break;
        case "noviembre":
            return "Noviembre 11";
            break;
        case "diciembre":
            return "Diciembre 12";
            break;
        default:
            return "El mes ingresado es invalido";
            break;
    }
}