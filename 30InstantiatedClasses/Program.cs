using _30InstantiatedClasses;



//PeopleModel person = new PeopleModel();
//person.FirstName = "dhruv";

//PeopleModel person2 = new PeopleModel();
//person2.FirstName = "indra";

//Console.WriteLine($"{person.FirstName} - {person} + {person2.FirstName}");



List<PeopleModel> people = new();
string firstName = "";
string lastName = "";
do
{
    Console.Write("Enter your name (exit to stop):  ");
    firstName = Console.ReadLine();
    Console.Write("Enter your Surname:  ");
    lastName = Console.ReadLine();

    if (firstName != "exit")
    {
        PeopleModel person = new();
        person.FirstName = firstName;
        person.LastName = lastName;
        people.Add(person);
 
    }

} while (firstName != "exit");
foreach (var p in people)
{
    Console.WriteLine($"{p.FirstName} {p.LastName}");
}
