using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LacosteC868Task.Classes
{
    public class School
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public string Contact { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public School (int id, string name, string address, string address2, string city, string state, string zipcode, string contact, string phone, string email)
        {
            ID = id;
            Name = name;
            Address = address;
            Address2 = address2;
            City = city;
            State = state;
            Zipcode = zipcode;
            Contact = contact;
            Phone = phone;
            Email = email;
        }
    }
}
