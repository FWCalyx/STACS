using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Forms;

namespace LacosteC868Task.Classes
{
    public class Appointment
    {
        StacsDB stacs = new();
        public int ID { get; set; }
        public int CounselorID { get; set; }
        public int StudentID { get; set; }
        public string Reason { get; set; }
        public int SchoolID { get; set; }
        public string Description { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Updated { get; set; }
        public string UpdateBy { get; set; }

        public Appointment (int id, int counselorID, int studentID, string reason, int schoolID, string desc, DateTime start, DateTime end, DateTime createdate, string createdby, DateTime updated, string updateby)
        {
            ID = id;
            CounselorID = counselorID;
            StudentID = studentID;
            Reason = reason;
            SchoolID = schoolID;
            Description = desc;
            Start = start;
            End = end;
            CreateDate = createdate;
            CreatedBy = createdby;
            Updated = updated;
            UpdateBy = updateby;
        }

    }

    // Custom exception handlers
    class StartAfterEndTimeException : Exception
    {
        public StartAfterEndTimeException()
            : base(String.Format("Appointment start time cannot be later than its end time."))
        {
        }
    }

    class MissingFieldException : Exception
    {
        public MissingFieldException()
            : base(String.Format("Required field cannot be blank."))
        {
        }
    }
    class InvalidAppointmentDateException : Exception
    {
        public InvalidAppointmentDateException()
            : base(String.Format("Appointments cannot take place on the weekends."))
        {
        }
    }
    class InvalidAppointmentOverlap : Exception
    {
        public InvalidAppointmentOverlap(string message)
            : base(String.Format($"{message} already has an appointment scheduled during this time."))
        {
        }

    }
}
