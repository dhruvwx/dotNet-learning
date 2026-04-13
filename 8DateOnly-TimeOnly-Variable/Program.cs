
//~~~~~~DATE ONLY VARIABLE~~~~~~~~~~///
Console.WriteLine("DATE ONLY");
DateOnly today = DateOnly.Parse("15/11/2002");
Console.WriteLine(today.ToString("dd,MMMM,yyyy"));
Console.WriteLine($"System format - {today}");

DateTime choice = DateTime.Parse("15/11/2002");
Console.WriteLine(choice.Date);

DateOnly now = DateOnly.FromDateTime(DateTime.Now);
Console.WriteLine(now);



//~~~~~~~~~TIME ONLY VARIABLE~~~~~~~~~~////
Console.WriteLine();
Console.WriteLine("TIME ONLY");
TimeOnly value = TimeOnly.Parse("8pm");
Console.WriteLine(value.ToString("hh:mm,tt"));

TimeOnly present = TimeOnly.FromDateTime(DateTime.Now);
Console.WriteLine(present);

