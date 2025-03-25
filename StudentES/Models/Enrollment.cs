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

        [Required]
        [Display(Name = "Student Name")]
        public string fullname { get; set; }

        [Required]
        [Display(Name = "Course Name")]
        public int courseId { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "0:yyyy-dd-MM")]
        [Display(Name = "Enroll Date")]
        public DateTime enrollDate { get; set; }

        [Required]
        [Display(Name = "Status")]
        public string status { get; set; }
    }
}