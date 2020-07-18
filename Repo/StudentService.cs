using CollegeApp.Data;
using CollegeApp.Models;
using CollegeApp.ViewModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeApp.Repo
{


    public class StudentService : IStudent
    {

        private readonly ApplicationDbContext _db;

        public StudentService(ApplicationDbContext db)
        {
            _db = db;
        }
        public StudentVM ShowCreatePage()
        {
            var courses = _db.Courses.ToList();
            StudentVM studentVm = new StudentVM
            {
              Courses = courses
            };
            return studentVm;
        }

        public void CreateNewStudent(StudentVM studentVm)
        {
            Student student = new Student();
            student.StudentName = studentVm.StudentName.ToUpper();
            student.RegistrationNumber = studentVm.RegistrationNumber;

            student.DateCreated = DateTime.Now;
            _db.Students.Add(student);
            _db.SaveChanges();

            foreach(var courseId in studentVm.CourseIDs)
            {
                var CourseStudentDb = new CourseStudent();
                CourseStudentDb.CourseId = courseId;
                CourseStudentDb.StudentId = student.Id;
                _db.CourseStudents.Add(CourseStudentDb);
       
            }
            _db.SaveChanges();
  


        }

        public StudentVM EditStudent(int id)
        {
            Student student = _db.Students.Where(x => x.Id == id).FirstOrDefault();
            StudentVM studentVM = new StudentVM();
            studentVM.StudentName = student.StudentName.ToUpper();
            studentVM.RegistrationNumber = student.RegistrationNumber;
            studentVM.Id = id;
            studentVM.Courses = _db.Courses.ToList();
            //query 
            var CourseIDs = _db.CourseStudents.Where(x => x.StudentId == student.Id).ToList();
            int[] ConvertCourseIDsToArray = new int[1000];
            var count = 0;

            foreach (var courseId in CourseIDs)
            {
               
                ConvertCourseIDsToArray[count] = courseId.CourseId;
                count++;
            }

            studentVM.CourseIDs = ConvertCourseIDsToArray;

            return studentVM;


        }



        public void UpdateStudent(StudentVM studentVm)
        {
            Student student =   _db.Students.Where(s=>s.Id == studentVm.Id).FirstOrDefault() ;
            student.StudentName =  studentVm.StudentName.ToUpper();
            student.RegistrationNumber = studentVm.RegistrationNumber;
            _db.SaveChanges();

            //delete all courses of student in CourseStudent table
              var cs =   _db.CourseStudents.Where(s => s.StudentId == studentVm.Id).ToList();  
                foreach(var i in cs)
                {
                    _db.Remove(i);
                }
                _db.SaveChanges();

            foreach (var courseId in studentVm.CourseIDs)
            {
                var CourseStudentDb = new CourseStudent();
                CourseStudentDb.CourseId = courseId;
                CourseStudentDb.StudentId = student.Id;
                _db.CourseStudents.Add(CourseStudentDb);

            }
            _db.SaveChanges();



        }

        public List<Student> GetStudents()
        {
            return _db.Students.ToList();
        }

        public StudentVM GetStudent (int id)
        {
            var student = _db.Students.Where(x => x.Id == id).Include(x=>x.CourseStudents).FirstOrDefault();
            StudentVM svm = new StudentVM();
            svm.StudentName = student.StudentName;
            svm.RegistrationNumber = student.RegistrationNumber;
            svm.DateCreated = student.DateCreated;
            svm.CourseStudents = student.CourseStudents;

            var CourseIDs = _db.CourseStudents.Where(x => x.StudentId == student.Id).ToList();
            int[] ConvertCourseIDsToArray = new int[1000];
            var count = 0;

            foreach (var courseId in CourseIDs)
            {

                ConvertCourseIDsToArray[count] = courseId.CourseId;
                count++;
            }

            svm.CourseIDs = ConvertCourseIDsToArray;

         svm.Courses =   _db.Courses.Where(c => ConvertCourseIDsToArray.Contains( c.Id ) ).ToList();






            return svm;
        }

      
        public void DeleteStudent(int id)
        {
          var  student = _db.Students.Where(s => s.Id == id).FirstOrDefault();
            _db.Remove(student);
            _db.SaveChanges();
        }




    }
}
