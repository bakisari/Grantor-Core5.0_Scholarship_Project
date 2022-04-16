using Grantor.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Grantor.Areas.Admin.Controllers
{
    
    public class BaseController : Controller
    {

        protected UserManager<AppUser> userManager { get; }
        protected RoleManager<AppRole> roleManager { get; }
        protected SignInManager<AppUser> SignInManager { get; }
        protected AppUser CurrentUser => userManager.FindByNameAsync(User.Identity.Name).Result;
        public BaseController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager,RoleManager<AppRole> roleManager)
        {
            this.userManager = userManager;
            this.SignInManager = signInManager;
            this.roleManager = roleManager;
        }
        public void AddModelError(IdentityResult result)
        {
            foreach (var item in result.Errors)
            {
                ModelState.AddModelError("", item.Description);
            }
        }

    }
}
