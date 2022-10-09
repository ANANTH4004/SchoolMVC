using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace School.Controllers
{
    public class AdminController : Controller
    {
        SchoolDBEntities scl = null;
        public AdminController()
        {
            scl = new SchoolDBEntities();
        }

        public ActionResult StartPage()
        {
            return View();
        } public ActionResult test()
        {
            return View();
        }
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Student()
        {
            List<Student> students = new List<Student>();
           // Student s = new Student();
            foreach (var item in scl.Students)
            {
                students.Add(new Student { RollNo = item.RollNo, Name = item.Name, DOB = item.DOB, Class = item.Class });
            }
            return View(students);
        }
        //[HttpPost]
        //public ActionResult Index(FormCollection collection)
        //{
        //    return View();
        //}

        // GET: Admin/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/Create
        public ActionResult CreateStudent()
        {
            return View();
        }

        // POST: Admin/Create
        [HttpPost]
        public ActionResult CreateStudent(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
