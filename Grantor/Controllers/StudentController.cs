using BussinesLayer.Concrete;
using BussinesLayer.ValidationRules;
using DataAcessLayer.EntityFramework;
using EntityLayer.Concrate;
using FluentValidation.Results;
using Grantor.Areas.Admin.Controllers;
using Grantor.Models;
using Grantor.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Grantor.Controllers
{
    [Authorize(Roles = "Student")]
    public class StudentController : BaseController
    {

        StUserManager _usermanager = new StUserManager(new EfUserRepository());
        CityManager cm = new CityManager(new EfCityRepository());
        UniversityManager um = new UniversityManager(new EfUniversityRepository());
        FacultyManager fm = new FacultyManager(new EfFacultyRepository());
        SectionManager sem = new SectionManager(new EfSectionRepository());

        public StudentController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, RoleManager<AppRole> roleManager) : base(userManager, signInManager, roleManager)
        {
        }

        [HttpGet]

        public IActionResult StudentProfile()
        {

            AppUser user = userManager.FindByEmailAsync(User.Identity.Name).Result;


            // *** Cities,University,Faculty and Section Lists***//
            Lists lists = new Lists();
            ViewBag.vlu = lists.University();
            ViewBag.vlf = lists.Fakulte();
            ViewBag.vlc = lists.Cities();
            ViewBag.vls = lists.Sections();


            return View(user);
        }


        // Student Edit or Profile Page
        [HttpPost]
        public IActionResult StudentProfile(UserEditProfileViewModel userEditProfile)
        {

            AppUser user = userManager.FindByEmailAsync(User.Identity.Name).Result;


            // *** Cities,University,Faculty and Section Lists***//
            Lists lists = new Lists();
            ViewBag.vlu = lists.University();
            ViewBag.vlf = lists.Fakulte();
            ViewBag.vlc = lists.Cities();
            ViewBag.vls = lists.Sections();


            user.CityID = userEditProfile.CityID;
            user.CreateDate = DateTime.Now;
            user.Deleted = false;
            user.FacultyID = userEditProfile.FacultyID;
            user.FamilyDeathStatus = userEditProfile.FamilyDeathStatus;
            user.FamilyMaritalStatus = userEditProfile.FamilyMaritalStatus;
            user.FamilyWorkStatus = userEditProfile.FamilyWorkStatus;
            user.UniversityID = userEditProfile.UniversityID;
            user.SectionID = userEditProfile.SectionID;
            user.PhyscialDisability = userEditProfile.PhyscialDisability;
            user.Gender = userEditProfile.Gender;
            user.BirthDate = userEditProfile.BirthDate;
            user.IBAN = userEditProfile.IBAN;
            user.PhoneNumber = userEditProfile.PhoneNumber.ToString();
            user.Active = true;

            UpdateProfileValidator upv = new UpdateProfileValidator();
            ValidationResult results = upv.Validate(user);
            if (!results.IsValid)
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View(user);
            }
            else
            {
                IdentityResult result = userManager.UpdateAsync(user).Result;
                if (result.Succeeded)
                {
                    ViewBag.notification = "success";
                    return View(user);
                }
                else
                {
                    AddModelError(result);
                    return View(user);
                }
            }


        }


        //  List of scholarship recipients
        [AllowAnonymous]
        [HttpGet]
        public IActionResult SelectedStudents()
        {
            //   var studentvalues = userManager.Users.Where(x => x.SiteShow == true).Where(x => x.Active == true).Where(x => x.Deleted== false).ToList();
            var studentvalues = _usermanager.StudentScholarship();
            return View(studentvalues);
        }

    }
}
