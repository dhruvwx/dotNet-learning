using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24Homework
{
    public static class Method
    {

        public static void Welcome()
        {
            Console.WriteLine("hello welcome to the app");
        }

        public static string AskName()
        {
            Console.Write("enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        public static void Greet(string name)
        {
            Console.WriteLine($"hello {name}");
        }
    }
}
