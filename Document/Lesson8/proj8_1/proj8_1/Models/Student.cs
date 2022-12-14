using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace proj8_1.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Address { get; set;}
        public DateTime EnrollmentDate { get; set; }

        public virtual ICollection<Enrollment> Enrollment { get; set; }
    }
}