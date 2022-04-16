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
    public class UniversityController : Controller
    {
        UniversityManager universityManager = new UniversityManager(new EfUniversityRepository());
        public IActionResult Index()
        {
            var values = universityManager.AllList().Where(x=>x.Deleted==false).ToList();
            return View(values);
        }
        /*********** Add New University ********/
        public IActionResult AddUniversity(University university)
        {
            universityManager.Add(university);
            return RedirectToAction("Index");
        }
        /****** University Deleted **********/
        public IActionResult Delete(int id)
        {
            var university = universityManager.GetByID(id);
            university.Deleted = true;
            universityManager.Update(university);
            return RedirectToAction("Index");
        }
    }
}
