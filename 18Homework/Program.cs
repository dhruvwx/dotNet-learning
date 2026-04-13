

//Create an array of 3 names. Ask the user which number to select. When the user gives you a number, return that name. Make sure to check for invalid numbers.


string[] names = new string[] { "dhruv", "indra", "tim" };

Console.WriteLine("select a value form 0 to 2 , where\n0 = dhruv \n1 = indra \n2 = tim:  ");
string entre = Console.ReadLine();
int value;
bool val = int.TryParse(entre, out value);


while (!val || value < 0 || value > 2)
{
    Console.WriteLine("enter correct value");
    Console.WriteLine("select a value form 0 to 2 , where\n0 = dhruv \n1 = indra \n2 = tim:  ");
    entre = Console.ReadLine();
    val = int.TryParse(entre, out value);
}
Console.WriteLine($"your selected name is {names[value]}");

//while (val)
//{
//    if (value >= 0 && value < 3)
//    {
//        Console.WriteLine($"your selected name is {names[value]}");
//        return;
//    }
//    else
//    {
//        Console.WriteLine("enter correct value");
//        Console.WriteLine("select a value form 0 to 2 , where\n0 = dhruv \n1 = indra \n2 = tim:  ");
//        entre = Console.ReadLine();
//        val = int.TryParse(entre, out value);
//    }
//}


//if (val == false)
//{
//    Console.WriteLine("enter valid number");
//    Console.WriteLine("select a value form 0 to 2 , where\n0 = dhruv \n1 = indra \n2 = tim:  ");
//    entre = Console.ReadLine();
//    val = int.TryParse(entre, out value);
//}
//else
//{
//    while ()
//    {
//        if (val == false)
//        {
//            Console.WriteLine("enter valid number");
//        }
//        else
//        {
//            Console.WriteLine($"your selected name is {names[value]}");
//        }
//    }
//}




