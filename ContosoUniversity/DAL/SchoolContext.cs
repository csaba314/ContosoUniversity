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
            //this.Configuration.LazyLoadingEnabled = false; // disables lazy loading for all navigation properties
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<OfficeAssignment> OfficeAssignments { get; set; }
        public DbSet<Department> Departments { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            // removes the PluralizingTableNameConvention - table names will be singular and not plural as a default setting
            // Student, Enrollment, Course instead of Students, Enrollments and Courses
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<Course>()
                .HasMany(c => c.Instructors)
                .WithMany(i => i.Courses)
                .Map(t => t.MapLeftKey("CourseID") // MapLeftKey sets the name for the table column - refers to entity in the HasMany() method 
                    .MapRightKey("InstructorID") // MapRightKey sets the name for the table column - refers to entity in the WithMany() mehtod
                    .ToTable("CourseInstructor")); // sets the name of the table in many-to-many relationship


        }

    }

}
