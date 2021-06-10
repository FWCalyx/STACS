using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LacosteC868Task.Classes
{
    public class User
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public int IntAdmin { get; set; }
        public int CounselorID { get; set; }
        public bool Admin { get; set; }

        public User (int id, string username, int intadmin, int counselorid)
        {
            ID = id;
            UserName = username;
            IntAdmin = intadmin;
            if (IntAdmin == 1)
            {
                Admin = true;
            }
            else
            {
                Admin = false;
            }
            CounselorID = counselorid;
        }
    }
}
