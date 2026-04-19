using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _GuestBook
{
    public class GuestBook
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Msg { get; set; }

        public string FullDetails
        {
            get
            {
                string fullname = $"hi my name is {FirstName} {LastName}  i am {Age} years old i wanted to say: \n {Msg}";
                return fullname;
            }

        }
    }

}
