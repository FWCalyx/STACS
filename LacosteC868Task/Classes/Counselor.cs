using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LacosteC868Task.Classes
{
    public class Counselor : Person
    {
        public string Title { get; set; }
        public DateTime DateOfHire { get; set; }
        public string FullName { get; set; }

        public Counselor(int id, string lastname, string firstname, string middleinit, DateTime dob, string email, string phone, string address, string address2, string city, string state, string zipcode, string title, DateTime dateofhire) : base(id, lastname, firstname, middleinit, dob, email, phone, address, address2, city, state, zipcode)
        {
            Title = title;
            DateOfHire = dateofhire;
            FullName = $"{lastname}, {firstname}";
        }
    }
}
