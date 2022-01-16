using BussinesLayer.Concrete;
using BussinesLayer.ValidationRules;
using DataAcessLayer.EntityFramework;
using EntityLayer.Concrate;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Grantor.Controllers
{
    public class DonorRegisterController : Controller
    {
        DonorManager dm = new DonorManager(new EfDonorRepository());
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Donor donor)
        {
            DonorValidator dv = new DonorValidator();
            ValidationResult validation = dv.Validate(donor);
            if (!validation.IsValid)
            {
                foreach (var item in validation.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                    return View();
                }
            }
            else
            {
                ViewBag.notification = true;
                donor.Deleted = false;
                donor.Active = true;
                dm.Add(donor);
                
            }
            return View();


        }
    }
}
