using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Models
{
    public abstract class Person
    {
        public int ID { get; set; }

        [Required, Display(Name ="Last Name"), StringLength(50, ErrorMessage ="Last name cannot be longer than 50 characters")]
        public string LastName { get; set; }

        [Required, Display(Name = "First Name"), StringLength(50, ErrorMessage = "First name cannot be longer than 50 characters")]
        public string FirstName { get; set; }

        [Display(Name ="Full Name")]
        public string FullName
        {
            get
            {
                return string.Format("{0}, {1}", this.LastName, this.FirstName);
            }
        }

    }
}