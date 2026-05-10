using Microsoft.Extensions.Configuration; //installed in nuget package in dependency -- Microsoft.Extensions.Configuration.JSON


using DataAccessLibrary;
using DataAccessLibrary.Model;
using static ProgramClass;


SQLCrud sql = new SQLCrud(GetConnectionString());
ReadAllContacts(sql);





public class ProgramClass
{
    public static string GetConnectionString(string connectionStringName = "Default")
    {
        string output = "";
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json");

        var config = builder.Build();
        output = config.GetConnectionString(connectionStringName); 

        return output;

    }

    public static void ReadAllContacts(SQLCrud sql)
    {
        var rows = sql.GetAllContacts();

        foreach(var row in rows)
        {
            Console.WriteLine($"{row.Id}: {row.FirstName} {row.LastName}");
        }
    }
}

