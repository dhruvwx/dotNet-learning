using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31HomeWork
{
    internal class PersonModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public AddressModel Address { get; set; }
    }
}
