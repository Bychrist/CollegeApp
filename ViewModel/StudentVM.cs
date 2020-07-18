using CollegeApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeApp.ViewModel
{
    public class StudentVM
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Student Name")]
        public string StudentName { get; set; }
        [Display(Name = "Registration Number")]
        public string RegistrationNumber { get; set; }

        [Display(Name = "Select Courses")]
        public List<Course> Courses  { get; set; }
        [Required(ErrorMessage ="A course must be selected")]
        public int[] CourseIDs { get; set; }
        [Required]
        public DateTime DateCreated { get; set; }
        public ICollection<CourseStudent> CourseStudents { get; set; }
    }
}
