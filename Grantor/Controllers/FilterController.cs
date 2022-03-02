using BussinesLayer.Concrete;
using DataAcessLayer.Concrete;
using DataAcessLayer.EntityFramework;
using EntityLayer.Concrate;
using Grantor.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Grantor.Controllers
{
    [Authorize]
    public class FilterController : Controller
    {
        StudentManager sm = new StudentManager(new EfStudentRepository());
     
      
       
        public IActionResult Index(string Gender = null, string University = null, string Faculty = null, string Section = null,string Maritial=null,string Death=null,string Work=null,string Physcial=null)
        {
            Lists lists = new Lists();
            ViewBag.vlu = lists.University();
            ViewBag.vls = lists.Sections();
            ViewBag.vlf = lists.Fakulte();
            var students = sm.GetStudentFilter(Gender,University,Faculty,Section,Maritial,Death,Work,Physcial);
            return View(students);

        }
      
    }
}

