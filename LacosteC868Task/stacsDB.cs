using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.ComponentModel;
using LacosteC868Task.Classes;
using System.Data;
using System.Windows.Forms;

namespace LacosteC868Task
{
    class StacsDB
    {
        readonly private string connectionString;
        readonly private MySqlConnection myCon;

        public StacsDB()
        {
            connectionString = "(removed for security)";
            myCon = new MySqlConnection(connectionString);
        }

        // Login function.

        public int UserCheck(string username, string password)
        {
            int userID = 0;
            string query = $"SELECT ID FROM user WHERE username = '{username}' AND password = '{password}'";
            using (myCon)
            {
                myCon.Open();
                MySqlCommand Login = new(query, myCon);
                MySqlDataReader reader = Login.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    userID = reader.GetInt32(0);
                    myCon.Close();
                }
            }
            return userID;
        }

        public void FillUsers(BindingList<User> AllUsers)
        {
            string query = $"SELECT ID, username, admin, counselorID FROM user ORDER BY username";
            using (myCon)
            {
                myCon.Open();
                MySqlCommand ReadUsers = new(query, myCon);
                MySqlDataAdapter MyAdapter = new();
                MyAdapter.SelectCommand = ReadUsers;
                DataTable userTable = new();
                MyAdapter.Fill(userTable);
                myCon.Close();
                foreach (DataRow row in userTable.Rows)
                {
                    User user = new(
                        (int)row["ID"],
                        row["username"].ToString(),
                        (int)row["admin"],
                        (int)row["counselorID"]
                        );
                    AllUsers.Add(user);
                }
            }
        }

        public void FillStudents(BindingList<Student> stulist)
        {
            string query = $"SELECT * FROM student ORDER BY LastName";
            using (myCon)
            {
                myCon.Open();
                MySqlCommand ReadStudents = new (query, myCon);
                MySqlDataAdapter MyAdapter = new();
                MyAdapter.SelectCommand = ReadStudents;
                DataTable studentTable = new ();
                MyAdapter.Fill(studentTable);
                myCon.Close();
                foreach (DataRow row in studentTable.Rows)
                {
                    Student student = new(
                        (int)row["ID"],
                        row["LastName"].ToString(),
                        row["FirstName"].ToString(),
                        row["MiddleInitial"].ToString(),
                        DateTime.Parse(row["DOB"].ToString()),
                        row["Email"].ToString(),
                        row["Phone"].ToString(),
                        row["Address"].ToString(),
                        row["Address2"].ToString(),
                        row["City"].ToString(),
                        row["State"].ToString(),
                        row["Zipcode"].ToString(),
                        row["Eligibility"].ToString(),
                        (int)row["SchoolID"],
                        DateTime.Parse(row["DateOfEntry"].ToString()));
                    stulist.Add(student);
                }
            }
        }
        public void FillSchools(BindingList<School> schools)
        {
            string query = $"SELECT * FROM school ORDER BY Name";
            using (myCon)
            {
                myCon.Open();
                MySqlCommand ReadSchools = new(query, myCon);
                MySqlDataAdapter MyAdapter = new();
                MyAdapter.SelectCommand = ReadSchools;
                DataTable schoolTable = new();
                MyAdapter.Fill(schoolTable);
                myCon.Close();
                foreach (DataRow row in schoolTable.Rows)
                {
                    School school = new(
                        (int)row["ID"],
                        row["name"].ToString(),
                        row["address"].ToString(),
                        row["address2"].ToString(),
                        row["city"].ToString(),
                        row["state"].ToString(),
                        row["zipcode"].ToString(),
                        row["contact"].ToString(),
                        row["phone"].ToString(),
                        row["email"].ToString()
                        );
                    schools.Add(school);
                }
            }

        }

        public void FillCounselors(BindingList<Counselor> counselors)
        {
            string query = $"SELECT * FROM counselor ORDER BY LastName";
            using (myCon)
            {
                myCon.Open();
                MySqlCommand ReadCounselors = new(query, myCon);
                MySqlDataAdapter MyAdapter = new();
                MyAdapter.SelectCommand = ReadCounselors;
                DataTable counselorTable = new();
                MyAdapter.Fill(counselorTable);
                myCon.Close();
                foreach (DataRow row in counselorTable.Rows)
                {
                    Counselor counselor = new(
                        (int)row["ID"],
                        row["LastName"].ToString(),
                        row["FirstName"].ToString(),
                        row["MiddleInitial"].ToString(),
                        DateTime.Parse(row["DOB"].ToString()),
                        row["Email"].ToString(),
                        row["Phone"].ToString(),
                        row["Address"].ToString(),
                        row["Address2"].ToString(),
                        row["City"].ToString(),
                        row["State"].ToString(),
                        row["Zipcode"].ToString(),
                        row["Title"].ToString(),
                        DateTime.Parse(row["DOH"].ToString())
                        );
                    counselors.Add(counselor);
                }
            }

        }

        public void FillAppointments(BindingList<Appointment> appointments)
        {
            string query = $"SELECT * FROM appointment ORDER BY start";
            using (myCon)
            {
                myCon.Open();
                MySqlCommand ReadAppointments = new(query, myCon);
                MySqlDataAdapter MyAdapter = new();
                MyAdapter.SelectCommand = ReadAppointments;
                DataTable appointmentTable = new();
                MyAdapter.Fill(appointmentTable);
                myCon.Close();
                foreach (DataRow row in appointmentTable.Rows)
                {
                    Appointment appointment = new(
                        (int)row["ID"],
                        (int)row["counselorID"],
                        (int)row["studentID"],
                        row["reason"].ToString(),
                        (int)row["schoolID"],
                        row["description"].ToString(),
                        DateTime.Parse(row["start"].ToString()),
                        DateTime.Parse(row["end"].ToString()),
                        DateTime.Parse(row["createdate"].ToString()),
                        row["createdby"].ToString(),
                        DateTime.Parse(row["updated"].ToString()),
                        row["updateby"].ToString()
                        );
                    appointments.Add(appointment);
                }
            }

        }
        public void AddStudent(Student newStudent)
        {
            string DOB = newStudent.DOB.ToString("yyyy-MM-dd H:mm:ss");
            string DOE = newStudent.DateOfEntry.ToString("yyyy-MM-dd H:mm:ss");
            string query = $"INSERT INTO student (LastName, FirstName, MiddleInitial, DOB, Email, Phone, Address, Address2, City, State, ZipCode, Eligibility, SchoolID, DateOfEntry) " +
                $"VALUES (@lastname, @firstname, @middleinitial, @dob, @email, @phone, @address, @address2, @city, @state, @zipcode, @eligibility, @schoolid, @dateofentry)";
            using (myCon)
            {
                myCon.Open();
                MySqlCommand add = new(query, myCon);
                add.Parameters.AddWithValue("@lastname", newStudent.LastName);
                add.Parameters.AddWithValue("@firstname", newStudent.FirstName);
                add.Parameters.AddWithValue("@middleinitial", newStudent.MiddleInitial);
                add.Parameters.AddWithValue("@dob", DOB);
                add.Parameters.AddWithValue("@email", newStudent.Email);
                add.Parameters.AddWithValue("@phone", newStudent.Phone);
                add.Parameters.AddWithValue("@address", newStudent.Address);
                add.Parameters.AddWithValue("@address2", newStudent.Address2);
                add.Parameters.AddWithValue("@city", newStudent.City);
                add.Parameters.AddWithValue("@state", newStudent.State);
                add.Parameters.AddWithValue("@zipcode", newStudent.Zipcode);
                add.Parameters.AddWithValue("@eligibility", newStudent.Eligibility);
                add.Parameters.AddWithValue("@schoolid", newStudent.SchoolID);
                add.Parameters.AddWithValue("@dateofentry", DOE);
                if (add.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Student added to STACS database.");
                }
                else
                {
                    MessageBox.Show("Could not add the student.");
                }
                myCon.Close();
            }
        }

        public void UpdateStudent(Student newStudent)
        {
            string DOB = newStudent.DOB.ToString("yyyy-MM-dd H:mm:ss");
            string DOE = newStudent.DateOfEntry.ToString("yyyy-MM-dd H:mm:ss");
            string query = $"UPDATE student SET LastName = @lastname, FirstName = @firstname, MiddleInitial = @middleinitial, DOB = @dob, Email = @email, Phone = @phone, Address = @address, Address2 = @address2, City = @city, State = @state, ZipCode = @zipcode, Eligibility = @eligibility, SchoolID = @schoolid, DateOfEntry = @dateofentry WHERE ID = @id;";
            using (myCon)
            {
                myCon.Open();
                MySqlCommand update = new(query, myCon);
                update.Parameters.AddWithValue("@id", newStudent.ID);
                update.Parameters.AddWithValue("@lastname", newStudent.LastName);
                update.Parameters.AddWithValue("@firstname", newStudent.FirstName);
                update.Parameters.AddWithValue("@middleinitial", newStudent.MiddleInitial);
                update.Parameters.AddWithValue("@dob", DOB);
                update.Parameters.AddWithValue("@email", newStudent.Email);
                update.Parameters.AddWithValue("@phone", newStudent.Phone);
                update.Parameters.AddWithValue("@address", newStudent.Address);
                update.Parameters.AddWithValue("@address2", newStudent.Address2);
                update.Parameters.AddWithValue("@city", newStudent.City);
                update.Parameters.AddWithValue("@state", newStudent.State);
                update.Parameters.AddWithValue("@zipcode", newStudent.Zipcode);
                update.Parameters.AddWithValue("@eligibility", newStudent.Eligibility);
                update.Parameters.AddWithValue("@schoolid", newStudent.SchoolID);
                update.Parameters.AddWithValue("@dateofentry", DOE);
                if (update.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Student updated.");
                }
                else
                {
                    MessageBox.Show("Could not update the student.");
                }
                myCon.Close();
                
            }
        }

        public void DeleteStudent(Student delStudent)
        {
            string query = $"DELETE FROM student WHERE ID = @id";
            using (myCon)
            {
                myCon.Open();
                MySqlCommand delete = new(query, myCon);
                delete.Parameters.AddWithValue("@id", delStudent.ID);
                if (delete.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Student has been deleted.");
                }
                else
                {
                    MessageBox.Show("Could not delete the student.");
                }
                myCon.Close();
            }
        }
        public void AddCounselor(Counselor newCounselor)
        {
            string DOB = newCounselor.DOB.ToString("yyyy-MM-dd H:mm:ss");
            string DOH = newCounselor.DateOfHire.ToString("yyyy-MM-dd H:mm:ss");
            string query = $"INSERT INTO counselor (LastName, FirstName, MiddleInitial, DOB, Email, Phone, Address, Address2, City, State, ZipCode, Title, DOH) " +
                $"VALUES (@lastname, @firstname, @middleinitial, @dob, @email, @phone, @address, @address2, @city, @state, @zipcode, @title, @doh)";
            using (myCon)
            {
                myCon.Open();
                MySqlCommand add = new(query, myCon);
                add.Parameters.AddWithValue("@lastname", newCounselor.LastName);
                add.Parameters.AddWithValue("@firstname", newCounselor.FirstName);
                add.Parameters.AddWithValue("@middleinitial", newCounselor.MiddleInitial);
                add.Parameters.AddWithValue("@dob", DOB);
                add.Parameters.AddWithValue("@email", newCounselor.Email);
                add.Parameters.AddWithValue("@phone", newCounselor.Phone);
                add.Parameters.AddWithValue("@address", newCounselor.Address);
                add.Parameters.AddWithValue("@address2", newCounselor.Address2);
                add.Parameters.AddWithValue("@city", newCounselor.City);
                add.Parameters.AddWithValue("@state", newCounselor.State);
                add.Parameters.AddWithValue("@zipcode", newCounselor.Zipcode);
                add.Parameters.AddWithValue("@title", newCounselor.Title);
                add.Parameters.AddWithValue("@doh", DOH);
                if (add.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Counselor added to STACS database.");
                }
                else
                {
                    MessageBox.Show("Could not add the counselor.");
                }
                myCon.Close();
            }
        }
        public void UpdateCounselor(Counselor newCounselor)
        {
            string DOB = newCounselor.DOB.ToString("yyyy-MM-dd H:mm:ss");
            string DOH = newCounselor.DateOfHire.ToString("yyyy-MM-dd H:mm:ss");
            string query = $"UPDATE counselor SET LastName = @lastname, FirstName = @firstname, MiddleInitial = @middleinitial, DOB = @dob, Email = @email, Phone = @phone, Address = @address, Address2 = @address2, City = @city, State = @state, ZipCode = @zipcode, Title = @title, DOH = @doh WHERE ID = @id;";
            using (myCon)
            {
                myCon.Open();
                MySqlCommand update = new(query, myCon);
                update.Parameters.AddWithValue("@id", newCounselor.ID);
                update.Parameters.AddWithValue("@lastname", newCounselor.LastName);
                update.Parameters.AddWithValue("@firstname", newCounselor.FirstName);
                update.Parameters.AddWithValue("@middleinitial", newCounselor.MiddleInitial);
                update.Parameters.AddWithValue("@dob", DOB);
                update.Parameters.AddWithValue("@email", newCounselor.Email);
                update.Parameters.AddWithValue("@phone", newCounselor.Phone);
                update.Parameters.AddWithValue("@address", newCounselor.Address);
                update.Parameters.AddWithValue("@address2", newCounselor.Address2);
                update.Parameters.AddWithValue("@city", newCounselor.City);
                update.Parameters.AddWithValue("@state", newCounselor.State);
                update.Parameters.AddWithValue("@zipcode", newCounselor.Zipcode);
                update.Parameters.AddWithValue("@title", newCounselor.Title);
                update.Parameters.AddWithValue("@doh", DOH);
                if (update.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Counselor updated.");
                }
                else
                {
                    MessageBox.Show("Could not update the counselor.");
                }
                myCon.Close();

            }
        }

        public void DeleteCounselor(Counselor delCounselor)
        {
            string query = $"DELETE FROM counselor WHERE ID = @id";
            using (myCon)
            {
                myCon.Open();
                MySqlCommand delete = new(query, myCon);
                delete.Parameters.AddWithValue("@id", delCounselor.ID);
                if (delete.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Counselor has been deleted.");
                }
                else
                {
                    MessageBox.Show("Could not delete the counselor.");
                }
                myCon.Close();
            }
        }
        public void AddAppointment(Appointment newAppointment)
        {
            string start = newAppointment.Start.ToString("yyyy-MM-dd H:mm:ss");
            string end = newAppointment.End.ToString("yyyy-MM-dd H:mm:ss");
            string created = newAppointment.CreateDate.ToString("yyyy-MM-dd H:mm:ss");
            string updated = newAppointment.Updated.ToString("yyyy-MM-dd H:mm:ss");
            string query = $"INSERT INTO appointment (counselorID, studentID, reason, schoolID, description, start, end, createdate, createdby, updated, updateby)   VALUES ((SELECT ID FROM counselor WHERE ID = @counselorid), (SELECT ID FROM student WHERE ID = @studentid), @reason, (SELECT ID FROM school WHERE ID = @schoolid), @description, @start, @end, @createdate, @createdby, @updated, @updateby);";
            using (myCon)
            {
                myCon.Open();
                MySqlCommand add = new(query, myCon);
                add.Parameters.AddWithValue("@counselorid", newAppointment.CounselorID);
                add.Parameters.AddWithValue("@studentid", newAppointment.StudentID);
                add.Parameters.AddWithValue("@reason", newAppointment.Reason);
                add.Parameters.AddWithValue("@schoolid", newAppointment.SchoolID);
                add.Parameters.AddWithValue("@description", newAppointment.Description);
                add.Parameters.AddWithValue("@start", start);
                add.Parameters.AddWithValue("@end", end);
                add.Parameters.AddWithValue("@createdate", created);
                add.Parameters.AddWithValue("@createdby", newAppointment.CreatedBy);
                add.Parameters.AddWithValue("@updated", updated);
                add.Parameters.AddWithValue("@updateby", newAppointment.UpdateBy);
                if (add.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Appointment added to STACS database.");
                }
                else
                {
                    MessageBox.Show("Could not add the appointment.");
                }
                myCon.Close();
            }
        }
        public void UpdateAppointment(Appointment newAppointment)
        {
            string start = newAppointment.Start.ToString("yyyy-MM-dd H:mm:ss");
            string end = newAppointment.End.ToString("yyyy-MM-dd H:mm:ss");
            string created = newAppointment.CreateDate.ToString("yyyy-MM-dd H:mm:ss");
            string updated = newAppointment.Updated.ToString("yyyy-MM-dd H:mm:ss");
            string query = $"UPDATE appointment SET counselorID = @counselorid, studentID = @studentid, reason = @reason, schoolID = @schoolid, description = @description, start = @start, end = @end, createdate = @createdate, createdby = @createdby, updated = @updated, updateby = @updateby WHERE ID = @id;";
            using (myCon)
            {
                myCon.Open();
                MySqlCommand update = new(query, myCon);
                update.Parameters.AddWithValue("@id", newAppointment.ID);
                update.Parameters.AddWithValue("@counselorid", newAppointment.CounselorID);
                update.Parameters.AddWithValue("@studentid", newAppointment.StudentID);
                update.Parameters.AddWithValue("@reason", newAppointment.Reason);
                update.Parameters.AddWithValue("@schoolid", newAppointment.SchoolID);
                update.Parameters.AddWithValue("@description", newAppointment.Description);
                update.Parameters.AddWithValue("@start", start);
                update.Parameters.AddWithValue("@end", end);
                update.Parameters.AddWithValue("@createdate", created);
                update.Parameters.AddWithValue("@createdby", newAppointment.CreatedBy);
                update.Parameters.AddWithValue("@updated", updated);
                update.Parameters.AddWithValue("@updateby", newAppointment.UpdateBy);
                if (update.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Appointment updated.");
                }
                else
                {
                    MessageBox.Show("Could not update the appointment.");
                }
                myCon.Close();

            }
        }
        public void DeleteAppointment(Appointment delAppointment)
        {
            string query = $"DELETE FROM appointment WHERE ID = @id";
            using (myCon)
            {
                myCon.Open();
                MySqlCommand delete = new(query, myCon);
                delete.Parameters.AddWithValue("@id", delAppointment.ID);
                if (delete.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Appointment has been deleted.");
                }
                else
                {
                    MessageBox.Show("Could not delete the appointment.");
                }
                myCon.Close();
            }
        }

        public void AddSchool(School newSchool)
        {
            string query = $"INSERT INTO school (name, address, address2, city, state, zipcode, contact, phone, email) " +
                $"VALUES (@name, @address, @address2, @city, @state, @zipcode, @contact, @phone, @email);";
            using (myCon)
            {
                myCon.Open();
                MySqlCommand add = new(query, myCon);
                add.Parameters.AddWithValue("@name", newSchool.Name);
                add.Parameters.AddWithValue("@address", newSchool.Address);
                add.Parameters.AddWithValue("@address2", newSchool.Address2);
                add.Parameters.AddWithValue("@city", newSchool.City);
                add.Parameters.AddWithValue("@state", newSchool.State);
                add.Parameters.AddWithValue("@zipcode", newSchool.Zipcode);
                add.Parameters.AddWithValue("@contact", newSchool.Contact);
                add.Parameters.AddWithValue("@phone", newSchool.Phone);
                add.Parameters.AddWithValue("@email", newSchool.Email);
                if (add.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("School added to STACS database.");
                }
                else
                {
                    MessageBox.Show("Could not add the school.");
                }
                myCon.Close();
            }
        }
        public void UpdateSchool(School newSchool)
        {
            string query = $"UPDATE school SET " +
                $"name = @name, " +
                $"address = @address, " +
                $"address2 = @address2, " +
                $"city = @city, " +
                $"state = @state," +
                $"zipcode = @zipcode," +
                $"contact = @contact," +
                $"phone = @phone," +
                $"email = @email WHERE ID = @id;";
            using (myCon)
            {
                myCon.Open();
                MySqlCommand update = new(query, myCon);
                update.Parameters.AddWithValue("@id", newSchool.ID);
                update.Parameters.AddWithValue("@name", newSchool.Name);
                update.Parameters.AddWithValue("@address", newSchool.Address);
                update.Parameters.AddWithValue("@address2", newSchool.Address2);
                update.Parameters.AddWithValue("@city", newSchool.City);
                update.Parameters.AddWithValue("@state", newSchool.State);
                update.Parameters.AddWithValue("@zipcode", newSchool.Zipcode);
                update.Parameters.AddWithValue("@contact", newSchool.Contact);
                update.Parameters.AddWithValue("@phone", newSchool.Phone);
                update.Parameters.AddWithValue("@email", newSchool.Email);
                if (update.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("School updated.");
                }
                else
                {
                    MessageBox.Show("Could not update the school.");
                }
                myCon.Close();

            }
        }
        public void DeleteSchool(School delSchool)
        {
            string query = $"DELETE FROM school WHERE ID = @id";
            using (myCon)
            {
                myCon.Open();
                MySqlCommand delete = new(query, myCon);
                delete.Parameters.AddWithValue("@id", delSchool.ID);
                if (delete.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("School has been deleted.");
                }
                else
                {
                    MessageBox.Show("Could not delete the school.");
                }
                myCon.Close();
            }
        }
        public void AddUser(User newUser)
        {
            string query = $"INSERT INTO user (username, password, admin, counselorID) " +
                $"VALUES (@username, @password, @admin, @counselorID);";
            using (myCon)
            {
                myCon.Open();
                MySqlCommand add = new(query, myCon);
                add.Parameters.AddWithValue("@username", newUser.UserName);
                add.Parameters.AddWithValue("@password", "smarty1");
                add.Parameters.AddWithValue("@admin", newUser.IntAdmin);
                add.Parameters.AddWithValue("@counselorID", newUser.CounselorID);
                if (add.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("User added to STACS database.");
                }
                else
                {
                    MessageBox.Show("Could not add the user.");
                }
                myCon.Close();
            }
        }
        public void UpdateUser(User newUser)
        {
            string query = $"UPDATE user SET " +
                $"username = @username, " +
                $"admin = @admin, " +
                $"counselorID = @counselorID WHERE ID = @id;";
            using (myCon)
            {
                myCon.Open();
                MySqlCommand update = new(query, myCon);
                update.Parameters.AddWithValue("@id", newUser.ID);
                update.Parameters.AddWithValue("@username", newUser.UserName);
                update.Parameters.AddWithValue("@admin", newUser.IntAdmin);
                update.Parameters.AddWithValue("@counselorID", newUser.CounselorID);
                if (update.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("User updated.");
                }
                else
                {
                    MessageBox.Show("Could not update the user.");
                }
                myCon.Close();

            }
        }
        public void DeleteUser(User delUser)
        {
            string query = $"DELETE FROM user WHERE ID = @id";
            using (myCon)
            {
                myCon.Open();
                MySqlCommand delete = new(query, myCon);
                delete.Parameters.AddWithValue("@id", delUser.ID);
                if (delete.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("User has been deleted.");
                }
                else
                {
                    MessageBox.Show("Could not delete the user.");
                }
                myCon.Close();
            }
        }

        public void PasswordChange(User newUser, string pword)
        {
            string query = $"UPDATE user SET " +
                $"password = @password WHERE ID = @id;";
            using (myCon)
            {
                myCon.Open();
                MySqlCommand update = new(query, myCon);
                update.Parameters.AddWithValue("@id", $"{newUser.ID}");
                update.Parameters.AddWithValue("@password", $"{pword}");
                if (update.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Password has been updated.");
                }
                else
                {
                    MessageBox.Show("Could not update the password.");
                }
                myCon.Close();

            }
        }
    }
}
