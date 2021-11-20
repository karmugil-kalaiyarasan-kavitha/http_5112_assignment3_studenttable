using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace http_5112_assignment3_student.Models
{
    public class Student
    {
        //studentid,studentfname,studentlname,studentnumber,enroldate
        public int studentId { get; set; }
        public String studentFName { get; set; }
        public String studentLName { get; set; }
        public String studentNumber { get; set; }
        public String enrolDate { get; set; }
    }
}