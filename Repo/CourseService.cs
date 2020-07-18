using CollegeApp.Data;
using CollegeApp.Models;
using CollegeApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CollegeApp.Repo
{
    public class CourseService : ICourse
    {
        private readonly ApplicationDbContext _db;

        public CourseService(ApplicationDbContext db)
        {
            _db = db;
        }
        public void CreateCourse(CourseVM course)
        {
            Course courseDb = new Course();
            courseDb.CourseName = course.CourseName;
            courseDb.CourseCode = course.CourseCode;
            _db.Courses.Add(courseDb);
            _db.SaveChanges();
        }

        public bool DeletCourse(int id)
        {
            var findCourseInCS = _db.CourseStudents.Where(x => x.CourseId == id).FirstOrDefault();
            if(findCourseInCS == null)
            {
                var course = _db.Courses.Where(x => x.Id == id).FirstOrDefault();
                _db.Remove(course);
                _db.SaveChanges();
                return true;
            }

            return false;

        }

        public Course EditCourse(int id)
        {
            return _db.Courses.Where(x => x.Id == id).FirstOrDefault();
        }

        public List<Course> GetAllCourses()
        {
            var courses = _db.Courses.ToList();
            return courses;
        }

        public Course GetCourse(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateCourse(Course course)
        {
            try
            {
                Course courseDB = _db.Courses.Where(x => x.Id == course.Id).FirstOrDefault();
                courseDB.CourseCode = course.CourseCode;
                courseDB.CourseName = course.CourseName;
                _db.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

     
    }
}
