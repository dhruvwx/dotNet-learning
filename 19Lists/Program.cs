

//string[] name = new string[4];
List<string> names = new List<string>();
names.Add("dhruv");
names.Add("indra");
names.Add("raja");
names.Add("rani");

Console.WriteLine(names[names.Count-1]);

string data = "sharma,rana,ji,jii";
List<string> values = data.Split(',').ToList();
values.Add("hanji");

