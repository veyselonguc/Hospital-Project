﻿using HospitalProject.Context;
using HospitalProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace HospitalProject.Controllers
{
    public class LoginController : Controller
    {
        AppDbContext db = new AppDbContext();
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Admin admin)
        {
            var value = db.Admins.FirstOrDefault(x=>x.Username == admin.Username && x.Password == admin.Password);
            if (value == null)
            {
                ModelState.AddModelError("", "Email veya şifre hatalı.");
                return View();
            }
            FormsAuthentication.SetAuthCookie(value.Username,true);
            return RedirectToAction("Index","Doctor");
        }
    }
}