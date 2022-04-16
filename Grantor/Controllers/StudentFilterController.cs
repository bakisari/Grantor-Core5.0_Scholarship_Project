using BussinesLayer.Concrete;
using DataAcessLayer.EntityFramework;
using Grantor.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Grantor.Controllers
{
    [Authorize(Roles = "Donor")]
    public class StudentFilterController : Controller
    {
        StUserManager userManager = new StUserManager(new EfUserRepository());
        public IActionResult Index(string Gender = null, string University = null, string Faculty = null, string Section = null, string Maritial = null, string Death = null, string Work = null, string Physcial = null)
        {
            string? status = null;
            status = TempData["Status"]?.ToString();
            if (status!=null)
            {

                var control = "success";
                ViewBag.control = control;
                Lists lists = new Lists();
                ViewBag.vlu = lists.University();
                ViewBag.vls = lists.Sections();
                ViewBag.vlf = lists.Fakulte();
                var students = userManager.GetStudentFilter(Gender, University, Faculty, Section, Maritial, Death, Work, Physcial);
                var filterstudent = students.Where(x => x.Active == true).Where(x => x.IsStudent == true).ToList();
                return View(filterstudent);
            }
            else
            {
                Lists lists = new Lists();
                ViewBag.vlu = lists.University();
                ViewBag.vls = lists.Sections();
                ViewBag.vlf = lists.Fakulte();
                var students = userManager.GetStudentFilter(Gender, University, Faculty, Section, Maritial, Death, Work, Physcial);
                var filterstudent = students.Where(x => x.Active == true).Where(x => x.IsStudent == true).ToList();
                return View(filterstudent);
            }


        }
    }
}
