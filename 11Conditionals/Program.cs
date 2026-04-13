

Console.WriteLine("enter your name: ");
string? name = Console.ReadLine();

if (name.ToUpper() == "DHRUV")
//ToUpper() is used to make edge cases of user typing in anycase match the if condition
{
    Console.WriteLine("hello rajaji");
}
else
{
    Console.WriteLine($"hello {name}");
}
Console.WriteLine("CODE ENDED OF SIMPLE ifElse");


//////~~~~~~ADVANCE IF STATEMENTS~~~~~~~~~/////
Console.WriteLine("\nADVANCEE");
Console.WriteLine("lastName : ");
string? lastName = Console.ReadLine();
if (name.ToLower() == "dhruv" &&
    lastName.ToLower() == "sharma")
{
    Console.WriteLine("ap to malik aagyeeee.");
}
else if (name.ToLower() == "dhruv")
{
    Console.WriteLine("malik ka naam mat chura");
}
else if (lastName.ToLower() == "sharma")
{
    Console.WriteLine("malik ka surname mat chura");
}
else
{
    Console.WriteLine("abey kon h tu?");
}

//////Using Multiple ifs without else if//////
Console.WriteLine("\n\nmultiple ifs");
if (name.ToLower() == "dhruv")
{
    Console.WriteLine("good name");
}
if (lastName.ToLower() == "sharma")
{
    Console.WriteLine("good last name");
}
else
{
    Console.WriteLine("fudu name");
}

///////OPERATIONS///////
Console.Write("\n\ntell ur age:  ");
int? age = int.Parse(Console.ReadLine());

if (age < 20 || age > 60)
{
    Console.WriteLine("ur too young or too old");
}
else if ((age >= 20 && age <= 30) || age >= 50 && age <= 60)
{
    Console.WriteLine("enjjoy");
}
else
{
    Console.WriteLine("make money");
}
