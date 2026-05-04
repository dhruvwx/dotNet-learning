using _44Generics;

PrintItemModel.PrintItem("hello");
PrintItemModel.PrintItem(1234);
PrintItemModel.PrintItem(true);

////////////////////////////////////////////////////////////////

Box<string> strValue = new();
strValue.Value = "Dhruv";
strValue.Show();

////////////////////////////////////////////////////////////////

Box<int> intValue = new();
intValue.Value = 40;
intValue.Show();

//////////////////////////////////////////////////////////////////

UseGeneric<User> user = new UseGeneric<User>();

user.Add(new User { Id = 1, Name = "Dhruv" });
user.Add(new User { Id = 2, Name = "Indra" });

user.PrintId();