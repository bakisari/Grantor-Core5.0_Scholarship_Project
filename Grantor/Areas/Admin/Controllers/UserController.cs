using BussinesLayer.Concrete;
using DataAcessLayer.EntityFramework;
using Grantor.Models;
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
    [Authorize(Roles = "Admin")]
    public class UserController : BaseController
    {
        public UserController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, RoleManager<AppRole> roleManager) : base(userManager, signInManager, roleManager)
        {
        }
        /* Active Student Controller */
        public async Task<IActionResult> ActiveStudent()
        {
            var values = await userManager.GetUsersInRoleAsync("Student");
            var userValues = values.Where(x => x.Active == true).ToList();
            return View(userValues);
        }

        /* User Deleted Controller*/

        public async Task<IActionResult> UserDelete(string id)
        {
            var user = await userManager.FindByIdAsync(id);
            if (user.Active == true)
            {
                user.Active = false;
                user.SiteShow = false;
                IdentityResult result = await userManager.UpdateAsync(user);
                if (result.Succeeded)
                {
                    return RedirectToAction("ActiveStudent", "User");
                }
                else
                {
                    AddModelError(result);
                    return RedirectToAction("ActiveStudent", "User");
                }
            }
            else
            {
                user.Active = false;
                user.SiteShow = false;
                user.Deleted = true;
                IdentityResult result = await userManager.UpdateAsync(user);
                if (result.Succeeded)
                {
                    return RedirectToAction("InActiveStudent", "User");
                }
                else
                {
                    AddModelError(result);
                    return RedirectToAction("InActiveStudent", "User");
                }
            }




        }
        //* Check Scholarship student*/
        public async Task<IActionResult> CheckScholarship(string id)
        {
            var user = await userManager.FindByIdAsync(id);
            if (user.SiteShow == true)
            {
                user.SiteShow = false;

            }
            else
            {
                user.SiteShow = true;

            }
            IdentityResult result = await userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                return RedirectToAction("ActiveStudent", "User");
            }
            else
            {
                ModelState.AddModelError("", "Bir Hata meydan geldi. Lütfen daha sonra tekrar deneyin.");
                return RedirectToAction("ActiveStudent", "User");
            }
        }

        /**************** In active Student Controller *********************/
        public async Task<IActionResult> InActiveStudent()
        {

            var values = await userManager.GetUsersInRoleAsync("Student");
            var userValues = values.Where(x => x.Active == false).Where(x => x.Deleted == false).ToList();
            return View(userValues);
        }
        /************** Donor Controller *********/
        public async Task<IActionResult> Donors()
        {
            var values = await userManager.GetUsersInRoleAsync("Donor");
            var donorValues = values.Where(x=>x.Active==true).ToList();
            return View(donorValues);
        }
    }
}
