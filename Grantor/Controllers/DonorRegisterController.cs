using BussinesLayer.Concrete;
using BussinesLayer.ValidationRules;
using DataAcessLayer.EntityFramework;
using EntityLayer.Concrate;
using FluentValidation.Results;
using Grantor.Areas.Admin.Controllers;
using Grantor.Models;
using Grantor.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Grantor.Controllers
{
    public class DonorRegisterController : BaseController
    {
       
        public DonorRegisterController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, RoleManager<AppRole> roleManager) : base(userManager, signInManager, roleManager)
        {
        }


        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(DonorViewModel donorViewModel)
        {
            AppUser user = new AppUser();
            if (ModelState.IsValid)
            {
                user.PhoneNumber = donorViewModel.PhoneNumber;
                user.FirstName = donorViewModel.Name;
                user.UserName = donorViewModel.EMail;
                user.Email = donorViewModel.EMail;
                user.Active = true;
                user.Deleted = false;
                user.EmailConfirmed = true;
                user.IsStudent = false;
               
                IdentityResult result = await userManager.CreateAsync(user, donorViewModel.Password);
                if (result.Succeeded)
                {
                    bool notification = true;
                    var addRoleToUser = await userManager.AddToRoleAsync(user, "Donor");

                    ViewBag.notification = notification;
                    return View();
                }
                else
                {
                    AddModelError(result);
                }
            }
        
            return View(donorViewModel);
        }


    }
}
