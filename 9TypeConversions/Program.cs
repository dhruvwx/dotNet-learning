

Console.Write("age = ");
string? age = Console.ReadLine();

int trueAge;
bool valid = int.TryParse(age, out trueAge);

//int newAge = int.Parse(age);

Console.WriteLine($" {valid} {trueAge + 5}");



double convert = trueAge;
decimal casting = (decimal)convert;
