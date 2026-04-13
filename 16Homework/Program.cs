


Console.WriteLine("enter name:  ");
string? name = Console.ReadLine();  

while (name?.ToLower() != "exit")
{

   
    if (name?.ToLower() == "tim")
    {
        Console.WriteLine($"welcome professor {name} , please type exit to leave");
    }
    else
    {
        Console.WriteLine($"welcome student  {name} , please type exit to leave");
    }
    Console.WriteLine("enter name:  ");
    name = Console.ReadLine();

}
