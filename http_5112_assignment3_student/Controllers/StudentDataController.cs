using System;
//using System.DateTime;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using http_5112_assignment3_student.Models;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace http_5112_assignment3_student.Controllers
{
    public class StudentDataController : ApiController
    {
        private SchoolDbContext School = new SchoolDbContext();


        /// <summary>
        /// Returns a list of students in the system 
        /// </summary>
        /// <example>api/studentdata/liststudents</example>
        /// <returns>
        /// A list of student (studentid,studentfname,studentlname,studentnumber,enroldate)
        /// </returns>
        [HttpGet]
        [Route("api/studentdata/liststudents")]
        public List<Student> ListStudents()
        {
            string studentQuery = "Select * from students";

            //Create an instance of a connection
            MySqlConnection Conn = School.AccessDatabase();

            //Open the connection between the web server and database
            Conn.Open();

            //Establish a new command (query) for our database
            MySqlCommand cmd = Conn.CreateCommand();

            //SQL QUERY

            cmd.CommandText = studentQuery;
            MySqlDataReader ResultSet = cmd.ExecuteReader();
            List<Student> StudentNames = new List<Student> { };

            while (ResultSet.Read())
            {
                Student SelectedStudents = new Student();
                SelectedStudents.studentId = Convert.ToInt32(ResultSet["studentid"]);
                SelectedStudents.studentFName = ResultSet["studentfname"].ToString();

                SelectedStudents.studentLName = ResultSet["studentlname"].ToString();
                SelectedStudents.studentNumber = ResultSet["studentnumber"].ToString();
                SelectedStudents.enrolDate = ResultSet["enroldate"].ToString();

                StudentNames.Add(SelectedStudents);
            }

            Conn.Close();

            return StudentNames;
        }


    }
}
