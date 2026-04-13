


List<string> names = new();
Console.WriteLine("enter name:  ");
string name = Console.ReadLine();


do
{
    if (name != null && name != "exit" && name != "")
    {
        names.Add(name);
    }
    Console.WriteLine("enter name:  ");
    name = Console.ReadLine();

} while (name != null && name != "exit" && name != "");

foreach (var user in names)
{
    Console.WriteLine($"helllo {user}");
}
