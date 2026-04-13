



Dictionary<int, string> employee = new Dictionary<int, string>();

employee[01] = "dhruv";
employee[02] = "indra";
employee[03] = "raja";
employee[04] = "rani";

Console.Write("enter your id:  ");
string? user = Console.ReadLine();
bool valid = int.TryParse(user, out int id);

while (valid == false || !employee.ContainsKey(id))
{
    if (!employee.ContainsKey(id))
    {
        Console.WriteLine("enter correct id");
        user = Console.ReadLine();
        valid = int.TryParse(user, out id);
    }
}
Console.WriteLine($"your name is {employee[id]}");