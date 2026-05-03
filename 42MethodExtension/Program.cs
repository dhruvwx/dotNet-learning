




Person person = new();
person.LastName("Sharma").FirstName("Dhruv").Age(19);

Console.WriteLine(person.FirstName +" "+ person.LastName + " is " + person.Age + " years old");

public class Person
{
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public int Age { get; set; }
}


public static class ExtensionMethod
{
    public static Person Age(this Person p ,int age)
    {
        p.Age = age;
        return p;
    }

    public static Person FirstName(this Person p , string fName)
    {
        p.FirstName = fName;
        return p;
    }

    public static Person LastName(this Person p , string lName)
    {
        p.LastName = lName;
        return p;
    }
}