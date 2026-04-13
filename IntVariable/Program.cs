
/////// INT VARIABLE ///// (int 16 ,32[2 billion =/-] ,64)
Console.WriteLine("INT VARIABLE");
int age = 0;
age = 70;
age += 10;

//implicitly converting into string
Console.WriteLine(age);

//explicitly converting into string
Console.WriteLine(age.ToString());


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~//
//////// DOUBLE VARIABLE ////////// (doubles can have decimal values with whole numbers )
Console.WriteLine();
Console.WriteLine("DOUBLE VARIABLE");
double averageAge;
double val = 2.3453647313631668663646666;
averageAge = (5 + 7 + 3) / 2;
//here the numbers are whole so it assumes it as int and gives 7.
Console.WriteLine(averageAge.ToString());
Console.WriteLine(val);

double avgAge;
avgAge = (5 + 7 + 3) / 2.0;
Console.WriteLine($"{avgAge} - Here 2.0 makes everything double so answers in double");




//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~//
/////////// DECIMAL VARAIBLE ////////// (precise upto 28 values)
///////////used with money related stuff only not used with multiply divide coz too costly 
decimal value;
value = 2.3453647313631668663646666M;
//M IS WRITTEN IN END TO TELL ITS DECIMAL//
Console.WriteLine(value);
