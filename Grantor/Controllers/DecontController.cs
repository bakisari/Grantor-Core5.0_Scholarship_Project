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
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Grantor.Controllers
{
    public class DecontController : BaseController
    {
        public DecontController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, RoleManager<AppRole> roleManager) : base(userManager, signInManager, roleManager)
        {
        }
        DecontManager decontManager = new DecontManager(new EfDecontRepository());

        public IActionResult Add(DecontViewModel decont)
        {
            AppUser user = userManager.FindByEmailAsync(User.Identity.Name).Result;
            Decont newDecont = new Decont();

            if (decont.Image!=null)
            {
                var extansion = Path.GetExtension(decont.Image.FileName);
                var newimagename = Guid.NewGuid() + extansion;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Deconts/", newimagename);
                var stream = new FileStream(location, FileMode.Create);
                decont.Image.CopyTo(stream);
                newDecont.Value = newimagename;
                newDecont.SenderID = user.Id;
                newDecont.ReceiverID =decont.ReceiverID;
            }
            DecontValidator dv = new DecontValidator();
            ValidationResult result = dv.Validate(newDecont);
            if (!result.IsValid)
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }

                return RedirectToAction("Index","StudentFilter");
            }
            else
            {
                decontManager.Add(newDecont);
                TempData["Status"] = "Success";
                return RedirectToAction("Index", "StudentFilter");

            }
        }

    }
}
