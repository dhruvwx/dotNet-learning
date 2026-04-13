

bool valid;
int age;
do
{
	Console.WriteLine("enter ur age:  ");
	string? userAge = Console.ReadLine();

	valid = int.TryParse(userAge, out age);
	if (valid == false)
	{
        Console.WriteLine("invalid age");
	}

} while (valid == false);
Console.WriteLine(age); 