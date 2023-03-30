using System.Runtime.CompilerServices;

Console.WriteLine("Switch Case example");


int day = 15%7;
switch (day)
{
    case 0:
        Console.WriteLine("Friday");
        break;
    case 1:
        Console.WriteLine("Saturday");
        break;
    case 2:
        Console.WriteLine("Sunday");
        break;
    case 3:
        Console.WriteLine("Monday");
        break;
    case 4:
        Console.WriteLine("Tuesday");
        break;
    case 5:
        Console.WriteLine("Wednesday");
        break;
    case 6:
        Console.WriteLine("Thursday");
        break;
    default:
        Console.WriteLine("Input number is Invalid for day finding");
        break;
}

