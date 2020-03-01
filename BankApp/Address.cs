using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    class Address
    {
        public string StreetNumber { get; set; }
        public string ApartmentNumber { get; set; }
        public string StreetName { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string PostalCode { get; set; }
        public string PhoneNumber { get; set; }

        public Address(string streetNumber, string apartmentNumber, string streetName, string city, string province, string postalCode, string phoneNumber)
        {
            streetNumber = StreetNumber;
            apartmentNumber = ApartmentNumber;
            streetName = StreetName;
            city = City;
            province = Province;
            postalCode = PostalCode;
            phoneNumber = PhoneNumber;

        }
    }
}
