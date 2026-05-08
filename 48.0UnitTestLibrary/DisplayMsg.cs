using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _48._0UnitTestLibrary
{
    public class DisplayMsg
    {
        public string Greeting(string name, int dayHour)
        {
            string output = "";
            if(dayHour < 5)
            {
                output = $"Sleep please {name}";
            }
            else if(dayHour < 12)
            {
                output = $"Good Morning {name}";
            }
            else if(dayHour < 18)
            {
                output = $"Good Afternoon {name}";
            }
            else
            {
                output = $"Good Evening {name}";

            }
            return output;
        }

    }
}
