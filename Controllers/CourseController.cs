using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CollegeApp.Data;
using CollegeApp.Models;
using CollegeApp.Repo;
using CollegeApp.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CollegeApp.Controllers
{
    public class CourseController : Controller
    {
        private readonly ICourse _icourse;

        public CourseController(ICourse icourse)
        {
            _icourse = icourse;
        }
        // GET: Course
        public ActionResult Index()
        {
            IEnumerable<Course> allCourses = _icourse.GetAllCourses();
            return View(allCourses);
        }

        // GET: Course/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Course/Create
        public ActionResult Create()
        {
           
            return View();
        }

        // POST: Course/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CourseVM course)
        {
            try
            {
                _icourse.CreateCourse(course);
                TempData["Message"] = "Course created successfully";
                return RedirectToAction(nameof(Create));
            }
            catch (Exception e)
            {
                TempData["MessageError"] = e.Message.ToString();
                return RedirectToAction(nameof(Create));
            }
        }

        // GET: Course/Edit/5
        public ActionResult Edit(int id)
        {
            Course course = _icourse.EditCourse(id);
            return View(course);
        }

        // POST: Course/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Course course)
        {
            try
            {
                _icourse.UpdateCourse(course);
                TempData["Message"] = "Course was updated";
                return RedirectToAction(nameof(Index));
            }
            catch(Exception e)
            {
                TempData["MessageError"] = e.Message.ToString();
                return View();
            }
        }

        // GET: Course/Delete/5
        public ActionResult Delete(int id)
        {
            try
            {
               bool resp =  _icourse.DeletCourse(id);
                if(resp == false)
                {
                    TempData["MessageError"] = "You can not delete a course already mapped to a student";
                    return RedirectToAction(nameof(Index));
                }
                TempData["Message"] = "Course was deleted successfully";
                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {

                TempData["MessageError"] = e.Message.ToString();
                return RedirectToAction(nameof(Index));
            }
        }

        
    }
}
