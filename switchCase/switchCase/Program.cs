// See https://aka.ms/new-console-template for more information
Console.WriteLine("Trafik ışığını giriniz: \nKIRMIZI\nSARI\nYESİL");
string renk = Console.ReadLine();

if (renk == "KIRMIZI")
{
    Console.WriteLine("DUR!");
}
else if (renk == "SARI")
{
    Console.WriteLine("DİKKAT!");
}
else if (renk == "YESİL")
{
    Console.WriteLine("GEÇ");
}
else
{
    Console.WriteLine("????????");
}

switch (renk)
{
    case "KIRMIZI":
        Console.WriteLine("DUR");
        break;
    case "SARI":
        Console.WriteLine("DİKKAT");
        break;
    case "YESİL":
        Console.WriteLine("GEÇ");
        break;
    default:
        Console.WriteLine("????????");
        break;
}

switch (DateTime.Now.DayOfWeek)
{
    case DayOfWeek.Sunday:
        break;
    case DayOfWeek.Monday:
        break;
    case DayOfWeek.Tuesday:
        break;
    case DayOfWeek.Wednesday:
        break;
    case DayOfWeek.Thursday:
        break;
    case DayOfWeek.Friday:
        break;
    case DayOfWeek.Saturday:
        break;
    default:
        break;
}



