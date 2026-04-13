

List<string> rosterList = new List<string>();
Console.WriteLine("enter name to add to the list");
string list = Console.ReadLine();

while (list != null && list.ToLower() != "exit" && list != "")
{
    rosterList.Add(list);
    Console.WriteLine("Enter name to add to the list and just press enter or type exit to get count of the list");
    list = Console.ReadLine();
}
Console.WriteLine(rosterList.Count);

do
{
    if (list != null && list.ToLower() != "exit" && list != "")
    {
        rosterList.Add(list);
    }  
    Console.WriteLine("Enter name to add to the list and just press enter or type exit to get count of the list");
    list =Console.ReadLine();
}while(list!=null && list.ToLower() != "exit" && list !="");
Console.WriteLine(rosterList.Count);

