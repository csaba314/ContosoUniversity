using System;
using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.ViewModels
{
    public class EnrollmentDateGroup
    {
        [DataType(DataType.Date)]
        [Display(Name ="Enrollment Date")]
        public DateTime? EnrollmentDate { get; set; }

        [Display(Name = "Student Count")]
        public int StudentCount { get; set; }
    }
}