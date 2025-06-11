using HospitalProject.Context;
using HospitalProject.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HospitalProject.Controllers
{
    public class DepartmentController : Controller
    {

        private readonly AppDbContext db = new AppDbContext();
        // GET: Department
        public ActionResult Index()
        {
            var departments = db.Departments.ToList();
            return View(departments);
        }
        [HttpGet]
        public ActionResult CreateDepartment()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateDepartment(Department department) 
        {
            if (ModelState.IsValid) 
            {
                db.Departments.Add(department);
                db.SaveChanges();
                return RedirectToAction("Index","Department");
            }
            return View(department);
        }
    }
}