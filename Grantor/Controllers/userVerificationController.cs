using Grantor.Areas.Admin.Controllers;
using Grantor.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Grantor.Controllers
{
    public class userVerificationController : BaseController
    {
        public userVerificationController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, RoleManager<AppRole> roleManager) : base(userManager, signInManager, roleManager)
        {
        }
        /* User Email Verification 
         * Kullanıcıya gönderilen tokeni bu alanda kontrol ediyoruz
         * token geçerli ise kullanıcının veri tabanındaki email doğrulama kısmını true ya set ediyoruz
         * hatalı ise hata mesajı dönderiyoruz
         */
        public async Task<IActionResult> ConfirmEmail(string userId, string token)
        {
            var user = await userManager.FindByIdAsync(userId);
            IdentityResult result = await userManager.ConfirmEmailAsync(user, token);
            if (result.Succeeded)
            {
                TempData["vericiationStatus"] = "Email adresiniz doğrulanmıştır.Giriş yapabilirsiniz.";
                return RedirectToAction("LogIn", "Login");
            }
            else
            {
                TempData["vericiationStatus"] = "Bir hata meydana geldi lütfen daha sonra tekrar deneyiniz.";
                return RedirectToAction("LogIn", "Login");

            }
          
        }
     
    }
}
