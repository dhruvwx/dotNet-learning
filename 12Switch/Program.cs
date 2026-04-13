

Console.Write("enter ur salary:  ");
double? salary = double.Parse(Console.ReadLine());

switch (salary)
{
    case 25000:
        Console.WriteLine("poor");
        break;

    case 26000 or <27000:
        Console.WriteLine("decent");
        break;

    case >=27000:
        Console.WriteLine("rich");
        break;

    default:
        Console.WriteLine("jobless");
        break;

}

