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
                user.Active = false;
                user.Deleted = false;
                user.IsStudent = true;
                IdentityResult result = await userManager.CreateAsync(user,userViewModel.Password);
              
              
                if (result.Succeeded)
                {
                    var addRoleToUser = await userManager.AddToRoleAsync(user, "Student");

                    /*************** User E-Mail Confirmed *************************
                     * token oluşturdur
                     * link oluşturduk
                     * oluşturulan token ve linki sendEmail methoduna gönderiyoruz
                     */
                    string confirmationToken = await userManager.GenerateEmailConfirmationTokenAsync(user);
                    string link = Url.Action("ConfirmEmail", "UserVerification", new
                    {
                        userId = user.Id,
                        token=confirmationToken,
                    },HttpContext.Request.Scheme);
                    Helper.EmailConfirmation.SendEmail(link,user.Email);
                   /****************************************************************/
                    return RedirectToAction("LogIn", "Login");
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
