using _37Inventory;


List < IRent > rentables = new();
List < IBuy > purchasables = new();

Vehicle vehicle = new();
vehicle.ProductName = "Mercedes";
vehicle.DealerFee = 10000;

Book book = new Book
{
    ProductName = "50Shades",
    PageNo = 120
};

var excavator = new Excavator {ProductName = "JCB" };

purchasables.Add(book);
purchasables.Add(vehicle);
rentables.Add(vehicle);
rentables.Add(excavator);


Console.Write("Do you want to rent or buy:  ");
string decision = Console.ReadLine();

if(decision.ToLower() == "rent")
{
    foreach(var rent in rentables)
    {
        Console.WriteLine($"Items to rent are: {rent.ProductName}");
        Console.Write("Do you want to rent this (y/n):  ");
        string renting = Console.ReadLine();
        if(renting == "y")
        {
            rent.Rent();
            Console.Write("Do you want to return this (y/n):  ");
            string returning = Console.ReadLine();
            if (returning == "y")
            {
                rent.ReturnItem();
            }
        }
        else
        {
            Console.WriteLine("not rented");
        }
        

    }
}
else
{
    foreach (var buy in purchasables)
    {
        Console.WriteLine($"Items to buy are: {buy.ProductName}");
        Console.Write("Do you want to buy this (y/n):  ");
        string buying = Console.ReadLine();
        if (buying == "y")
        {
            buy.Purchase();
        }
        else
        {
            Console.WriteLine("not bought");
        }

    }
}





