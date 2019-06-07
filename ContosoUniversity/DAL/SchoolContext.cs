using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ContosoUniversity.Models;

// using statement for DBModelBuilder Conventions configuration
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ContosoUniversity.DAL
{
    public class SchoolContext : DbContext
    {

        public SchoolContext() : base("SchoolContext") // passing the name of the connection string to the base constructor
        {                                              // connection string is stored in Web.config
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            // removes the PluraliyingTableNameConvention - table names will be singular and not plural as a default setting
            // Student, Enrollment, Course in stead of Students, Enrollments and Courses
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }

}
