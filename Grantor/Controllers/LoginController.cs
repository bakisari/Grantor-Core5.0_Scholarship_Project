using BussinesLayer.Concrete;
using DataAcessLayer.EntityFramework;
using EntityLayer.Concrate;
using Grantor.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
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
        DonorManager dm = new DonorManager(new EfDonorRepository());
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(string Mail=null,string Password=null)
        {
          
            var datavalue = sm.GetStudent(Mail,Password);
            var datadonor = dm.GetDonor(Mail, Password);
            Student student = new Student();
            if (datavalue != null)
            {

                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,Mail),
                    new Claim(ClaimTypes.Role,"Donor")
                };
                var useridentity = new ClaimsIdentity(claims, "a");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("StudentProfile", "Student");
            }
           

            else if (datadonor!=null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,Mail)
             
                };
                var useridentity = new ClaimsIdentity(claims, "a");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index", "Filter");
            }
            else
            {
                ViewBag.error = "Kullanıcı Adı Ve Ya Şifre Hatalı";
                return View();
            }           

        }
        //****SignOut**
        
    }
}
