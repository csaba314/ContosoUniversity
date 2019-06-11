using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Models
{
    public class Student
    {
        public int ID { get; set; }

        [Display(Name ="Last Name")]
        [StringLength(50, ErrorMessage ="First name cannot be longer than 50 characters.")]
        public string LastName { get; set; }

        [Display(Name = "First Name")]
        [StringLength(50, ErrorMessage ="Last name cannot be longer than 50 characters.")]
        public string FirstName { get; set; }

        [Display(Name ="Enrollment Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime EnrollmentDate { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }


    }
}