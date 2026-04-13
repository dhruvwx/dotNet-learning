using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24Methods
{

    //Tuple allows to return two values as parameter/////////////
    public static class TupleMethod
    {
        public static (string , string ) FullName()
        {
            Console.Write("enter your first name :    ");
            string firstName = Console.ReadLine();

            Console.Write("enter your last name :    ");
            string lastName = Console.ReadLine();

            return (firstName, lastName);

        }
    }
}
