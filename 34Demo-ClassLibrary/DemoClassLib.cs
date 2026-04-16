using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34Demo_ClassLibrary
{
    public class DemoClassLib
    {
        public string FirstName { get; set; }   
        public string LastName { get; set; }

        private string _fullname;
        public string FullName
        {
            get
            {
                return _fullname;
            }
            set
            {
                _fullname = $"{FirstName} {LastName}";
            }
        }
    }
}
