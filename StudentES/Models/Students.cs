using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentES.Models
{
    public class Students
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string firstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string lastName { get; set; }

        [Required]
        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        public string email { get; set; }

        [Required]
        [Phone]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone")]
        public string phone { get; set; }

        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString ="{0:yyyy-MM-dd}")]
        [DataType(DataType.Date)]
        [Display(Name = "Birth Date")]
        public DateTime birthDate { get; set; }

        [Required]
        [Display(Name = "Gender")]
        public string gender { get; set; }
    }

    public class StudentModelView: Students
    {
        [Required]
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:MMM dd, yyyy}")]
        [DataType(DataType.Date)]
        [Display(Name = "Birth Date")]
        public new DateTime birthDate { get; set; }

    }
}