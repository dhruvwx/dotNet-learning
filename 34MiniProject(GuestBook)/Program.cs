//capture info about each guest : 1stName, LastName, age ,msg to host , then loop through each guest and priint info.

using _GuestBook;
//GuestBook people = new GuestBook();
List<GuestBook> guests = new();

do
{
    GuestBook person = new GuestBook();//comes inside loop coz getting ovewritten


    Console.Write("enter your first name or type stop to exit:   ");
    // person.FirstName = Console.ReadLine(); -- wrong coz assigning before checking.
   string name = Console.ReadLine();
    if (name.ToLower() == "stop")
    {
        break;
    }
    person.FirstName = name;


    //Console.Write("enter your surname:  ");
    person.LastName = Helper.GetInfo("Enter your surname");


    Console.Write("enter your age:  ");
    string ageNo = Console.ReadLine();
    bool valid = int.TryParse(ageNo, out int age);
    while (valid == false)
    {
        Console.Write("enter your correct age:  ");
        ageNo = Console.ReadLine();
        valid = int.TryParse(ageNo, out age);
    }
    ;
    person.Age = age;


    //Console.Write("Give your message:  ");
    person.Msg = Helper.GetInfo("Give your Message");



    guests.Add(person);
} while (true);



foreach (GuestBook guest in guests)
{
    Console.WriteLine(guest.FullDetails);
}

public static class Helper
{
    public static string GetInfo(string msg)
    {
        Console.WriteLine(msg);
        string info = Console.ReadLine();
        return info;

    }
}
