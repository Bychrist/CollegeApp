using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CollegeApp.Models;
using CollegeApp.Repo;
using CollegeApp.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CollegeApp.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudent _istudent;

        public StudentController(IStudent istudent)
        {
            _istudent = istudent;
        }
        // GET: StudentController
        public ActionResult Index()
        {
           List<Student> students =  _istudent.GetStudents();
            return View(students);
        }

        // GET: StudentController/Details/5
        public ActionResult Details(int id)
        {
            try
            {
                var student = _istudent.GetStudent(id);
                return View(student);
            }
            catch (Exception)
            {
                TempData["MessageError"] = "Student record was not found";
                return RedirectToAction(nameof(Index));
                
            }
        }

        // GET: StudentController/Create
        public ActionResult Create()
        {
            var studentVm = _istudent.ShowCreatePage();
            return View(studentVm);
        }

        // POST: StudentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(StudentVM studentVm)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    _istudent.CreateNewStudent(studentVm);
                    TempData["Message"] = "Student was successfully registered";
                    return RedirectToAction(nameof(Create));
                }

                return RedirectToAction(nameof(Create));

            }
            catch(Exception e)
            {
                TempData["MessageError"] = e.Message.ToString();
                return RedirectToAction(nameof(Create));
            }
        }

        // GET: StudentController/Edit/5
        public ActionResult Edit(int id)
        {
           var student =  _istudent.EditStudent(id);
            return View(student);
        }

        // POST: StudentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(StudentVM studentVm)
        {
            try
            {
               if(ModelState.IsValid)
                {
                    _istudent.UpdateStudent(studentVm);
                    TempData["Message"] = "Student was updated";
                }

                return RedirectToAction(nameof(Edit));
            }
            catch(Exception e)
            {
                TempData["MessageError"] = e.Message;
                return RedirectToAction(nameof(Edit));
            }

        }

        // GET: StudentController/Delete/5
        public ActionResult Delete(int id)
        {
            try
            {
                _istudent.DeleteStudent(id);
                TempData["Message"] = "Student was deleted successfully";
                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {

                TempData["MessageError"] = e.Message.ToString();
               return  RedirectToAction(nameof(Index));
            }
        }

        
    }
}
