

string firstName = string.Empty;
string lastName = string.Empty;
string fileLoc = string.Empty;

firstName = "dhruv";
lastName = "sharma";
//fileLoc = "c:\\c#\\project";
//USE '\' WHEN USING SPL CHAR ----ORRRR--- use @ but spl char wont work
fileLoc = @"c:\c#\project";
 


Console.WriteLine(firstName + lastName + " "+fileLoc);

//string interpolation (mix of both)
Console.WriteLine(@$"NO SPACE\-{firstName} -SPACE- {lastName} {fileLoc}");
