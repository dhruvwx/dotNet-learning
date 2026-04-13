using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace _26MiniProject2
{
    public static class GuestBook
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to Guest Book");
            Console.WriteLine("*************************************");
            Console.WriteLine();
        }

        public static string UserName()
        {
            Console.Write("Enter your party name:  ");
            string output = Console.ReadLine();
            return output;
        }

        public static int Size()
        {
            bool valid;
            int output;
            do
            {
                Console.WriteLine();
                Console.Write("enter number of member:  ");
                string noOfMember = Console.ReadLine();
                valid = int.TryParse(noOfMember, out output);
            } while (valid == false);
            return output;
        }

        public static bool Continue()
        {

            Console.WriteLine();
            Console.Write("Are there more guests(yes/no)  ");
            string askAgain = Console.ReadLine();
            bool valid = askAgain == "yes";
            return valid;
        }

        public static (List<string> guests, int number) Details()
        {
            int size = 0;
            List<string> list = new List<string>();
            do
            {


                list.Add(GuestBook.UserName());
                size += GuestBook.Size();

            } while (Continue());
            return (list,size);
            
        }

        public static void DisplayName(List<string> guests)
        {

            foreach (var guest in guests)
            {
                Console.WriteLine(guest);
            }

        }
    }
}
