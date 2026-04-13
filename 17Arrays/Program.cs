


string[] names = new string[3];

names[0] = "dhruv";
names[1] = "indra";
names[2] = "raja";
Console.Write(names[1]);
Console.WriteLine($" is madly lovingly sexually obsessed with {names[0]} who is a {names[2]}");

names[2] = "lord";
Console.WriteLine($"{names[0]} is her {names[2]}");



//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~//
// coverting CSV comma separated value file into array
string data = "1,2,3,4,5";
string[] values = data.Split(',');

Console.WriteLine(values[values.Length - 2]);


//~~~DIRECTLY PUTTING VALUES IN ARRAY INSTEAD OF GIVING LENGTH~~~~~~~~~~~~~~~~~~~//
int[] digits = new int[] { 1, 2, 3, 4, 5 };
