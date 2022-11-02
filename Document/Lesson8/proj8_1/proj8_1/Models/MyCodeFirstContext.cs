using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace proj8_1.Models
{
    public class MyCodeFirstContext : DbContext
    {
        public MyCodeFirstContext() : base("MyCodeFirstContext")
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
    }
}