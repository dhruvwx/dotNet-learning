using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _49._0CalculationTesting_HW
{
    public class CalculationsClass
    {
        public double Add(double val1 , double val2)
        {
            return val1 + val2;
        }
        public double Subtract(double val1 , double val2)
        {
            return val1 - val2;
        }

        public double Multiply(double val1, double val2)
        {
            return val1 * val2;
        }

        public double Divide(double val1, double val2)
        {
            double output = 0;
            if (val2 != 0)
            {
                output = val1 / val2;
            }
            return output;
        }

    }
}
