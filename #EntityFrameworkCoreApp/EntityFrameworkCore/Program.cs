using EntityFrameworkCore.DataAccess;
using EntityFrameworkCore.Model;
using Microsoft.EntityFrameworkCore;


//using the models that are like tables 


//CreateDhruv();
//ReadAll();

//CreateIndra();

//ReadById(10);          // ==dhruv
//ReadById(12);          //==indra

//UpdateSurName(12, "Rana");
//UpdateSurName(13, "Magar");
//ReadById(13);
//UpdateSurName(12, "Sharma");
//ReadById(12);

//RemovePhone(12, "555-2121");    //== it removed the phnNo and put null there.

//DeleteUser(13);




//creating a person
static void CreateDhruv()
{
    Contact c = new()
    {
        FirstName = "Dhruvv",
        LastName = "Sharma",
    };
    //setup lists collections child objects outside and put simple data inside == using add coz its a list
    c.Emails.Add(new Email { EmailAddress = "yesdhruv@gmail.com" });
    c.Emails.Add(new Email { EmailAddress = "dhruvmail@yahoo.com" });
    c.Phones.Add(new Phone { PhoneNumber = "555-2121" });
    c.Phones.Add(new Phone { PhoneNumber = "555-0101" });


    using (ContactContext db = new()) //this puts into DbSet creating the data
    {
        db.Contacts.Add(c);
        db.SaveChanges();
    }
}
static void CreateIndra()
{
    Contact c = new()
    {
        FirstName = "Indra",
        LastName = "Sharma",
    };
    //setup lists collections child objects outside and put simple data inside == using add coz its a list
    c.Emails.Add(new Email { EmailAddress = "indrav@gmail.com" });
    c.Emails.Add(new Email { EmailAddress = "sharmamail@yahoo.com" });
    c.Phones.Add(new Phone { PhoneNumber = "555-2121" });
    c.Phones.Add(new Phone { PhoneNumber = "555-3131" });


    using (ContactContext db = new()) //this puts into DbSet creating the data
    {
        db.Contacts.Add(c);
        db.SaveChanges();
    }
}

static void ReadAll()
{
    using(var db = new ContactContext())
    {
        var records = db.Contacts.Include(p => p.Phones).ToList();
        foreach(var c in records)
        {
            Console.WriteLine($"{c.FirstName}");
        }
    }
}

static void ReadById(int id)
{
    using(var db = new ContactContext())
    {
        var user = db.Contacts.Where(c => c.Id == id).First(); //it gives a set of row where the id matches so to get the first row we use first()
        Console.WriteLine($"{user.FirstName} {user.LastName}");
    }
}

static void UpdateSurName(int id , string lastname)
{
    using(var db = new ContactContext())
    {
        var user = db.Contacts.Where(c => c.Id == id).First();
        user.LastName = lastname;
        db.SaveChanges();
    }
}

static void RemovePhone(int id , string phoneNo)
{
    using(var db = new ContactContext())
    {
        var user = db.Contacts
            .Include(p => p.Phones)
            .Where(c => c.Id==id).First();

        user.Phones.RemoveAll(p => p.PhoneNumber==phoneNo);
        db.SaveChanges();
    }
}

static void DeleteUser(int id)
{
    using(var db = new ContactContext())
    {
        var user = db.Contacts
            .Include(p => p.Phones)
            .Include(e => e.Emails)
            .Where(c => c.Id == id).First();
        db.Contacts.Remove(user);
        db.SaveChanges();
    }
}


