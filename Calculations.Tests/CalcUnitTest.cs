using _49._0CalculationTesting_HW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationsLibrary.Tests
{
    public class CalcUnitTest
    {
        //ARRANGE   ACT  ASSERT

        [Theory]
        [InlineData(2.3 , 2.7 , 5)]
        public void AddTest(double val1 , double val2 , double expected)
        {
            CalculationsClass sum = new CalculationsClass();
            double actual = sum.Add(val1, val2);
            Assert.Equal(expected, actual);
        }


        [Theory]
        [InlineData(7.7 , 7.7 , 0)]
        [InlineData(9 , -2 , 11)]
        public void SubtractTest(double val1, double val2, double expected)
        {
            CalculationsClass subtract = new CalculationsClass();
            double actual = subtract.Subtract(val1, val2);
            Assert.Equal(expected, actual);
        }


        [Theory]
        [InlineData(120 , -10 ,-1200)]
        [InlineData(120 , 0 ,0)]
        public void MultiplyTest(double val1, double val2, double expected)
        {
            CalculationsClass multiply = new CalculationsClass();
            double actual = multiply.Multiply(val1, val2);
            Assert.Equal(expected, actual);
        }



        [Theory]
        [InlineData(20 , 10 , 2)]
        [InlineData(-20 , 10 , -2)]
        [InlineData(20 , 0 , 0)]
        public void DivideTest(double val1, double val2, double expected)
        {
            CalculationsClass divide = new CalculationsClass();
            double actual = divide.Divide(val1, val2);
            Assert.Equal(expected, actual);
        }

    }
}
