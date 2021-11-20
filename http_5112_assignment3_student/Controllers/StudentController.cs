using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using http_5112_assignment3_student.Models;

namespace http_5112_assignment3_student.Controllers
{
    public class StudentController : Controller
    {

        /// <summary>
        /// Returns a list of students by providong it to view
        /// </summary>
        /// <example>Student/ShowStudent</example>
        /// <returns>
        /// A list of students (studentid,studentfname,studentlname,studentnumber,enroldate)
        /// </returns>
        // GET: Student/ShowStudent
        [HttpGet]
        public ActionResult ShowStudent()
        {
            StudentDataController Controller = new StudentDataController();
            IEnumerable<Student> Students = Controller.ListStudents();
            return View(Students);
        }
    }
}