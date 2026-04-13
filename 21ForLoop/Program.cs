

using System.Numerics;

for (int i = 0; i < 20; i += 2)
{
    Console.WriteLine(i);
}

/////////////////////////////////////////////////////////////////////////////////////

string data = "dhurv,indra,raja,rani";
List<string> names = data.Split(',').ToList();

for(int i=0; i < 4; i++)
{
    Console.WriteLine($"index of {names[i]} is {i}");
}

/////////////////////////////////////////////////////////////////////////////////////

List<Decimal> values = new();

values.Add(23.25M);
values.Add(16.75M);
values.Add(140M);
values.Add(60M);
decimal total=0;

for (int i = 0; i < values.Count; i++)
{
    total += values[i];
}
Console.WriteLine(total);
