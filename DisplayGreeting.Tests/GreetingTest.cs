using _48._0UnitTestLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DisplayGreetingLibrary.Tests
{

    //Create a test method and apply arrange ,act, assert to it
    public class GreetingTest
    {
        [Fact] //this is hard coded result -- cant have parametres in method
        public void TestForGoodMorning()
        {
            DisplayMsg msg = new DisplayMsg();
            //STEP 1  -- ARRANGE : expected value
            string expected = "Sleep please Dhruv";  ///it is checking for 3.

            //STEP 2 -- ACT : actual logic value
            string actual = msg.Greeting("Dhruv", 3);

            //STEP 3 -- ASSERT : Assert.Equal(expected , actual) === it compares both is same passes.
            
            Assert.Equal(expected, actual);
            //-- test explorer in view.
        }


        [Theory] // this can have parameteres in its method.
        [InlineData("Dhruv", 0, "Sleep please Dhruv")]//We can use this to test multiple situations
        [InlineData("Dhruv", 1, "Sleep please Dhruv")]
        [InlineData("Dhruv", 2, "Sleep please Dhruv")]
        [InlineData("Dhruv", 3, "Sleep please Dhruv")]
        [InlineData("Dhruv", 4, "Sleep please Dhruv")]
        [InlineData("Dhruv", 5, "Good Morning Dhruv")]
        [InlineData("Dhruv", 6, "Good Morning Dhruv")]
        [InlineData("Dhruv", 7, "Good Morning Dhruv")]
        [InlineData("Dhruv", 8, "Good Morning Dhruv")]
        [InlineData("Dhruv", 9, "Good Morning Dhruv")]
        [InlineData("Dhruv", 10, "Good Morning Dhruv")]
        [InlineData("Dhruv", 11, "Good Morning Dhruv")]

        [InlineData("Dhruv", 12, "Good Afternoon Dhruv")]
        [InlineData("Dhruv", 13, "Good Afternoon Dhruv")]
        [InlineData("Dhruv", 14, "Good Afternoon Dhruv")]
        [InlineData("Dhruv", 15, "Good Afternoon Dhruv")]
        [InlineData("Dhruv", 16, "Good Afternoon Dhruv")]
        [InlineData("Dhruv", 17, "Good Afternoon Dhruv")]

        [InlineData("Dhruv", 18, "Good Evening Dhruv")]
        [InlineData("Dhruv", 19, "Good Evening Dhruv")]
        [InlineData("Dhruv", 20, "Good Evening Dhruv")]
        [InlineData("Dhruv", 21, "Good Evening Dhruv")]
        [InlineData("Dhruv", 22, "Good Evening Dhruv")]
        [InlineData("Dhruv", 23, "Good Evening Dhruv")]
        [InlineData("Dhruv", 24, "Good Evening Dhruv")]



        public void DynamicTest(string name , int dayHour, string expected)
        {
            //ARRANGE
            DisplayMsg msg = new DisplayMsg();

            //ACT
            string actual = msg.Greeting(name, dayHour);

            Assert.Equal(expected, actual);
        }

    }
}
