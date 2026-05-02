

EmployeeModel employ = new EmployeeModel("a", "b ", "c");
Console.WriteLine(employ.LastName);

public class EmployeeModel
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Mail { get; set; }

    public EmployeeModel(string firstname , string lastname , string mail)
    {
        FirstName = firstname;
        LastName = lastname;
        Mail = mail;
    }
    public EmployeeModel(string firstname , string lastname)
    {
        FirstName = firstname;
        LastName = lastname;
    }
}