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
        public ActionResult test()
        {
            return View();
        }
        public ActionResult StartPage()
        {
            return View();
        }
        // GET: Admin
        public ActionResult Student()
        {
            List<Student> students = new List<Student>();
            foreach (var item in scl.Students)
            {
                students.Add(new Student { RollNo= item.RollNo,Name=item.Name,DOB=item.DOB,ClassNo=item.ClassNo ,Class= item.Class});
            }
            return View(students);
        }

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
                Student s = new Student();
                s.RollNo =Int32.Parse( Request["RollNo"]);
                s.Name = Request["Name"];
                s.DOB = DateTime.Parse(Request["DOB"]);
                s.ClassNo = Int32.Parse(Request["ClassNo"]);
                scl.Students.Add(s);
                scl.SaveChanges();
                return RedirectToAction("Student");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/Edit/5
        public ActionResult EditStudent(int id)
        {
            Student s = scl.Students.ToList().Find(temp => temp.RollNo == id);
            return View(s);
        }

        // POST: Admin/Edit/5
        [HttpPost]
        public ActionResult EditStudent(int id, FormCollection collection)
        {
            try
            {
                Student s = scl.Students.ToList().Find(temp => temp.RollNo == id);
                s.DOB =DateTime.Parse( Request["DOB"]);
                s.Name = Request["Name"];
                s.ClassNo = Int32.Parse(Request["ClassNo"]);
                scl.SaveChanges();
                return RedirectToAction("Student");
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
