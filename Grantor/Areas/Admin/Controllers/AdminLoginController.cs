using Grantor.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Grantor.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminLoginController :BaseController
    {
        public AdminLoginController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, RoleManager<AppRole> roleManager) : base(userManager, signInManager, roleManager)
        {
        }
        public IActionResult LogIn()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> LogIn(LoginViewModel userLogin)
        {
            if (ModelState.IsValid)
            {
                AppUser user = await userManager.FindByEmailAsync(userLogin.EMail);
                if (user != null)
                {
                    /***************** check user lock *************************************************/
                    if (await userManager.IsLockedOutAsync(user))
                    {
                        ModelState.AddModelError("", "Çok sayıda yanlış giriş yaptığınız için hesabınız kilitlenmiştir. Lütfen daha sonra tekrar deneyiniz.");
                        return View(userLogin);
                    }
                    /***********************************************************************************/


                    await SignInManager.SignOutAsync();
                    Microsoft.AspNetCore.Identity.SignInResult result = await SignInManager.PasswordSignInAsync(user, userLogin.Password, userLogin.RememberMe, false);
                    if (result.Succeeded)
                    {

                        /************** reset wrong login count if user logs in successfully ************/
                        await userManager.ResetAccessFailedCountAsync(user);
                        /********************************************************************************/

                        /* Email Verification*
                         *Email doğrulama işlemini kontrol ediyoruz
                         **/
                        if (user.Deleted != true)
                        {
                            if (userManager.IsEmailConfirmedAsync(user).Result == false)
                            {
                                ModelState.AddModelError("", "E-Posta Adresiniz Doğrulanmamıştır! Lütfen e-posta adresinizi onaylayın.");
                                return View(userLogin);
                            }
                            /*************************************/
                            var checkUserRole = userManager.IsInRoleAsync(user, "ADMIN");
                            var status = checkUserRole.Result;
                            if (status == true)
                            {
                                return RedirectToAction("Index", "Admin");
                            }
                            else
                            {
                                return View();
                            }
                        }

                        else
                        {
                            ModelState.AddModelError("", "Hesabınız Yönetici Tarafından Silinmiştir. Bir Sorun olduğunu düşünüyorsanız lütfen bizimle iletişime geçin.");
                        }

                    }
                    else
                    {
                        /******************* Increment the failed session value by one **********************/
                        await userManager.AccessFailedAsync(user);
                        /************** Users total failed login attempts **********************************/
                        int failed = await userManager.GetAccessFailedCountAsync(user);
                        /**************************************************/
                        ModelState.AddModelError("", $"Kalan Hatalı Giriş Hakkı : {3 - failed}");

                        /* If the user logs in 3 times unsuccessfully, they will lock their account for 5 minutes */
                        if (failed == 3)
                        {
                            await userManager.SetLockoutEndDateAsync(user, new DateTimeOffset(DateTime.Now.AddMinutes(5)));
                            ViewBag.UserLockoutError = true;
                        }
                        else
                        {
                            ModelState.AddModelError("", "E-Posta ve ya Şifre Hatalı");
                        }

                    }
                }
                else
                {
                    ModelState.AddModelError("", "Bu E-Posta adresine kayıtlı bir kullanıcı bulunamamıştır.");
                }
            }
            return View(userLogin);
        }
    }
}
