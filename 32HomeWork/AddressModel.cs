using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace _32HomeWork
{
    public class AddressModel
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Pincode { get; set; }

        private string _fulladdress;
        public string Fulladdress
        {
            get
            {
                _fulladdress = $"{Street}\n{City}\n{State}\n{Pincode}\n{Adhar}";
                return _fulladdress;

            }
            //set  READONLY DONT NEED SET 
            //{
            //    _fulladdress = value;

            //}
        }

        private string _adhar;
        public string Adhar
        {
            get//it shows value from _adhar
            {
                string adhar = "****-****-" + _adhar.Substring(_adhar.Length - 4) ;
                return adhar;
            }
            set//gives value to adhar
            {
                _adhar = value;
            }
        }
        public AddressModel(string street, string city, string state, int pincode ,string adhar)
        {
            Street = street;
            City = city;
            State = state;
            Pincode = pincode;
            Adhar = adhar;
        }


    }
}
