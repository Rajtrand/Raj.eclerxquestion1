using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Eclerx.Mvc_2.Models
{
    public class StudentRegistration
    {
        public int StudentId { get; set; }
        public string UserId { get; set; }
        public int Password { get; set; }
        public string DateofBirth { get; set; }
        public string MobileNo { get; set; }

        

    }
}