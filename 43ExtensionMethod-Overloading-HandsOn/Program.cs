


PersonModel person = new();

person.FirstName = "Enter your first name:  ".RequestString();
person.LastName = "Enter your last name:  ".RequestString();

person.Age = "what is your age balance:  ".RequestInt();
Console.WriteLine(person.Age);
person.Age = "what is your age balance:  ".RequestInt(false);
Console.WriteLine(person.Age);
person.Age = "what is your age balance:  ".RequestInt(true , 0,120);
Console.WriteLine(person.Age);




