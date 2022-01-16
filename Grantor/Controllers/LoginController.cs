using BussinesLayer.Concrete;
using DataAcessLayer.EntityFramework;
using EntityLayer.Concrate;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Grantor.Controllers
{
    public class LoginController : Controller
    {
        StudentManager sm = new StudentManager(new EfStudentRepository());
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(Student student)
        {
            var datavalue = sm.GetStudent(student.Mail, student.Password);
            if (datavalue !=null)
            {

                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,student.Mail)
                };
                var useridentity = new ClaimsIdentity(claims, "a");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("StudentProfile", "Student");
            }
            else
            {
                ViewBag.error = "Kullanıcı Adı Ve Ya Şifre Hatalı";
                return View();
            }
        }
    }
}
