using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29StaticClass
{
    public class UserMessage
    {
        public static void Greet(string name)
        {

            int time = TimeOnly.FromDateTime(DateTime.Now).Hour;
            //int time = DateTime.Now.Hour;
            if (time < 12)
            {
                Console.WriteLine($"Good morning {name}");
            }
            else if (time > 12 && time < 19)
            {
                Console.WriteLine($"Good afternoon {name}");
            }
            else
            {
                Console.WriteLine($"Good evening {name}");
            }

        }

        public static void Display(string message)
        {
            Console.Write(message);
            string name = Console.ReadLine();
            Greet(name);
        }

        public static double Values(string message)
        {
            Console.Write(message);
            string val = Console.ReadLine();
            double num;
            bool valid = double.TryParse(val, out num);
            while (valid == false)
            {
                Console.Write("enter a correct value:  ");
                val = Console.ReadLine();
                valid = double.TryParse(val, out num);
            }
            return num;
        }

        public static void End(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine("THANKYOU");
        }
    }
}
