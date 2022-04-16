using Grantor.Models;
using Grantor.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Grantor.Areas.Admin.Controllers
{
    [Area("Admin")]
 
    public class RoleController : BaseController
    {
        public RoleController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, RoleManager<AppRole> roleManager) : base(userManager, signInManager, roleManager)
        {

        }
        public IActionResult CreateRole()
        {
            AppRole role = new AppRole();
            role.Name = "Admin";
            IdentityResult result = roleManager.CreateAsync(role).Result;

            if (result.Succeeded)

            {
                return RedirectToAction("Roles");
            }
            else
            {
                AddModelError(result);
            }

            return View();
        }
        [HttpPost]
        public IActionResult CreateRole(RoleViewModel roleViewModel)
        {
            return View();
        }

    }
}