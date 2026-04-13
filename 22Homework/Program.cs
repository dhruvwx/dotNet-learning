

Console.WriteLine("enter a comma separated list of names make shure no space around commas:  ");
string? firstNames = Console.ReadLine();

string[] names = firstNames .Split(',');

for(int i=0; i<names.Length; i++)
{
    Console.WriteLine($"hello {names[i]}");
}

