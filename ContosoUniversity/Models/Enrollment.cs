using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Models
{

    public enum Grade
    {
        A, B, C, D, F
    }

    public class Enrollment
    {
        public int ID { get; set; }

        public int CourseID { get; set; }

        public int StudentID { get; set; }

        [DisplayFormat(NullDisplayText ="No grade")] // if the property is null, it will display the string in NullDisplayText attribute property
        public Grade? Grade { get; set; }


        public virtual Course Course { get; set; }

        public virtual Student Student { get; set; }
    }
}