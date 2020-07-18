using CollegeApp.Models;
using CollegeApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeApp.Repo
{
    public interface ICourse
    {
        public void CreateCourse(CourseVM course);
        public List<Course> GetAllCourses();
        public Course GetCourse(int id);
        public bool DeletCourse(int id);
        public void UpdateCourse(Course course);
        public Course EditCourse(int id);
    }
}
