using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24Methods
{
    public static class MathShortcut
    {
        public static void AddAll(double[] values)
        {

            double total = 0;
            for (int i = 0; i < values.Length; i ++)
            {
                total += values[i];
            }
            Console.WriteLine(total);
        }

        public static double Add(double x , double y)
        {
            //Console.WriteLine($"the sum of {x} and {y} is = {x + y}");
            double output = x + y;
            return output;
        }
    }
}
