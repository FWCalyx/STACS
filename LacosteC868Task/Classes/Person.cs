using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LacosteC868Task.Classes
{
    public abstract class Person
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleInitial { get; set; }
        public DateTime DOB { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }    
        
        public Person (int id, string lastname, string firstname, string middleinit, DateTime dob, string email, string phone, string address, string address2, string city, string state, string zipcode)
        {
            ID = id;
            LastName = lastname;
            FirstName = firstname;
            MiddleInitial = middleinit;
            DOB = dob;
            Email = email;
            Phone = phone;
            Address = address;
            Address2 = address2;
            City = city;
            State = state;
            Zipcode = zipcode;
        }

    }
}
