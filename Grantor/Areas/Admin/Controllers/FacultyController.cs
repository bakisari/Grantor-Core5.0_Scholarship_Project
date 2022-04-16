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
    public class FacultyController : Controller
    {
        FacultyManager facultyManager = new FacultyManager(new EfFacultyRepository());
        public IActionResult Index()
        {
            var values = facultyManager.AllList().Where(x => x.Deleted == false).ToList();
            return View(values);
        }
        /************* Add New Faculty **************/
        public IActionResult AddFaculty(Faculty faculty)
        {
            facultyManager.Add(faculty);
            return RedirectToAction("Index");
        }
        /************ Deleted Faculty ************/
        public IActionResult Delete(int id)
        {
            var faculty = facultyManager.GetByID(id);
            faculty.Deleted = true;
            facultyManager.Update(faculty);
            return RedirectToAction("Index");
        }
    }
}
