using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandardClassLibrary
{
    public static class CalcLibrary
    {

        public static string Add(Numbers number)
        {
            double sum = number.Num1 + number.Num2;
            return $"SUM OF {number.Num1} AND {number.Num2} is {sum}";
;        }

        public static string Multiply(Numbers number)
        {
            double prod = number.Num1 * number.Num2;
            return $"multiplication of {number.Num1} AND {number.Num2} is {prod}";
        }
    }

    public class Numbers
    {
        public double Num1 { get; set; }

        public double Num2 { get; set; }
    }
}
