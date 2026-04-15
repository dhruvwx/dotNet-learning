using _31HomeWork;


List<PersonModel> people = new List<PersonModel>();
string firstName, lastName;
//List<AddressModel> addresses = new();
string houseName, city;
string pincode;
int pin;
bool valid;

do
{
    Console.Write("Enter ur first name or type exit to leave:  ");
    firstName = Console.ReadLine();

    if (firstName.ToLower() == "exit")
    {
        break;
    }

    Console.Write("Enter ur last name:  ");
    lastName = Console.ReadLine();

    Console.Write("Enter your house name :   ");
    houseName = Console.ReadLine();

    Console.Write("Enter your city :   ");
    city = Console.ReadLine();

    Console.Write("Enter your pincode :   ");
    pincode = Console.ReadLine();
    valid = int.TryParse(pincode, out pin);
    while (!valid)
    {
        Console.Write("enter correct pincode:  ");
        Console.Write("Enter your pincode :   ");
        pincode = Console.ReadLine();
        valid = int.TryParse(pincode, out pin);
    }


    PersonModel person = new PersonModel();
    person.FirstName = firstName;
    person.LastName = lastName;

    //AddressModel adress = new();
    person.Address = new AddressModel();
    person.Address.HouseName = houseName;
    person.Address.City = city;
    person.Address.Pincode = pin;
    people.Add(person);

    //addresses.Add(adress);

} while (true);//firstName.ToLower() != "exit");

foreach (var p in people)
{
    Console.WriteLine($"hi {p.FirstName} {p.LastName} ,Your address is: {p.Address.HouseName} {p.Address.City} {p.Address.Pincode}");
}




