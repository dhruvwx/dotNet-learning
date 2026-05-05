using _46MiniProj;


List<PersonModel> people = new List<PersonModel>
{
    new PersonModel { FirstName = "fuck", LastName = "Sharma", Email = "yesdhruv@gmail.com" },
    new PersonModel { FirstName = "Indra", LastName = "Rana", Email = "yesindra@gmail.com" },
    new PersonModel { FirstName = "Raja", LastName = "Rani", Email = "yesrajarani@gmail.com" }
};

List<CarModel> cars = new List<CarModel>();
cars.Add(new CarModel { Company = "Toyota", Model = "Fortuner" });
cars.Add(new CarModel { Company = "Mercedes", Model = "S Class" }); //THIS ALSE SHOWS UP IN EVENT COZ S-CLASS HAS ASS.
cars.Add(new CarModel { Company = "Toyota", Model = "Defender" });


DataAccess<PersonModel> person = new DataAccess<PersonModel>();
person.AbuseCheck += person.Person_AbuseCheck;
person.SaveToCSV(people,@"S:\C#\46MiniProjCSV\people.csv");


DataAccess<CarModel> car = new DataAccess<CarModel>();
car.AbuseCheck += car.Car_AbuseCheck;
car.SaveToCSV(cars,@"S:\C#\46MiniProjCSV\cars.csv");