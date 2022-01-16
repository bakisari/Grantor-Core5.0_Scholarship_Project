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
    public class ContactController : Controller
    {
        ContactManager cm = new ContactManager(new EfContactRepository());
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        // Add contact message
        [HttpPost]
        public IActionResult Index(Contact contact)
        {
            ContactValidator cv = new ContactValidator();
            ValidationResult results = cv.Validate(contact);
            if (!results.IsValid)
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View();
            }
            else
            {
                contact.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
                contact.Status = false;
                cm.Add(contact);
                ViewBag.notification = true;
                return View();
            }
        }
    }
}
