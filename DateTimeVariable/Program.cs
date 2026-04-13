
//NEEDED TO CultureInfo.InvariantCulture TO TELL THAT FOLLOW OUR FORMAT AND IGNORE SYSTEM
using System.Globalization;
Console.WriteLine("OUR FORMAT");
DateTime exactBirthday = DateTime.ParseExact("11/13/2004", "MM/dd/yyyy", CultureInfo.InvariantCulture);
Console.WriteLine(exactBirthday + " - OWN GIVEN FORMAT ");

Console.WriteLine();
Console.WriteLine("LIVE DATE TIME");
DateTime todayLocal = DateTime.Now;
DateTime todayGlobal = DateTime.UtcNow;
Console.WriteLine(todayLocal.ToString("LOACAL - dd,MM,yyyy,hh:mm tt, zzz"));
Console.WriteLine(todayGlobal.ToString("GLOBAL - dd,MM,yyyy,hh:mm tt, zzz"));

Console.WriteLine();
Console.WriteLine("our choice date".ToUpper());
//Parse used to tell our choice date
DateTime birthday = DateTime.Parse("13/11/2004");
Console.WriteLine(birthday.ToString("LOCAL - MMMM"));


