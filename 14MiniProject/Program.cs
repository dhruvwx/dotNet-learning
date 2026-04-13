

Console.Write("Enter your name:   ");
string? name = Console.ReadLine();
Console.Write("enter your age:  ");
string? userAge = Console.ReadLine();

string formatedName;
bool valid = int.TryParse(userAge, out int age);


if ((name?.ToLower() == "bob" ||
        name?.ToLower() == "sue"))
{
    formatedName = "PROFESSOR " + name;
}
else
{
    formatedName = name;
}
if (valid)
{
    if (age < 21)
    {
        Console.WriteLine($"wait for {21 - age} years , {formatedName}");
    }
    else
    {
        Console.WriteLine($"hi {formatedName} ");
    }
}
else
{
    Console.WriteLine("enter valid age");
}


