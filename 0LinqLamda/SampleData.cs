using _0LinqLamda.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0LinqLamda
{
    public static class SampleData
    {
        public static List<ContactModel> GetContactsData()
        {
            List<ContactModel> output = new()
            {
                new ContactModel { Id = 1, FirstName = "Dhruv", LastName = "Sharma" , Addresses = new List<int> {1,2,3}},
                new ContactModel { Id = 2, FirstName = "Indra", LastName = "Sharma", Addresses = new List<int> { 2, 3 } },
                new ContactModel { Id = 3, FirstName = "Raja", LastName = "Rana", Addresses = new List<int> { 3 } },
                new ContactModel { Id = 4, FirstName = "Rani", LastName = "Thakur", Addresses = new List<int> { 1 } },
                new ContactModel { Id = 5, FirstName = "Jatt", LastName = "Singh", Addresses = new List<int> { 2, 3 } }
            };
            return output;
        }

        public static List<AddressModel> GetAddressModel()
        {
            List<AddressModel> output = new()
            {
            new AddressModel { Id = 1, ContactId = 1, City = "Shimla", State = "Himachal" },
            new AddressModel { Id = 2, ContactId = 3, City = "Shimla", State = "Himachal" },
            new AddressModel { Id = 3, ContactId = 5, City = "Shimla", State = "Himachal" },
            new AddressModel { Id = 4, ContactId = 5, City = "Mohali", State = "Punjab" },
            new AddressModel { Id = 5, ContactId = 5, City = "Gurgao", State = "Haryana" },
            };
            return output;
            
        }
    }
}
