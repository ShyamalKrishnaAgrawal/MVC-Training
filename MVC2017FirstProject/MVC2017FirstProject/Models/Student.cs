using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC2017FirstProject.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public bool isVacinated { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}