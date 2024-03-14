using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SWAUniversity.Models
{
    public class Student
    {
        public int ID { get; set; }

        [Required, StringLength(50, MinimumLength = 2), Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required, StringLength(50), Display(Name = "First Name")]
        public string FirstMidName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true), Display(Name = "Enrollement Date")]
        public DateTime EnrollmentDate { get; set; }

        public string FullName 
        {
            get { return LastName + ", " + FirstMidName; }
        }
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
