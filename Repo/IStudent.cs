using CollegeApp.Models;
using CollegeApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeApp.Repo
{
    public interface IStudent
    {
        public StudentVM ShowCreatePage();
        public StudentVM GetStudent(int id);
        public void CreateNewStudent(StudentVM studentVm);
        public void UpdateStudent(StudentVM studentVm);
        public StudentVM EditStudent(int id);
        public List<Student> GetStudents();
        public void DeleteStudent(int id);
    }
}
