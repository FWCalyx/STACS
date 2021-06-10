using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Forms;

namespace LacosteC868Task.Classes
{
    public class Student : Person
    {
        StacsDB stacs = new();
        public string Eligibility { get; set; }
        public int SchoolID { get; set; }
        public DateTime DateOfEntry { get; set; }
        
        public string FullName { get; set; }

        public Student(int id, string lastname, string firstname, string middleinit, DateTime dob, string email, string phone, string address, string address2, string city, string state, string zipcode, string eligibility, int schoolid, DateTime dateofentry) : base(id, lastname, firstname, middleinit, dob, email, phone, address, address2, city, state, zipcode)
        {

            Eligibility = eligibility;
            SchoolID = schoolid;
            DateOfEntry = dateofentry;
            FullName = $"{lastname}, {firstname}";
        }
     
    }
}
