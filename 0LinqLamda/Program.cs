using _0LinqLamda;
using System.Linq;
using System.Net.Mail;




LambdaTests();
LinqTests();


static void LambdaTests() //--Uses Arrow Functions.
{
    var data = SampleData.GetContactsData();

    /* .WHERE returns bool
    =================================================================*/
    //var results = data.Where(x => x.Addresses.Count > 1);
    //foreach(var item in results)
    //{
    //    Console.WriteLine($"{item.FirstName} {item.LastName}");
    //}


    /*  .SELECT returns string
    =================================================================*/
    //var results = data.Select(x => x.FirstName);
    //foreach (var item in results)
    //{
    //    Console.WriteLine(item);
    //}


    /*   .TAKE()  & .SKIP
    =================================================================*/
    //var results = data.Skip(2).Take(3);
    //foreach (var item in results)
    //{
    //    Console.WriteLine(item.FirstName);
    //}



    /*   .OrderBY & .OrderByDescending
    =================================================================*/
    //var results = data.OrderByDescending(x => x.Id);  
    //foreach (var item in results)
    //{
    //    Console.WriteLine(item.FirstName +" "+ item.Id);
    //}
}


static void LinqTests()
{
    var contactData = SampleData.GetContactsData();
    var addressData = SampleData.GetAddressModel();

    //var result = ( //sql like statement
    //                from c in contactData
    //                where c.FirstName == "Dhruv" || c.FirstName == "Raja"
    //                select c
    //             );
    //foreach (var item in result)
    //{
    //    Console.WriteLine(item.LastName);
    //}



    //var result = (from c in contactData
    //              join a in addressData
    //              on c.Id equals a.Id
    //              select new { c.FirstName, a.City });
    //foreach (var item in result)
    //{
    //    Console.WriteLine(item.FirstName + " Lives in " + item.City);
    //}



    var result = (from c in contactData
                  select new { c.FirstName, c.LastName, Address = addressData.Where(x => c.Addresses.Contains(x.Id)) }
                  );
    foreach (var item in result)
    {
        Console.WriteLine($"{item.FirstName} {item.LastName} {item.Address.Count()}");
    }
}


