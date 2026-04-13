


//NEVER USE BOTH TOGETHER AND TRY PARSE WILL ONLT TAKE STRING AND PARSE IT WONT TAKE INT VALUE.
//TRY PARSE IS USED ONLY WHEN U NEED A BOOLEAN SO TILL THEN USE PARSE

Console.Write("Enter your age : ");
int age = int.Parse(Console.ReadLine());

//int.TryParse(Console.ReadLine(), out int yourage);

Console.WriteLine($"after 25 yers you will be : {age + 25} years old");
Console.WriteLine($"before 25 yers you were : {age - 25} years old");
