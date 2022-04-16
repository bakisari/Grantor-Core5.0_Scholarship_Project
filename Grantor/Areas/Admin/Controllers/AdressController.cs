using BussinesLayer.Concrete;
using DataAcessLayer.EntityFramework;
using EntityLayer.Concrate;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Grantor.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class AdressController : Controller
    {
        AdressManager adressManager = new AdressManager(new EfAdressRepository());
        public IActionResult Index()
        {
            var values = adressManager.GetByID(1);
            return View(values);
        }
        // Update Adress 
        public IActionResult UpdateAdress(Adress adress)
        {
            var values = adressManager.GetByID(1);
            values.Mail = adress.Mail;
            values.PhoneNumber = adress.PhoneNumber;
            values.AdressDetail = adress.AdressDetail;
            adressManager.Update(values);
            return RedirectToAction("Index");
        }
    }
}
