using Eclerx.Mvc_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Eclerx.Mvc_2.Controllers
{
    public class StudentRegistrationController : Controller
    {
        // GET: Library
        public ActionResult Index()
        {
            var StudentRegistration = GetStudentRegistration().ToList();
            return View(StudentRegistration);
        }

        public List<StudentRegistration> GetStudentRegistration()
        {
            return new List<StudentRegistration>
            {
                new StudentRegistration { StudentId=11, UserId="011",   DateofBirth="12/12/2002", MobileNo="2345"},
                new StudentRegistration { StudentId=12, UserId="012", DateofBirth="11/10/2000", MobileNo="5647"},
                new StudentRegistration { StudentId=13, UserId="013",  DateofBirth="9/9/2009", MobileNo="8891"},
                new StudentRegistration { StudentId= 15, UserId="015", DateofBirth="7/8/1999", MobileNo="9981"},

            };

        }
    }
}