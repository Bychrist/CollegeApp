using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeApp.Models
{
    public class Student
    {

        public int Id { get; set; }
        [Required]
        [Display(Name ="Student Name")]
        public string StudentName { get; set; }
        [Display(Name = "Registration Number")]
        public string RegistrationNumber { get; set; }
        public ICollection<CourseStudent> CourseStudents { get; set; }
        [Display(Name ="Date Created")]
        public DateTime DateCreated { get; set; } 
    }
}
