using BussinesLayer.Concrete;
using BussinesLayer.ValidationRules;
using DataAcessLayer.EntityFramework;
using EntityLayer.Concrate;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Grantor.Controllers
{
    public class StudentRegisterController : Controller
        
    {
        StudentManager sm = new StudentManager(new EfStudentRepository());
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Student student)
        {
            StudentValidator sv = new StudentValidator();
            ValidationResult results = sv.Validate(student);
            if (!results.IsValid)
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View();
            }
            else
            {
                student.Active = false;
                student.Deleted = false;
                student.CreateDate = DateTime.Parse( DateTime.Now.ToShortDateString());
                ViewBag.notification = "notnull";
                sm.Add(student);
                return View();
            }
        }

    }
}
