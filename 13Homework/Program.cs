


Console.Write("enter name : ");
string? name = Console.ReadLine();

if (name.ToLower().Trim() == "tim" || name.ToLower().Trim() == "timithy")
{
    Console.WriteLine("welcome professor");
}
else
{
    Console.WriteLine("hi student");
}

switch (name.ToUpper())
{
    case "TIMITHY":
    case "TIM":
        Console.WriteLine("welcome professor");
        break;
    default:
        Console.WriteLine("hi student");
        break;
}
