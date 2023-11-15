using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TazaFood_Core.Models.Order_Aggregate
{
    public class Address
    {
        public Address() { }
        
        public Address(string country, string city, string street)
        {
            Country = country;
            City = city;
            Street = street;
        }

        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
    }
}
