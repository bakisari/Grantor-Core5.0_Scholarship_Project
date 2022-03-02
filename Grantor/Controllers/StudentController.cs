using BussinesLayer.Concrete;
using BussinesLayer.ValidationRules;
using DataAcessLayer.EntityFramework;
using EntityLayer.Concrate;
using FluentValidation.Results;
using Grantor.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Grantor.Controllers
{
    [Authorize]
    public class StudentController : Controller
    {
        StudentManager sm = new StudentManager(new EfStudentRepository());
        CityManager cm = new CityManager(new EfCityRepository());
        UniversityManager um = new UniversityManager(new EfUniversityRepository());
        FacultyManager fm = new FacultyManager(new EfFacultyRepository());
        SectionManager sem = new SectionManager(new EfSectionRepository());

        [HttpGet]
        public IActionResult StudentProfile(int id)
        {
            var usermail = User.Identity.Name;
            var userid = sm.IDCheck(usermail);
            id = userid;
            
            // *** Cities,University,Faculty and Section Lists***//
            Lists lists = new Lists();
            ViewBag.vlu = lists.University();
            ViewBag.vlf = lists.Fakulte();
            ViewBag.vlc = lists.Cities();
            ViewBag.vls = lists.Sections();

           
            TempData["StudentID"] = id;
            var values = sm.GetByID(id);
            return View(values);
        }
        // Student edit or profile page
        [HttpPost]
        public IActionResult StudentProfile(Student student)
        {
            // *** Cities,University,Faculty and Section Lists***//
            Lists lists = new Lists();
            ViewBag.vlu = lists.University();
            ViewBag.vlf = lists.Fakulte();
            ViewBag.vlc = lists.Cities();
            ViewBag.vls = lists.Sections();

            UpdateProfileValidator upv = new UpdateProfileValidator();
            ValidationResult results = upv.Validate(student);
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
                student.Active = true;
               
                sm.Update(student);
                ViewBag.notification = "true";
                TempData["notification"] = "deger";
                return RedirectToAction("StudentProfile");
            }

        }
        [AllowAnonymous]
        public IActionResult SelectedStudents()
        {
            var studentvalues = sm.StudentDetails().Where(x=>x.SiteShow==true).Where(y=>y.Active==true).Where(z=>z.Deleted==false).ToList();
            return View(studentvalues);
        }

    }
}
