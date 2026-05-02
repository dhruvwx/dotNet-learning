

HourlyEmployee employee = new HourlyEmployee
{
    FirstName = "Dhruv",
    LastName = "Sharma",
    Email = "yesdhruv@gmail.com",
    Wage = 5000,
};
employee.Package(30);

Console.WriteLine(employee);  //only throws or prints value under ToString() of the base class



public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public override string ToString()
    {
        return $"{FirstName} {LastName}";
    }
}

public class HourlyEmployee : Person
{
    public decimal Wage { get; set; }
    public virtual decimal Package(int duration)
    {
        return Wage * duration;
    }

}

public class MonthlyEmplyee : HourlyEmployee
{
    public decimal MonthInHand { get; set; }
    public override decimal Package(int duration)
    {
        decimal overtime = base.Package(duration);

        return overtime + MonthInHand;
    }
   
}

