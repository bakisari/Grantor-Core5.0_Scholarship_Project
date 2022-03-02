using BussinesLayer.Concrete;
using BussinesLayer.ValidationRules;
using DataAcessLayer.EntityFramework;
using EntityLayer.Concrate;
using FluentValidation.Results;
using Grantor.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Grantor.Controllers
{
    public class StudentRegisterController : Controller
        
    {
        public UserManager<AppUser> userManager { get; }
        public StudentRegisterController(UserManager<AppUser> userManager)
        {
            this.userManager = userManager;
        }

        StudentManager sm = new StudentManager(new EfStudentRepository());
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(AddProfileImage p)
        {

            Student std = new Student();
            if (p.Image != null)
            {
                var extansion = Path.GetExtension(p.Image.FileName);
                var newimagename = Guid.NewGuid() + extansion;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/UserImages/", newimagename);
                var stream = new FileStream(location, FileMode.Create);
                p.Image.CopyTo(stream);
                std.Image = newimagename;
            }
         
            std.FirstName = p.FirstName;
            std.LastName = p.LastName;
            std.Mail = p.Mail;
            std.Password = p.Password;
            std.Phone = p.Phone;


            StudentValidator sv = new StudentValidator();
            ValidationResult results = sv.Validate(std);
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
                string mail = p.Mail;
                var mailchecked = sm.StudentChecked(mail);
                if (mailchecked==null)
                {
                    std.Active = false;
                    std.Deleted = false;
                   
                    std.CreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                    ViewBag.notification = true;
                    sm.Add(std);
                    return View();
                }
                else
                {
                    ViewBag.notification = false;
                    return View();
                }
              
            }
        }
        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult>SignUp(UserSignUpViewModel userViewModel)
        {
            AppUser user = new AppUser();
            if (userViewModel.Image != null)
            {
                var extansion = Path.GetExtension(userViewModel.Image.FileName);
                var newimagename = Guid.NewGuid() + extansion;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/UserImages/", newimagename);
                var stream = new FileStream(location, FileMode.Create);
                userViewModel.Image.CopyTo(stream);
                user.Image = newimagename;
            }

            if (ModelState.IsValid)
            {
                user.UserName = userViewModel.EMail;
                user.FirstName = userViewModel.FirstName;
                user.LastName = userViewModel.LastName;
                user.Email = userViewModel.EMail;

                IdentityResult result = await userManager.CreateAsync(user,userViewModel.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Login");
                }
                else
                {
                    foreach (IdentityError item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
        
            }

            return View(userViewModel);
        }

    }
}
