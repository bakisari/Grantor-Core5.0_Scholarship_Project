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
    [Authorize(Roles ="Admin")]
    public class AdminController : BaseController
    {
        public AdminController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, RoleManager<AppRole> roleManager) : base(userManager, signInManager, roleManager)
        {
        }
        public async Task <IActionResult> Index()
        {
            // Rolü Admin Olan Kullanıcıları Listele

            var status = TempData["status"];
            ViewBag.status = status;
            var values = await userManager.GetUsersInRoleAsync("Admin");
            return View(values);
        }
        // Yeni Admin Ekleme İşlemi
        [HttpPost]
        public async Task<IActionResult> AddAdmin(AdminRegisterViewModel adminRegister)
        {
            AppUser user = new AppUser();
            if (ModelState.IsValid)
            {
                user.UserName = adminRegister.UserName;
                user.Email = adminRegister.EMail;
                user.Active = true;
                user.EmailConfirmed = true;
                
                IdentityResult result = await userManager.CreateAsync(user, adminRegister.Password);
                if (result.Succeeded)
                {
                    var addRoleToUser = await userManager.AddToRoleAsync(user, "Admin");
                   
                    return RedirectToAction("Index");


                }
                else
                {
                    foreach (IdentityError item in result.Errors)
                    {
                        
                        ModelState.AddModelError("", item.Description);
                      
                    }

                   
                  

                }
            }
            string status = "false";
            TempData["status"] = status;
            return RedirectToAction("Index");
        }
       
       /* Admin Update */
       public async Task<IActionResult> AdminEdit(int id)
        {
            var user = await userManager.FindByIdAsync(id.ToString());
            if (user.Deleted==true)
            {
                user.Deleted = false;
            }
            else
            {
                user.Deleted = true;
            }
            
            await userManager.UpdateAsync(user);
            return RedirectToAction("Index");
        }
    }
}
