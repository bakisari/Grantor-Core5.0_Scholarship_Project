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
    public class PasswordResetController : Controller
    {
        public UserManager<AppUser> userManager { get; }
        public SignInManager<AppUser> signInManager { get; }
        public PasswordResetController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }
        public IActionResult ResetPassword()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ResetPassword(PasswordResetViewModel resetViewModel)
        {
            AppUser user = userManager.FindByEmailAsync(resetViewModel.EMail).Result;
            if (user!=null)
            {
                string usermail = user.Email;
                string passwordResetToken = userManager.GeneratePasswordResetTokenAsync(user).Result;
                string passwordResetLink = Url.Action("ResetPasswordConfirm", "PasswordReset", new
                {
                    userId = user.Id,
                    token = passwordResetToken,
                    
                }, HttpContext.Request.Scheme); ;
                Helper.PasswordReset.PasswordResetSendEmail(passwordResetLink,usermail);
                ViewBag.status = "successfull";
            }
            else
            {
                ModelState.AddModelError("", "Sistemde kayıtlı e-posta adresi bulunamadı");
            }
            return View(resetViewModel);
        }

        // Şifre Yenileme Sayfası//
        public IActionResult ResetPasswordConfirm(string userId,string token)
        {
            TempData["userId"] = userId;
            TempData["token"] = token;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ResetPasswordConfirm(PasswordResetViewModel resetViewModel)
        {
            string userId = TempData["userId"].ToString();
            string token= TempData["token"].ToString();

            // Userid e ait kullanıcı varmı kontrol edelim
            AppUser user = await userManager.FindByIdAsync(userId);
            // kullanıcı varsa 
            if (user!=null)
            {
                IdentityResult result = await userManager.ResetPasswordAsync(user, token, resetViewModel.Password);
                if (result.Succeeded)
                {
                    await userManager.UpdateSecurityStampAsync(user);
                    ViewBag.status = "success";
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }
            else
            {
                ModelState.AddModelError("", "Bir hata meydana geldi lütfen daha sonra tekrar deneyiniz.");
            }
            return View(resetViewModel);
        }
    }
}   
