using BussinesLayer.Concrete;
using DataAcessLayer.EntityFramework;
using EntityLayer.Concrate;
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
        
        [HttpGet]
        public IActionResult StudentProfile(int id)
        {
            
            List<SelectListItem> valuecategory = (from x in cm.AllList()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.CityName,
                                                      Value = x.CityID.ToString()
                                                  }).ToList();

            ViewBag.vlc = valuecategory;

            List<SelectListItem> valueuniversity = (from x in um.AllList()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.UniversityName,
                                                      Value = x.UniversityID.ToString()
                                                  }).ToList();

            ViewBag.vlu = valueuniversity;
            id = 16;
            var values =sm.GetByID(id);
            return View(values);
        }
        // Student edit or profile page
        [HttpPost]
        public IActionResult StudentProfile(Student student)
        {
            student.Active = true;
            sm.Update(student);
            ViewBag.notification ="true";
            TempData["notification"] = "deger";
            return RedirectToAction("StudentProfile");
        }

    }
}
