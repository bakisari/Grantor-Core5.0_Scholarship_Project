using BussinesLayer.Concrete;
using DataAcessLayer.EntityFramework;
using EntityLayer.Concrate;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Grantor.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class SectionController : Controller
    {
        SectionManager sectionManager = new SectionManager(new EfSectionRepository());
        public IActionResult Index()
        {
            var values = sectionManager.AllList();
            return View(values);
        }
        /************* Add New Section **************/
        public IActionResult AddSection(Section section)
        {
            sectionManager.Add(section);
            return RedirectToAction("Index");
        }
 
    }
}
