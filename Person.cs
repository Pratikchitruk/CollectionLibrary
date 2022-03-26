using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionLibrary
{
    public class Person
    {
        public string FirstName;
        public string LastName;
        public string Address;
        public string City;
        public int Zip;
        public string Email;
        public double Phone;
        public string Country;

        public Person(string firstname, string lastname, string address, string city, double phoneno, string email, int zip, string country)
        { 
        FirstName = firstname;
            LastName = lastname;
            Address = address;
            City = city;
            Zip = zip;
            Email = email;
            Phone = phoneno;
            Country = country;


        
        }

    }
}
