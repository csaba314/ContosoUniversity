using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class OfficeAssignment
    {
        [Key] // sets the property as the primary key because the name of the property does not follow the EF convention
              // the key attribute by default is treated as non-database-generated
        [ForeignKey("Instructor")] // FK attribute is applied to the dependent class to establish the one-to-zero-or-one relationship
        public int InstructorID { get; set; } // InstructorID is non-nullable and [Required] attribute is not needed

        [StringLength(50, ErrorMessage ="Location name cannot be longer than 50 characters.")]
        [Display(Name ="Office Location")]
        public string Location { get; set; }

        public virtual Instructor Instructor { get; set; }

    }
}