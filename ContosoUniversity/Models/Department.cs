using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Department
    {
        public int ID { get; set; }

        [StringLength(50, MinimumLength =3)]
        public string Name { get; set; }

        [DataType(DataType.Currency)] 
        [Column(TypeName = "money")] // Column attribute is used to change SQL data type mapping so it will be defined using the SQL Server money type in the db
        public decimal Budget { get; set; }

        [Display(Name ="Start Date")]
        public DateTime StartDate { get; set; }

        public int? InstructorID { get; set; }

        [Timestamp] // Timestamp attribute specifies that this column will be included in the Where clause of Update and Delete commands sent to the db
        public byte[] RowVersion { get; set; }

        public virtual Instructor Administrator { get; set; }
        public ICollection<Course> Courses { get; set; }

    }
}