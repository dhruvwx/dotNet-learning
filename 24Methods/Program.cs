using _24Methods;


Console.Write("enter your name:   ");
string? name = Console.ReadLine();
SampleMethod.SayHi(name);

double[] number = new double[] { 10, 23, 17, 52, 78 };
MathShortcut.AddAll(number);

double sum = MathShortcut.Add(2, 5);
Console.WriteLine($"sum is {sum}");


//(string, string) fullName = TupleMethod.FullName();
var fullName = TupleMethod.FullName();
Console.WriteLine($"your full name is {fullName.Item1} {fullName.Item2}");