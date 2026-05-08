

using StandardClassLibrary;
using System.ComponentModel;
using System.Runtime.CompilerServices;

Numbers num = new Numbers()
{
    Num1 = 27,
    Num2 = 23,
};

string sum = CalcLibrary.Add(num);
string prod = CalcLibrary.Multiply(num);
Console.WriteLine(sum + " and " + prod);
