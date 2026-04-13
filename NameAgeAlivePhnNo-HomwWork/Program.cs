

string? name = string.Empty;
Console.Write("enter user name:  ");
name = Console.ReadLine();
Console.WriteLine(name);

int age;
Console.Write("Enter age:  ");
age = int.Parse(Console.ReadLine());
Console.WriteLine(age);

bool alive = true;
Console.WriteLine($"Alive {alive}");
alive = !alive; 
Console.WriteLine($"dead {alive}");
//Console.WriteLine($"dead {!alive}");

String? phnNO = string.Empty;
Console.WriteLine("enter phnNO:  ");
phnNO = Console.ReadLine();
Console.WriteLine(phnNO);