using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentES.Models
{
    public class Enrollment
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Student Name")]
        public int studentId { get; set; }

        [Display(Name = "Student Name")]
        public string fullname { get; set; }

        [Required]
        [Display(Name = "Course Name")]
        public int courseId { get; set; }

        [Display(Name = "Course Name")]
        public string coursename { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [Display(Name = "Enroll Date")]
        public DateTime enrollDate { get; set; }

        [Required]
        [Display(Name = "Status")]
        public string status { get; set; }
    }

    public class EnrollmentModelView: Enrollment
    {
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:MMMM dd, yyyy}")]
        [Display(Name = "Enroll Date")]
        public new DateTime enrollDate { get; set; }
    }
}